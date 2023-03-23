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
    public class MPPFactura : IGestor<Factura>
    {
        private static readonly string ArchivoXml = Environment.CurrentDirectory + ConfigurationManager.AppSettings["XML_Facturas"].ToString();
        public void Alta(Factura pFactura)
        {
            List<Factura> listaFacturas = new List<Factura>();

            if (File.Exists(ArchivoXml))
                listaFacturas = XmlHelper.FromXmlFile<List<Factura>>(ArchivoXml);

            int idMaximo = listaFacturas.Select(r => r.ID)
                                        .DefaultIfEmpty()
                                        .Max();

            pFactura.ID = idMaximo + 1;

            listaFacturas.Add(pFactura);
            XmlHelper.ToXmlFile(listaFacturas, ArchivoXml);
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
            List<Factura> listaFacturas = new List<Factura>();

            if (File.Exists(ArchivoXml))
            {
                listaFacturas = XmlHelper.FromXmlFile<List<Factura>>(ArchivoXml);
            }
            return listaFacturas;
        }
    }
}
