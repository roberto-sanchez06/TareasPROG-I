using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Domain.Enums;
using Newtonsoft.Json;

namespace Infraestructura
{
    public class ProductoModel
    {
        private Producto[] productos;
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public void Add(Producto p)
        {
            if (p == null)
            {
                throw new ArgumentException("Error, el producto no puede ser null.");
            }

            if (productos == null)
            {
                productos = new Producto[1];
                productos[0] = p;
                return;
            }

            Producto[] tmp = new Producto[productos.Length + 1];
            Array.Copy(productos, tmp, productos.Length);
            tmp[tmp.Length - 1] = p;
            productos = tmp;
        }
        public void Update(Producto p)
        {
            int index=-1;
            for(int i = 0; i < productos.Length; i++)
            {
                if (p.Codigo == productos[i].Codigo)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                productos[index] = p;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void Delete(Producto prod)
        {
            int index = GetIndex(prod);
            if (index != -1)
            {
                Producto[] temp = new Producto[productos.Length - 1];
                Array.Copy(productos, temp, index);
                if (index != productos.Length - 1)
                {
                    for (int i = index; i < productos.Length - 1; i++)
                    {
                        temp[i] = productos[i + 1];
                    }
                }
                productos = temp;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public int GetIndex(Producto p)
        {
            int i = 0;
            while (i < productos.Length)
            {
                if (p.Equals(productos[i]))
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        public Producto FindByID(int codigo)
        {
            int i = 0;
            while (i < productos.Length)
            {
                if (codigo == productos[i].Codigo)
                {
                    return productos[i];
                }
                i++;
            }
            return null;
        }
        public Producto[] GetProductosByUnidadMedida(UnidadMedida um)
        {

            if (productos != null)
            {
                Producto[] prod = null;
                for (int i = 0; i < productos.Length; i++)
                {
                    if (productos[i].UnidadMedida == um)
                    {
                        if (prod == null)
                        {
                            prod = new Producto[1];
                            prod[0] = productos[i];
                        }
                        else
                        {
                            Producto[] tmp = new Producto[prod.Length + 1];
                            Array.Copy(prod, tmp, prod.Length);
                            tmp[tmp.Length - 1] = productos[i];
                            prod = tmp;
                        }
                    }
                }
                return prod;
            }
            return null;
        }
        public Producto[] GetProductoByCaducidad(DateTime dt)
        {
            if(productos != null)
            {
                Producto[] prod = null;
                for (int i = 0; i < productos.Length; i++)
                {
                    if (productos[i].FechaCaducidad.CompareTo(dt) < 0)
                    {
                        if (productos[i] == null)
                        {

                            throw new ArgumentNullException("Error, no puede ser null");
                        }
                        if (prod == null)
                        {
                            prod = new Producto[1];
                            prod[0] = productos[i];

                        }
                        else
                        {
                            Producto[] tmp = new Producto[prod.Length + 1];
                            Array.Copy(prod, tmp, prod.Length);
                            tmp[tmp.Length - 1] = productos[i];
                            prod = tmp;
                        }
                    }
                }
                return prod;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public Producto[] GetProductoByRangoPrecio(decimal p1, decimal p2)
        {
            if (productos!=null)
            {
                Producto[] prod = null;
                for (int i = 0; i < productos.Length; i++)
                {
                    if ((productos[i].Precio >= p1) && (productos[i].Precio <= p2))
                    {
                        if (productos[i] == null)
                        {

                            throw new ArgumentNullException("Error, no puede ser null");
                        }
                        if (prod == null)
                        {
                            prod = new Producto[1];
                            prod[0] = productos[i];

                        }
                        else
                        {
                            Producto[] tmp = new Producto[prod.Length + 1];
                            Array.Copy(prod, tmp, prod.Length);
                            tmp[tmp.Length - 1] = productos[i];
                            prod = tmp;
                        }
                    }
                }
                return prod;
            }
            throw new ArgumentException();
        }
        public Producto[] OrdenarByPrecio()
        {
            if (productos != null)
            {
                Array.Sort(productos, new Producto.PrecioComparer());
                return productos;
            }
            else 
            {
                throw new ArgumentException();
            }
        }
        public string GetProductosAsJSON(Producto[] pr)
        {
            if (pr == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                string Encabezado = "Los datos de los productos son: ";
                for (int i = 0; i < pr.Length; i++)
                {
                    string json = JsonConvert.SerializeObject(pr[i], Formatting.Indented);
                    string cadena = "\n\n" + json;
                    Encabezado = string.Concat(Encabezado,cadena);
                }
                return Encabezado;
            }

        }

    }
}
