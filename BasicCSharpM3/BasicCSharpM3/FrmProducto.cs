using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using System.Text.RegularExpressions;
using Infraestructura;
using Newtonsoft.Json;
using Domain.Enums;

namespace BasicCSharpM3
{
    public partial class FrmProducto : Form
    {
        //public int Cont { get; set; }
        ProductoModel productModel = new ProductoModel();
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string decripcion = txtDescripcion.Text;
            int codigo, cantidad;
            decimal precio;
            DateTime caducidad;

            try
            {
                ValidarProducto(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, txtCantidad.Text, txtPrecio.Text, txtCaducidad.Text, out codigo, out cantidad, out precio, out  caducidad);
                Producto p = new Producto()
                {
                    Codigo = codigo,
                    Nombre = nombre,
                    Descripcion = decripcion,
                    Cantidad = cantidad,
                    Precio = precio,
                    FechaCaducidad = caducidad,
                    UnidadMedida = (UnidadMedida)cmbUnidadM.SelectedIndex
                    //UnidadMedida=(UnidadMedida) Enum.GetValues(typeof(UnidadMedida)).GetValue(cmbUnidadM.SelectedIndex)
                };
                productModel.Add(p);
                PrintProducto(p);
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}",
                        "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
        private void ValidarProducto(string id, string name, string desc, string cantidad, string precio, string caducidad, out int cod, out int q, out decimal p, out DateTime caducity)
        {
            if (string.IsNullOrWhiteSpace(id) ||
               string.IsNullOrWhiteSpace(name) ||
               string.IsNullOrWhiteSpace(desc) ||
               string.IsNullOrWhiteSpace(cantidad) ||
               string.IsNullOrWhiteSpace(caducidad))
            {
                throw new ArgumentException("Error, todos los campos son necesarios.");
            }

            if (!int.TryParse(id, out cod))
            {
                throw new ArgumentException("Error, el codigo no tiene el formato correcto.");
            }

            if (!decimal.TryParse(precio, out p))
            {
                throw new ArgumentException("Error, el precio no tiene un formato correcto.");
            }
            if (p < 0)
            {
                throw new ArgumentException("Error, el precio no puede ser menor que 0");
            }
            if (!int.TryParse(cantidad, out q))
            {
                throw new ArgumentException("Error, la cantidad no tiene el formato correcto.");
            }
            if(q <0)
            {
                throw new ArgumentException("Error, la cantidad no puede ser menor a 0");
            }
            if (!DateTime.TryParse(caducidad, out caducity))
            {
                throw new ArgumentException("Error, la fecha no tiene el formato correcto DIA-MES-AÑO");
            }
            if (cmbUnidadM.SelectedIndex == -1)
            {
                throw new ArgumentException("Error, usted no ha seleccionado ninguna unidad de medida");
            }
        }
        private void PrintProducto(Producto p)
        {
            string text = $@"Codigo: {p.Codigo}
            Nombre: {p.Nombre}
            Descripcion:{p.Descripcion}
            Precio: {p.Precio}
            Cantidad: {p.Cantidad}
            Fecha de caducidad: {p.FechaCaducidad}
            Unidad de medida: {p.UnidadMedida}";
            MessageBox.Show(text,"Mensaje de informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void Limpiar()
        {
            txtCaducidad.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            cmbUnidadM.SelectedIndex = -1;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigoBuscar.Text, out int codigo))
            {
                MessageBox.Show($"El codigo que usted ingreso no se puede convertir"
                    , "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoBuscar.Text = string.Empty;
                return;
            }
            try
            {
                productModel.Delete(productModel.FindByID(codigo));
                MessageBox.Show("Se ha eliminado el producto","Mensaje de informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtCodigoBuscar.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El producto no se ha podido eliminar porque no existe","Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoBuscar.Text = string.Empty;
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show($"El codigo que usted ingreso no se puede convertir"
                    , "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string nombre = txtNombre.Text;
                string decripcion = txtDescripcion.Text;
                int cantidad;
                decimal precio;
                DateTime caducidad;

                ValidarProducto(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, txtCantidad.Text, txtPrecio.Text, txtCaducidad.Text, out codigo, out cantidad, out precio, out caducidad);
             
                Producto p = new Producto()
                {
                    Codigo = codigo,
                    Nombre = nombre,
                    Descripcion = decripcion,
                    Cantidad = cantidad,
                    Precio = precio,
                    FechaCaducidad = caducidad,
                    UnidadMedida = (UnidadMedida)cmbUnidadM.SelectedIndex
                    //UnidadMedida=(UnidadMedida) Enum.GetValues(typeof(UnidadMedida)).GetValue(cmbUnidadM.SelectedIndex)
                };
                productModel.Update(p);
                MessageBox.Show("El producto se ha actualizado correctamente","Mensaje de informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Limpiar();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}"
                    , "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se encontro producto con ese codigo para ser actualizado"
                    , "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            try
            {
                string s;
                Producto[] arregloProductos;
                switch (cmbBusqueda.SelectedIndex)
                {
                    //Unidad medida
                    case 0:
                        if (Enum.TryParse(txtDatoBusqueda.Text, out UnidadMedida unidadM))
                        {
                            arregloProductos = productModel.GetProductosByUnidadMedida(unidadM);
                            s = productModel.GetProductosAsJSON(arregloProductos);
                            MessageBox.Show("Productos encontrados, a continuacion se mostraran en el RichTextBox","Mensaje de informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            rtxtMensajeJson.Text = s;
                        }
                        else
                        {
                            MessageBox.Show($"La unidad de medida que usted ingreso es invalida o no ingreso ningun dato",
                                "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDatoBusqueda.Text = string.Empty;
                            return;
                        }
                        break;
                    //fecha
                    case 1:
                        if (!DateTime.TryParse(txtDatoBusqueda.Text, out DateTime caducidad))
                        {
                            MessageBox.Show($"No ingreso ningun dato o el dato es invalido",
                                "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDatoBusqueda.Text = string.Empty;
                            return;
                        }
                        arregloProductos = productModel.GetProductoByCaducidad(caducidad);
                        s = productModel.GetProductosAsJSON(arregloProductos);
                        MessageBox.Show("Productos encontrados, a continuacion se mostraran en el RichTextBox", "Mensaje de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rtxtMensajeJson.Text = s;
                        break;
                    //rango de precio
                    case 2:
                        if(!decimal.TryParse(txtPrecio1.Text, out decimal precio1) || 
                            !decimal.TryParse(txtDatoBusqueda.Text, out decimal precio2))
                        {
                            MessageBox.Show($"Los datos ingresados no se pueden converitr a valores decimales",
                                "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPrecio1.Text = string.Empty;
                            txtDatoBusqueda.Text = string.Empty;
                            break;
                        }
                        if (precio1 > precio2)
                        {
                            MessageBox.Show($"El precio 1 no puede ser mayor a precio 2",
                                "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPrecio1.Text = string.Empty;
                            txtDatoBusqueda.Text = string.Empty;
                            break;
                        }
                        arregloProductos = productModel.GetProductoByRangoPrecio(precio1, precio2);
                        s = productModel.GetProductosAsJSON(arregloProductos);
                        MessageBox.Show("Productos encontrados, a continuacion se mostraran en el RichTextBox", "Mensaje de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rtxtMensajeJson.Text = s;
                        break;
                    //codigo
                    case 3:
                        if (!int.TryParse(txtDatoBusqueda.Text, out int codigo))
                        {
                            MessageBox.Show($"El codigo que usted ingreso no se puede convertir"
                                , "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        try
                        {
                            Producto p = productModel.FindByID(codigo);
                            if (p != null)
                            {
                                PrintProducto(p);
                                txtDatoBusqueda.Text = string.Empty;
                            }
                            else
                            {
                                MessageBox.Show($"No hay ningun producto con ese codigo"
                                    , "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtDatoBusqueda.Text = string.Empty;
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"No hay productos para buscar"
                                    , "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtDatoBusqueda.Text = string.Empty;
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show($"No se selecciono ningun criterio de busqueda"
                        , "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                cmbBusqueda.SelectedIndex = -1;
                txtDatoBusqueda.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay productos que conincidan con dichas caracteristicas", "Mensaje de error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDatoBusqueda.Text = string.Empty;
                return;
            }
           
        }

        private void btnMostrarJson_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = productModel.GetProductosAsJSON(productModel.GetProductos());
                rtxtMensajeJson.Text = mensaje;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El arreglo de productos es nulo", "Mensaje de error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrdenarByPrecio_Click(object sender, EventArgs e)
        {
            try
            {
                Producto[] prodOrdenado = productModel.OrdenarByPrecio();
                string s = productModel.GetProductosAsJSON(prodOrdenado);
                MessageBox.Show("Productos ordenados correctamente, a continuacion se mostrarán en el RichTextBox",
                    "Mensaje de informacion", MessageBoxButtons.OK,MessageBoxIcon.Information);
                rtxtMensajeJson.Text = s;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El arreglo de productos es nulo", "Mensaje de error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecio1.Text = string.Empty;
            txtDatoBusqueda.Text = string.Empty;
            switch (cmbBusqueda.SelectedIndex)
            {
                //unidad de medida
                case 0:
                    txtPrecio1.Visible = false;
                    lblPrecioMayor.Visible = false;
                    lblPrecioMenor.Visible = false;
                    MessageBox.Show($@"Ingrese la unidad de medida con la que desea buscar el producto:
                    Unidades disponibles: 

                                            Unidad
                                            Litros
                                            Mililitros
                                            Libras
                                            Gramos
                                            Kilogramos","Mensaje de informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                //caducidad
                case 1:
                    txtPrecio1.Visible = false;
                    lblPrecioMayor.Visible = false;
                    lblPrecioMenor.Visible = false;
                    MessageBox.Show($@"Ingrese la fecha de caducidad en el siguiente formato:
                                            DIA-MES-AÑO

                    NOTA: Se mostraran todos los productos anteriores a esta fecha de caducidad",
                    "Mensaje de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                //rango de precio
                case 2:
                    txtPrecio1.Visible = true;
                    lblPrecioMayor.Visible = true;
                    lblPrecioMenor.Visible = true;
                    MessageBox.Show($@"Ingrese el rango de precio en el siguiente formato: 
                    
                    Precio menor - Precio mayor", "Mensaje de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    txtPrecio1.Visible = false;
                    lblPrecioMayor.Visible = false;
                    lblPrecioMenor.Visible = false;
                    break;
            }
        }
    }
}
