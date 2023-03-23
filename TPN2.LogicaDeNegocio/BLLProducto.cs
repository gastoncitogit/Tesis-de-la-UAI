using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TPN2.Mapper;
using TPN2.Entidades;
using TPN2.Abstraccion;

namespace TPN2.LogicaDeNegocio
{
    public class BLLProducto : IGestor<Producto>
    {
        
        public BLLProducto()
        {
            productoMapper = new MPPProducto();
        }
        MPPProducto productoMapper;


        public void Alta(Producto Objeto)
        {
            productoMapper.Alta(Objeto);
        }

        public void Baja(Producto Objeto)
        {
            productoMapper.Baja(Objeto);
        }

        public void Modificacion(Producto Objeto)
        {
            productoMapper.Modificacion(Objeto);
        }

        public List<Producto> TraerTodos()
        {
            return productoMapper.TraerTodos();
        }

        public string ObtenerNombreProductoPorId(int pId)
        {
            return productoMapper.ObtenerNombreProductoPorId(pId);
        }
        public int ObtenerPrecioProductoPorId(int pId)
        {
            return productoMapper.ObtenerPrecioProductoPorId(pId);
        }
        public int ObtenerIdPorDescripcionEImporte(string pNombre, int pPrecio)
        {
            return productoMapper.ObtenerIdPorDescripcionEImporte(pNombre, pPrecio);
        }
    }
}
