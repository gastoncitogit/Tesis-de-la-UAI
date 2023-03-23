using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN2.Entidades
{
    [Serializable]
    public class ProductoNacional : Producto
    {
        
        public string Provincia { get; set; }
        public ProductoNacional()
        {
            ValorAgregado = 100;
        }
        public override string ObtenerRegion()
        {
            return Provincia;
        }
        public override void AsignarRegion(string region)
        {
            Provincia = region;
        }
    }
}
