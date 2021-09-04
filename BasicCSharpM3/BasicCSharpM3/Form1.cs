using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Domain.Enums;
using Infraestructura;
using Newtonsoft.Json;

namespace BasicCSharpM3
{
    public partial class Form1 : Form
    {
        public int Identificador { get; set; }
        EmpleadoModel emp = new EmpleadoModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombres, apellidos, dni;
            decimal salario;

            dni = txtDni.Text;
            nombres = txtNombres.Text;
            apellidos = txtApellidos.Text;

            string mensaje = Verificar(nombres, apellidos, dni);
            if (!mensaje.Equals(""))
            {
                MessageBox.Show($@"ERROR. {mensaje}",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                //LimpiarPantalla();
                return;
            }
            if (!decimal.TryParse(txtSalario.Text, out salario))
            {
                MessageBox.Show($@"ERROR. EL salario: {txtSalario.Text} no se pudo convertir",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                //LimpiarPantalla();
                return;
            }
            Empleado empleado = new Empleado()
            {
                Id = ++Identificador,
                Nombres = nombres,
                Apellidos = apellidos,
                Dni = dni,
                Salario = salario,
                NivelAcademico = (NivelAcademico)Enum.GetValues(typeof(NivelAcademico)).GetValue(cmbNivel.SelectedIndex),
                Genero=(Genero)Enum.GetValues(typeof(Genero)).GetValue(cmbGenero.SelectedIndex)
            };
            string json = JsonConvert.SerializeObject(empleado);
            Empleado empJson = (Empleado)JsonConvert.DeserializeObject<Empleado>(json);
            //string fromJson = @"{""Nombres"": ""Pepe"", ""Apellidos"": ""Carlo""}";
            //MessageBox.Show(fromJson);
            emp.Add(empleado);
            PrintEmpleado(empleado);
            LimpiarPantalla();
        }

        private void LimpiarPantalla()
        {
            //esto vacia las cadenas
            txtDni.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtSalario.Text = string.Empty;
            cmbGenero.SelectedIndex=-1;
            cmbNivel.SelectedIndex = -1;
        }
        private void PrintEmpleado(Empleado empleado)
        {
            MessageBox.Show($@"
                                Dni: {empleado.Dni}
                                Nombres: {empleado.Nombres}
                                Apellidos: {empleado.Apellidos}
                                Salario: {empleado.Salario}
                                Id: {empleado.Id}
                                Genero: {empleado.Genero}
                                Nivel Academico: {empleado.NivelAcademico}
                                Contador: {emp.GetEmpleados().Length}");
        }
        private string Verificar(string nombre, string apellido, string dni)
        {
            string modelo= @"\d{3}-\d{6}-\d{4}[A-Z]{1}";
            Regex miRegex = new Regex(modelo);
            MatchCollection elmatch = miRegex.Matches(dni);
            if(String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(apellido) || String.IsNullOrEmpty(dni))
            {
                return "Algunos campos estan vacios";
            }
            if (elmatch.Count > 0)
            {
            }
            else
            {
                return "El formato del dni no es valido";   
            }
            if (apellido.Length>20 || nombre.Length>20)
            {
                return "El nombre y/o apellido tienen mas de 20 caracteres";
            }
            return "";
        }
        private void btnFragmentar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal salario = decimal.Parse(txtSalario.Text);
                Fragmentacion f = new Fragmentacion()
                {
                    Millares = 0,
                    Decenas = 0,
                    Centenas = 0,
                    Centimos = 0,
                    Unidades = 0
                };

                f.Millares = (int)(salario / 1000);
                salario = salario % 1000;
                f.Centenas = (int)(salario / 100);
                salario = salario % 100;
                f.Decenas = (int)(salario / 10);
                salario = salario % 10;
                f.Unidades = (int)salario;
                f.Centimos = (int)((salario - f.Unidades) * 100);

                MessageBox.Show($@"El salario puede fragmentarse de la siguiente manera: 
                            Millares: {f.Millares}
                            Centenas: {f.Centenas}
                            Decenas: {f.Decenas}
                            Unidades: {f.Unidades}
                            Centimos: {f.Centimos}");
            }
            catch(Exception exc)
            {
                MessageBox.Show($@"ERROR. {exc.Message}",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnSalarioMaximo_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($@"El salario maximo es: {emp.GetMaximo()}");
            }
            catch(Exception exc)
            {
                MessageBox.Show($@"ERROR. {exc.Message}",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnSalarioMinimo_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($@"El salario minimo es: {emp.GetMinimo()}");
            }
            catch (Exception exc)
            {
                MessageBox.Show($@"ERROR. {exc.Message}",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnSalarioPromedio_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($@"El salario promedio es: {emp.GetPromedio()}");
            }
            catch (Exception exc)
            {
                MessageBox.Show($@"ERROR. {exc.Message}",
                                "Mensaje de error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnSalariosArribaPromedio_Click(object sender, EventArgs e)
        {
            string mensaje = emp.Mostrar(emp.GetArribaPromedio());
            MessageBox.Show($@"Los salarios arriba del promeido son: 
                            {mensaje}");
        }

        private void btnDebajoPromedio_Click(object sender, EventArgs e)
        {
            string mensaje = emp.Mostrar(emp.GetDebajoPromedio());
            MessageBox.Show($@"Los salarios debajo del promeido son: 
                            {mensaje}");
        }

        private void btnNivelMenor_Click(object sender, EventArgs e)
        {
            Empleado empNivelBajo = emp.MenorNivelAcademico();
            MessageBox.Show($@"
                                Dni: {empNivelBajo.Dni}
                                Nombres: {empNivelBajo.Nombres}
                                Apellidos: {empNivelBajo.Apellidos}
                                Salario: {empNivelBajo.Salario}
                                Id: {empNivelBajo.Id}
                                Genero: {empNivelBajo.Genero}
                                Nivel Academico: {empNivelBajo.NivelAcademico}
                                Contador: {emp.GetEmpleados().Length}");

        }
    }
}
