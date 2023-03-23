using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using TPN2.Datos;
using TPN2.Entidades;

namespace TPN2.Mapper
{
    public class MPPUserRecord
    {
        private static readonly string ArchivoXml = Environment.CurrentDirectory + ConfigurationManager.AppSettings["XML_HistorialDeLogin"].ToString();


        public void GuardarDatos(UserRecord userXml)
        {
            List<UserRecord> listaClientesLogueados = new List<UserRecord>();

            if (File.Exists(ArchivoXml))
            {
                listaClientesLogueados = XmlHelper.FromXmlFile<List<UserRecord>>(ArchivoXml);
            }

            listaClientesLogueados.Add(userXml);
            XmlHelper.ToXmlFile(listaClientesLogueados, ArchivoXml);
        }

        public List<UserRecord> TraerDatos()
        {
            List<UserRecord> listaClientesLogueados = new List<UserRecord>();

            if (File.Exists(ArchivoXml))
            {
                listaClientesLogueados = XmlHelper.FromXmlFile<List<UserRecord>>(ArchivoXml);
            }
            return listaClientesLogueados;  
        }
    }


}
