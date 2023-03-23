using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPN2.Abstraccion;
using TPN2.Datos;
using TPN2.Entidades;

namespace TPN2.Mapper
{
    public class MPPDevolucion : IGestor<Devolucion>
    {
        private static readonly string ArchivoXml = Environment.CurrentDirectory + ConfigurationManager.AppSettings["XML_Devoluciones"].ToString();

        public void Alta(Devolucion pDevolucion)
        {
            List<Devolucion> listaDevoluciones = new List<Devolucion>();

            if (File.Exists(ArchivoXml))
                listaDevoluciones = XmlHelper.FromXmlFile<List<Devolucion>>(ArchivoXml);

            int idMaximo = listaDevoluciones.Select(r => r.ID)
                                        .DefaultIfEmpty()
                                        .Max();

            pDevolucion.ID = idMaximo + 1;

            listaDevoluciones.Add(pDevolucion);
            XmlHelper.ToXmlFile(listaDevoluciones, ArchivoXml);
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
            List<Devolucion> listaDevoluciones = new List<Devolucion>();

            if (File.Exists(ArchivoXml))
            {
                listaDevoluciones = XmlHelper.FromXmlFile<List<Devolucion>>(ArchivoXml);
            }
            return listaDevoluciones;
        }
        
    }
}
