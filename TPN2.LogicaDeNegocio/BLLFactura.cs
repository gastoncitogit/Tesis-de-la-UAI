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
    public class BLLFactura : IGestor<Factura>
    {
        MPPFactura facturaMapper;

        public BLLFactura()
        {
            facturaMapper = new MPPFactura();
        }
        public void Alta(Factura Objeto)
        {
            facturaMapper.Alta(Objeto);
        }

        public void Baja(Factura Objeto)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Factura Objeto)
        {
            throw new NotImplementedException();
        }

        public List<Factura> TraerTodos()
        {
            return facturaMapper.TraerTodos();
        }

        public Factura TraerFacturaPorFecha(DateTime fecha)
        {
            return facturaMapper.TraerTodos().Find(x => x.fechaDeCompra == fecha);
        }
    }
}
