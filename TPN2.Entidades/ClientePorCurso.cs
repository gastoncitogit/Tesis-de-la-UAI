using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN2.Entidades
{
    public class ClientePorCurso : Entidad
    {
        public int FK_Cliente { get; set; }

        public int FK_Curso { get; set; }
    }
}
