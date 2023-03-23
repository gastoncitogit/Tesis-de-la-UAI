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
    public class BLLDevolucion : IGestor<Devolucion>
    {
        MPPDevolucion devolucionMapper;
        public BLLDevolucion()
        {
            devolucionMapper = new MPPDevolucion();
        }
        public void Alta(Devolucion pDevolucion)
        {
            devolucionMapper.Alta(pDevolucion);
        }

        public void Baja(Devolucion Objeto)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Devolucion Objeto)
        {
            throw new NotImplementedException();
        }

        public List<Devolucion> TraerTodos()
        {
            return devolucionMapper.TraerTodos();
        }

        public int TraerMontoTotalDeDevoluciones()
        {
            List<Devolucion> listaDevoluciones = TraerTodos();
            int montoTotal = 0;
            BLLProducto productoNegocio = new BLLProducto();

            foreach(Devolucion devolucion in listaDevoluciones)
            {
                montoTotal += productoNegocio.ObtenerPrecioProductoPorId(devolucion.IdProducto);
            }
            return montoTotal;
        }
    }
}
