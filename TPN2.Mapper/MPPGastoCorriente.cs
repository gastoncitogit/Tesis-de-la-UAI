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
    public class MPPGastoCorriente : IGestor<GastoCorriente>
    {
        private static readonly string ArchivoXml = Environment.CurrentDirectory + ConfigurationManager.AppSettings["XML_GastosCorrientes"].ToString();
        public void Alta(GastoCorriente gastoCorrienteXml)
        {
            List<GastoCorriente> listaGastos = new List<GastoCorriente>();

            if (File.Exists(ArchivoXml))
                listaGastos = XmlHelper.FromXmlFile<List<GastoCorriente>>(ArchivoXml);

            int idMaximo = listaGastos.Select(r => r.ID)
                                        .DefaultIfEmpty()
                                        .Max();

            gastoCorrienteXml.ID = idMaximo + 1;

            listaGastos.Add(gastoCorrienteXml);
            XmlHelper.ToXmlFile(listaGastos, ArchivoXml);
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
            List<GastoCorriente> listaGastos = new List<GastoCorriente>();

            if (File.Exists(ArchivoXml))
            {
                listaGastos = XmlHelper.FromXmlFile<List<GastoCorriente>>(ArchivoXml);
            }
            return listaGastos;
        }
    }
}
