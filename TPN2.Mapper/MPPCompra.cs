using System;
using System.Collections.Generic;
using System.Data;
using TPN2.Abstraccion;
using TPN2.Datos;
using TPN2.Entidades;
using System.Configuration;
using System.Linq;
using System.IO;

namespace TPN2.Mapper
{
    public class MPPCompra : IGestor<Compra>
    {
        private static readonly string ArchivoXml = Environment.CurrentDirectory + ConfigurationManager.AppSettings["XML_Compras"].ToString();

        public void Alta(Compra objCompra)
        {
            List<Compra> listaCompras = new List<Compra>();

            if (File.Exists(ArchivoXml))
                listaCompras = XmlHelper.FromXmlFile<List<Compra>>(ArchivoXml);

            int idMaximo = listaCompras.Select(r => r.ID)
                                        .DefaultIfEmpty()
                                        .Max();

            objCompra.ID = idMaximo + 1;

            listaCompras.Add(objCompra);
            XmlHelper.ToXmlFile(listaCompras, ArchivoXml);
        }

        public void Baja(Compra objCompra)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Compra objCompra)
        {
            throw new NotImplementedException();
        }

        public List<Compra> TraerTodos()
        {
            List<Compra> listaCompras = new List<Compra>();

            if (File.Exists(ArchivoXml))
            {
                listaCompras = XmlHelper.FromXmlFile<List<Compra>>(ArchivoXml);
            }
            return listaCompras;          
        }
    }
}
