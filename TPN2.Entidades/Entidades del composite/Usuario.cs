using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TPN2.Entidades
{
    [XmlInclude(typeof(Cliente))]
    [XmlInclude(typeof(Administrador))]
    [Serializable]
    public abstract class Usuario : Entidad
    {
        public string Mail { get; set; }

        public string Contraseña { get; set; }
    }
}
