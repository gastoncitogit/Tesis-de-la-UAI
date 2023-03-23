using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN2.Entidades
{
    public class PermisoPorPerfil : Entidad
    {
        public int IdPadre { get; set; }

        public int IdHijo { get; set; }
    }
}
