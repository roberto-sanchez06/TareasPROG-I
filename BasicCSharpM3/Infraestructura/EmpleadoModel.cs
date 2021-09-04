using System;
using Domain;
namespace Infraestructura
{
    public class EmpleadoModel
    {
        private Empleado[] empleados;
        public EmpleadoModel()
        {
        }
        public void Add(Empleado e)
        {
            if (e == null)
            {
                throw new ArgumentNullException("ERROR. El parametro ingresado es nulo");
            }else if (empleados == null)
            {
                empleados = new Empleado[1];
                empleados[0] = e;
            }
            else
            {
                Empleado[] temp = new Empleado[empleados.Length];
                Array.Copy(empleados, temp, empleados.Length);
                empleados = new Empleado[temp.Length+1];
                Array.Copy(temp, empleados, temp.Length);
                empleados[empleados.Length - 1]=e;
            }
        }
        public Empleado[] GetEmpleados()
        {
            return empleados;
        }
        #region Private method
        public decimal GetMaximo()
        {
            decimal max = decimal.MinValue;
            if (empleados == null)
            {
                throw new ArgumentNullException("ERROR. No se ha ingresado todavia a ningun empleado");
            }
            else
            {
                for(int i = 0; i < empleados.Length; i++)
                {
                    if (empleados[i].Salario > max)
                    {
                        max = empleados[i].Salario;
                    }
                }
            }
            return max;
        }
        
        public decimal GetMinimo()
        {
            decimal min = decimal.MaxValue;
            if (empleados == null)
            {
                throw new ArgumentNullException("ERROR. No se ha ingresado todavia a ningun empleado");
            }
            else
            {
                for (int i = 0; i < empleados.Length; i++)
                {
                    if (empleados[i].Salario < min)
                    {
                        min = empleados[i].Salario;
                    }
                }
            }
            return min;
        }
        public decimal GetPromedio()
        {
            decimal promedio=0;
            if (empleados == null)
            {
                throw new ArgumentNullException("ERROR. No se ha ingresado todavia a ningun empleado");
            }
            else
            {
                for (int i = 0; i < empleados.Length; i++)
                {
                    promedio += empleados[i].Salario;
                }
            }
            return promedio/empleados.Length;
        }
        public Empleado[] GetArribaPromedio()
        {
            decimal promedio = GetPromedio();
            Empleado[] empleados=null;
            foreach(Empleado i in GetEmpleados())
            {
                if (i.Salario > promedio)
                {
                    if (empleados == null)
                    {
                        empleados = new Empleado[1];
                        empleados[0] = i;
                    }
                    else
                    {
                        Empleado[] temp = new Empleado[empleados.Length+1];
                        Array.Copy(empleados,temp,empleados.Length);
                        temp[temp.Length - 1] = i;
                        empleados = temp;
                    }
                }
            }

            return empleados;
        }

        public Empleado[] GetDebajoPromedio()
        {
            decimal promedio = GetPromedio();
            Empleado[] empleados = null;
            foreach (Empleado i in GetEmpleados())
            {
                if (i.Salario < promedio)
                {
                    if (empleados == null)
                    {
                        empleados = new Empleado[1];
                        empleados[0] = i;
                    }
                    else
                    {
                        Empleado[] temp = new Empleado[empleados.Length + 1];
                        Array.Copy(empleados,temp,empleados.Length);
                        temp[temp.Length - 1] = i;
                        empleados = temp;
                    }
                }
            }

            return empleados;
        }
        public Empleado MenorNivelAcademico()
        {
            Array.Sort(empleados,new Empleado.NivelAcademicoComparer());
            return empleados[0];
        }
        public string Mostrar(Empleado[] e)
        {
            string cadena = "";
            Empleado[] misEmpleados = e;
            if (misEmpleados == null)
            {
                return "El arreglo es nulo";
            }
            else
            {
                foreach (Empleado i in misEmpleados)
                {
                    string cadena2 = "\n"+Convert.ToString(i.Salario);
                    cadena = string.Concat(cadena,cadena2);
                }
                return cadena;
            }
        }
        #endregion
    }
}
