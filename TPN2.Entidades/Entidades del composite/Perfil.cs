using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPN2.Entidades.Entidades_del_composite;

namespace TPN2.Entidades
{
    [Serializable]
    public class Perfil : Permiso, IOperacionesPermiso
    {
        private List<Permiso> listaPermisos { get; set; }


        public Perfil(string pNombre, string pDescripcion) : base(pNombre, pDescripcion)
        {
            listaPermisos = new List<Permiso>();
        }

        public Perfil()
        {
            listaPermisos = new List<Permiso>();
        }
        
        public void Add(Permiso pPermiso)
        {
            listaPermisos.Add(pPermiso);
        }

        public void Remove(Permiso pPermiso)
        {
            listaPermisos.Remove(pPermiso);
        }

        public void Clear()
        {
            listaPermisos.Clear();
        }

        public List<Permiso> GetAll()
        {
            return listaPermisos;
        }

        public override string GetPermisos()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Permiso pPermiso in listaPermisos)
            {
                sb.Append(pPermiso.GetPermisos() + ";");
            }
            return sb.ToString();
        }


    }
}
