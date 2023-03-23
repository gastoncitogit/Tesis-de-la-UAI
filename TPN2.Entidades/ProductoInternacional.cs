using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPN2.Entidades
{
    [Serializable]
    public class ProductoInternacional : Producto
    {

        public string Pais { get; set; }


        public ProductoInternacional()
        {
            ValorAgregado = 200;
        }

        public override string ObtenerRegion()
        {
            return Pais;
        }
        public override void AsignarRegion(string region)
        {
            Pais = region;
        }
    }
}
