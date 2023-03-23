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
    public class BLLCurso : IGestor<Curso>
    {
        MPPCurso MPPCurso = new MPPCurso();
        public void Alta(Curso Objeto)
        {
            MPPCurso.Alta(Objeto);
        }


        public void Baja(Curso Objeto)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Curso Objeto)
        {
            throw new NotImplementedException();
        }

        public List<Curso> TraerTodos()
        {
            return MPPCurso.TraerTodos();
        }

        public void AgregarClienteACurso(ClientePorCurso pClientePorCurso)
        {
            MPPCurso.AgregarClienteACurso(pClientePorCurso);
        }

        public List<ClientePorCurso> ObtenerClientesDelCursoPorId(int pId)
        {
            return MPPCurso.ObtenerClientesDelCursoPorId(pId);
        }

        public bool ClienteExisteEnElCurso(int idCurso, int idCliente)
        {
            List<ClientePorCurso> lista = ObtenerClientesDelCursoPorId(idCurso);
            if (lista.Exists(x => x.FK_Cliente == idCliente && x.FK_Curso == idCurso))
                return true;
            else
                return false;
        }

        public bool CursoLleno(int idCurso)
        {
            List<ClientePorCurso> lista = ObtenerClientesDelCursoPorId(idCurso);
            if (lista.Count >= 3)
            {
                return false;
            }
            else
                return true;
        }
    }
}
