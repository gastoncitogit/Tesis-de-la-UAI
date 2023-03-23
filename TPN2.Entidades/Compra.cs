using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPN2.Entidades
{
    public class Compra : Entidad
    {
        public int IDCliente { get; set; }

        public List<int> ListaProductosComprados { get; set; }

        public DateTime FechaDeLaCompra { get; set; }

        public Compra() { }

        public Compra(int idCliente)
        {
            IDCliente = idCliente;
            ListaProductosComprados = new List<int>();
            FechaDeLaCompra = DateTime.Now;
        }

        public void AgregarProducto(int idProducto)
        {
            ListaProductosComprados.Add(idProducto);
        }

        public void EliminarProducto(int idProducto)
        {
            ListaProductosComprados.Remove(idProducto);
        }

        public void BorrarListaDeProductos()
        {
            ListaProductosComprados.Clear();
        }
    }
}
