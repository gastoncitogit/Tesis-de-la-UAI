using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPN2.Abstraccion;
using TPN2.Datos;
using TPN2.Entidades;
using System.Configuration;
using System.IO;

namespace TPN2.Mapper
{
    public class MPPPermiso : IGestor<Permiso>
    {
        private static readonly string ArchivoXml = Environment.CurrentDirectory + ConfigurationManager.AppSettings["XML_Permisos"].ToString();
        private static readonly string ArchivoPermisosPorPerfilXml = Environment.CurrentDirectory + ConfigurationManager.AppSettings["XML_PermisosPorPerfil"].ToString();
        public void Alta(Permiso permisoXml)
        {
            List<Permiso> listaPermisos = new List<Permiso>();

            if (File.Exists(ArchivoXml))
                listaPermisos = XmlHelper.FromXmlFile<List<Permiso>>(ArchivoXml);

            int idMaximo = listaPermisos.Select(r => r.ID)
                                        .DefaultIfEmpty()
                                        .Max();

            permisoXml.ID = idMaximo + 1;

            listaPermisos.Add(permisoXml);
            XmlHelper.ToXmlFile(listaPermisos, ArchivoXml);
        }

        public void Baja(Permiso Objeto)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Permiso Objeto)
        {
            throw new NotImplementedException();
        }

        public List<Permiso> TraerTodos()
        {
            List<Permiso> listaPermisos = new List<Permiso>();

            if (File.Exists(ArchivoXml))
            {
                listaPermisos = XmlHelper.FromXmlFile<List<Permiso>>(ArchivoXml);
            }
            return listaPermisos;
        }

        public void AsignarPermisoAPerfil(Perfil pPerfil, Permiso pPermiso)
        {
            List<PermisoPorPerfil> listaPermisosPorPerfil = new List<PermisoPorPerfil>();

            if (File.Exists(ArchivoPermisosPorPerfilXml))
                listaPermisosPorPerfil = XmlHelper.FromXmlFile<List<PermisoPorPerfil>>(ArchivoPermisosPorPerfilXml);

            int idMaximo = listaPermisosPorPerfil.Select(r => r.ID)
                                        .DefaultIfEmpty()
                                        .Max();

            PermisoPorPerfil nuevoPermisoPorPerfil = new PermisoPorPerfil();
            nuevoPermisoPorPerfil.ID = idMaximo + 1;
            nuevoPermisoPorPerfil.IdPadre = pPerfil.ID;
            nuevoPermisoPorPerfil.IdHijo = pPermiso.ID;
            

            listaPermisosPorPerfil.Add(nuevoPermisoPorPerfil);
            XmlHelper.ToXmlFile(listaPermisosPorPerfil, ArchivoPermisosPorPerfilXml);
        }


        public List<PermisoPorPerfil> TraerTodosLosPermisosPorPerfil()
        {
            List<PermisoPorPerfil> listaPermisosPorPerfil = new List<PermisoPorPerfil>();

            if (File.Exists(ArchivoPermisosPorPerfilXml))
            {
                listaPermisosPorPerfil = XmlHelper.FromXmlFile<List<PermisoPorPerfil>>(ArchivoPermisosPorPerfilXml);
            }
            return listaPermisosPorPerfil;
        }

        public void RemoverPermisosDelPerfilSeleccionado(Perfil pPerfilSeleccionado)
        {
            List<PermisoPorPerfil> listaDePermisosPorPerfil = TraerTodosLosPermisosPorPerfil().FindAll(x => x.IdPadre == pPerfilSeleccionado.ID);
            if (File.Exists(ArchivoPermisosPorPerfilXml))
            {
                listaDePermisosPorPerfil = XmlHelper.FromXmlFile<List<PermisoPorPerfil>>(ArchivoPermisosPorPerfilXml);
                listaDePermisosPorPerfil.RemoveAll(x => x.IdPadre == pPerfilSeleccionado.ID);
                XmlHelper.ToXmlFile(listaDePermisosPorPerfil, ArchivoPermisosPorPerfilXml);
                
            }
        }
    }
}
