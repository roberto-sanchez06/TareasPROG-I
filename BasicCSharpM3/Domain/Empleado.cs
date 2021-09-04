using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;
using Newtonsoft.Json;
namespace Domain
{
    //MemberSerialization.Optin
    [JsonObject(MemberSerialization.OptIn)]
    public class Empleado
    {
        [JsonProperty]
        public int Id { get; set; }
        [JsonProperty]
        [JsonRequired]
        public string Dni { get; set; }
        [JsonProperty]
        public string Nombres { get; set; }
        [JsonProperty]
        public string Apellidos { get; set; }
        [JsonProperty]
        public decimal Salario { get; set; }
        public Genero Genero { get; set; }
        public NivelAcademico NivelAcademico { get; set; }
        public class SalarioComparer: IComparer<Empleado>
        {
            public int Compare(Empleado x, Empleado y)
            {
                if (x.Salario > y.Salario)
                {
                    return 1;
                }
                else if (x.Salario < y.Salario)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public class NivelAcademicoComparer : IComparer<Empleado>
        {
            public int Compare(Empleado x, Empleado y)
            {
                if (x.NivelAcademico > y.NivelAcademico)
                {
                    return 1;
                }
                else if (y.NivelAcademico > x.NivelAcademico)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public class ApellidoComparer : IComparer<Empleado>
        {
            public int Compare(Empleado x, Empleado y)
            {
                return x.Apellidos.CompareTo(y.Apellidos);
            }
        }
    }
}
