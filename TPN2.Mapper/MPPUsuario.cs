using System;
using System.Collections.Generic;
using System.Data;
using TPN2.Abstraccion;
using TPN2.Datos;
using TPN2.Entidades;
using System.Configuration;
using System.IO;
using System.Linq;

namespace TPN2.Mapper
{
    public class MPPUsuario : IGestor<Usuario>
    {
        private static readonly string ArchivoXml = Environment.CurrentDirectory + ConfigurationManager.AppSettings["XML_Usuarios"].ToString();

        public void Alta(Usuario userXml)
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            if (File.Exists(ArchivoXml))
                listaUsuarios = XmlHelper.FromXmlFile<List<Usuario>>(ArchivoXml);

            int idMaximo = listaUsuarios.Select(r => r.ID)
                                        .DefaultIfEmpty()
                                        .Max();

            userXml.ID = idMaximo + 1;

            listaUsuarios.Add(userXml);
            XmlHelper.ToXmlFile(listaUsuarios, ArchivoXml);

        }

        public void Baja(Usuario userXml)
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            if (File.Exists(ArchivoXml))
                listaUsuarios = XmlHelper.FromXmlFile<List<Usuario>>(ArchivoXml);

            var index = listaUsuarios.FindIndex(x => x.ID == userXml.ID);
            listaUsuarios.RemoveAt(index);

            XmlHelper.ToXmlFile(listaUsuarios, ArchivoXml);
        }

        public void Modificacion(Usuario userXml)
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            if (File.Exists(ArchivoXml))
                listaUsuarios = XmlHelper.FromXmlFile<List<Usuario>>(ArchivoXml);

            var index = listaUsuarios.FindIndex(x => x.ID == userXml.ID);
            listaUsuarios[index] = userXml;

            XmlHelper.ToXmlFile(listaUsuarios, ArchivoXml);
        }

        public List<Cliente> TraerTodosLosClientes()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            if (File.Exists(ArchivoXml))
            {
                listaUsuarios = XmlHelper.FromXmlFile<List<Usuario>>(ArchivoXml);
            }
            return listaUsuarios.OfType<Cliente>().ToList();
        }

        public List<Usuario> TraerTodos()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            if (File.Exists(ArchivoXml))
            {
                listaUsuarios = XmlHelper.FromXmlFile<List<Usuario>>(ArchivoXml);
            }
            return listaUsuarios;
        }

        public Usuario CargarUsuario(string mail, string contraseña)
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            if (File.Exists(ArchivoXml))
                listaUsuarios = XmlHelper.FromXmlFile<List<Usuario>>(ArchivoXml);

            return listaUsuarios.Find(x => x.Mail == mail && x.Contraseña == contraseña);       
        }

        public string ObtenerNombrePorId(int pId)
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            if (File.Exists(ArchivoXml))
            {
                listaUsuarios = XmlHelper.FromXmlFile<List<Usuario>>(ArchivoXml);
            }
            Cliente UsuarioAux = (Cliente)listaUsuarios.Find(x => x.ID == pId);
            return UsuarioAux.Nombre;
        }
        public string ObtenerApellidoPorId(int pId)
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            if (File.Exists(ArchivoXml))
            {
                listaUsuarios = XmlHelper.FromXmlFile<List<Usuario>>(ArchivoXml);
            }
            Cliente UsuarioAux = (Cliente)listaUsuarios.Find(x => x.ID == pId);
            return UsuarioAux.Apellido;
        }


    }

}

