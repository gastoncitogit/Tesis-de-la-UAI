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
    public class BLLUsuario : IGestor<Usuario>
    {
        MPPUsuario mppUsuario;

        public BLLUsuario()
        {
            mppUsuario = new MPPUsuario();
        }

        public void Alta(Usuario Objeto)
        {
            mppUsuario.Alta(Objeto);
        }

        public void Baja(Usuario Objeto)
        {
            mppUsuario.Baja(Objeto);
        }

        public void Modificacion(Usuario Objeto)
        {
            mppUsuario.Modificacion(Objeto);
        }

        public Usuario CargarUsuario(string mail, string contraseña)
        {
            return mppUsuario.CargarUsuario(mail, contraseña);
        }
        

        public List<Cliente> TraerTodosLosClientes()
        {
            return mppUsuario.TraerTodosLosClientes();
        }

        public List<Usuario> TraerTodos()
        {
            return mppUsuario.TraerTodos();
        }

        public string ObtenerNombrePorId(int pId)
        {
            return mppUsuario.ObtenerNombrePorId(pId);
        }
        public string ObtenerApellidoPorId(int pId)
        {
            return mppUsuario.ObtenerApellidoPorId(pId);
        }

        public bool UsuarioYaExiste(Usuario pUsuario)
        {
            List<Cliente> listaClientes = TraerTodosLosClientes();
            return listaClientes.Exists(x => x.Mail == pUsuario.Mail);
        }

    }
}
