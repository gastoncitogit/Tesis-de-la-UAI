using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN2.Entidades
{
    [Serializable]
    public class PuntosDeMenu : Permiso
    {
        public PuntosDeMenu(string pNombre, string PDescripcion) : base(pNombre, PDescripcion) { }

        public PuntosDeMenu() : base(){ }
        public override string GetPermisos()
        {
            return Nombre;
        }

    }
}
