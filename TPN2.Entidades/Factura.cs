using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN2.Entidades
{
    public class Factura : Entidad
    {
        public string NombreClienteComprador { get; set; }

        public DateTime fechaDeCompra { get; set; }

        public List<string> ListaProductos { get; set; }

        public Factura()
        {
            ListaProductos = new List<string>();
        }
    }
}
