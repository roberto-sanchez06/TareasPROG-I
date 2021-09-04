using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Domain
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Producto
    {
        [JsonProperty]
        public int Codigo { get; set; }
        [JsonProperty]
        public string Nombre { get; set; }
        [JsonProperty]
        public string Descripcion { get; set; }
        [JsonProperty]
        public int Cantidad { get; set; }
        [JsonProperty]
        public decimal Precio { get; set; }
        [JsonProperty]
        public DateTime FechaCaducidad { get; set; }
        [JsonProperty]
        [JsonConverter(typeof(StringEnumConverter))]
        public UnidadMedida UnidadMedida { get; set; }
        public class PrecioComparer: IComparer<Producto>
        {
            public int Compare(Producto p1, Producto p2)
            {
                if (p1.Precio > p2.Precio)
                {
                    return 1;
                }
                else if (p1.Precio < p2.Precio)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        /*public override string ToString()
        {
            return $@"Nombre: {Nombre}
            Descripcion: {Descripcion}
            Precio: {Precio}
            Cantidad: {Cantidad}
            Codigo: {Codigo} 
            Caducidad: {FechaCaducidad}
            Unidad de medida: {(UnidadMedida)UnidadMedida}";
        }*/
    }
}
