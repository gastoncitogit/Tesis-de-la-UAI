using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TPN2.Abstraccion;
using TPN2.Datos;
using TPN2.Entidades;
using System.Configuration;
using System.IO;

namespace TPN2.Mapper
{
    public class MPPDetalleCompra : IGestor<DetalleCompra>
    {
        private static readonly string ArchivoXml = Environment.CurrentDirectory + ConfigurationManager.AppSettings["XML_DetalleCompras"].ToString();

        public void Alta(DetalleCompra Objeto)
        {
            List<DetalleCompra> listaCompras = new List<DetalleCompra>();

            if (File.Exists(ArchivoXml))
                listaCompras = XmlHelper.FromXmlFile<List<DetalleCompra>>(ArchivoXml);

            int idMaximo = listaCompras.Select(r => r.ID)
                                        .DefaultIfEmpty()
                                        .Max();

            Objeto.ID = idMaximo + 1;

            listaCompras.Add(Objeto);
            XmlHelper.ToXmlFile(listaCompras, ArchivoXml);
        }

        public void Baja(DetalleCompra Objeto)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(DetalleCompra Objeto)
        {
            throw new NotImplementedException();
        }

        public List<DetalleCompra> TraerTodos()
        {
            List<DetalleCompra> listaDetallesDeCompra = new List<DetalleCompra>();

            if (File.Exists(ArchivoXml))
            {
                listaDetallesDeCompra = XmlHelper.FromXmlFile<List<DetalleCompra>>(ArchivoXml);
            }
            return listaDetallesDeCompra;
            
        }

    }
}
