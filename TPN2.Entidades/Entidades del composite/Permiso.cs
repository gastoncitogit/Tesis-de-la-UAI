using System;
using System.Xml.Serialization;

namespace TPN2.Entidades
{
    [XmlInclude(typeof(Perfil))]
    [XmlInclude(typeof(PuntosDeMenu))]
    [Serializable]
    public abstract class Permiso : Entidad
    {
        
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        public Permiso(string pNombre, string pDescripcion)
        {
            Nombre = pNombre;
            Descripcion = pDescripcion;
        }

        public Permiso() { }
        

        public abstract string GetPermisos();
    }
}
