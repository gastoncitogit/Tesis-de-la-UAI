using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TPN2.Entidades
{
    [XmlInclude(typeof(ProductoInternacional))]
    [XmlInclude(typeof(ProductoNacional))]
    [Serializable]
    public abstract class Producto : Entidad
    {
        public string Nombre { get; set; }

        public int Precio { get; set; }

        public int ValorAgregado { get; set; }

        public Producto() { }

        public abstract string ObtenerRegion();

        public abstract void AsignarRegion(string region);
    }
}
