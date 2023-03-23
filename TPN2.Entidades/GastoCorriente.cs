using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN2.Entidades
{
    public class GastoCorriente : Entidad
    {
        public string Descripcion { get; set; }

        public int Importe { get; set; }

        public enum TipoDeGasto { Pago_De_Salario,Arreglo,Pago_a_Proveedor}

        public string TipoDeGastoSeleccionado { get; set; }
    }
}
