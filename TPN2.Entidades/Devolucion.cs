using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN2.Entidades
{
    public class Devolucion : Entidad
    {
        public int IdCliente { get; set; }

        public int IdProducto { get; set; }

        public enum TipoDeDevolucion {Producto_Equivocado,Dañado}

        public string TipoDeDevolucionSeleccionada { get; set; }

        public string ComentariosAdicionales { get; set; }     
    }
}
