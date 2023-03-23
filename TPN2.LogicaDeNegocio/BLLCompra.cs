using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TPN2.Abstraccion;
using TPN2.Entidades;
using TPN2.Mapper;

namespace TPN2.LogicaDeNegocio
{   
    public class BLLCompra : IGestor<Compra>
    {
        public MPPCompra compraMapper;

        public BLLCompra() { compraMapper = new MPPCompra();}

        public void Alta(Compra objCompra)
        {
            compraMapper.Alta(objCompra);
        }

        public void Baja(Compra objCompra)
        {
            compraMapper.Baja(objCompra);
        }

        public void Modificacion(Compra objCompra)
        {
            compraMapper.Modificacion(objCompra);
        }

        public List<Compra> TraerTodos()
        {
            return compraMapper.TraerTodos();
        }

        public List<Compra> TraerTodasLasComprasPorUsuario(int pId)
        {
            return compraMapper.TraerTodos().FindAll(x => x.IDCliente == pId);
        }

        public List<int> TraerTodosLosProductosPorCompra(int idCompra)
        {
            return compraMapper.TraerTodos().FirstOrDefault(x => x.ID == idCompra).ListaProductosComprados;
        }

        public int ObtenerImporteTotalDeLasCompras()
        {
            int saldoTotal = 0;
            List<Compra> listaCompras = compraMapper.TraerTodos();
            BLLProducto bLLProducto = new BLLProducto();

            foreach(Compra compra in listaCompras)
            {
                foreach(int idProducto in compra.ListaProductosComprados)
                {
                    int precio = bLLProducto.ObtenerPrecioProductoPorId(idProducto);
                    saldoTotal += precio;
                }
            }
            return saldoTotal;          
        }
    }
}
