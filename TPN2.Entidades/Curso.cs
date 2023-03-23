using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN2.Entidades
{
    public class Curso : Entidad
    {
        public string Descripcion { get; set; }

        public DateTime FechaDeInicio { get; set; }

        public DateTime FechaDeFinalizacion { get; set; }
    }
}
