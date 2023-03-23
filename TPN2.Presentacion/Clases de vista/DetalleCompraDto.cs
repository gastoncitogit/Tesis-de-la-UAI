using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TPN2.Entidades;

namespace TPN2.Presentacion
{
    public class DetalleCompraDto
    {
        public DateTime Fecha_de_la_Compra { get; set; }

        public int Cantidad_De_Articulos { get; set; }

        public int Monto_Total { get; set; }
    }
}
