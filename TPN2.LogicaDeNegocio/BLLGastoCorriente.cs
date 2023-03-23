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
    public class BLLGastoCorriente : IGestor<GastoCorriente>
    {
        MPPGastoCorriente gastoCorrienteMapper;

        public BLLGastoCorriente()
        {
            gastoCorrienteMapper = new MPPGastoCorriente();
        }
        public void Alta(GastoCorriente Objeto)
        {
            gastoCorrienteMapper.Alta(Objeto);
        }

        public void Baja(GastoCorriente Objeto)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(GastoCorriente Objeto)
        {
            throw new NotImplementedException();
        }

        public List<GastoCorriente> TraerTodos()
        {
            return gastoCorrienteMapper.TraerTodos();
        }
        public int TraerEgresosTotales()
        {
            int saldoTotal = 0;
            List<GastoCorriente> listaGastos = gastoCorrienteMapper.TraerTodos();
            foreach (GastoCorriente s in listaGastos)
            {
                saldoTotal += s.Importe;
            }
            return saldoTotal;

        }
    }
}
