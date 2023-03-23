using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPN2.Datos;
using TPN2.Abstraccion;
using TPN2.Entidades;
using System.Data;
using System.Configuration;
using System.IO;
using System.Security.Cryptography;


namespace TPN2.Mapper
{
    public class MPPProducto : IGestor<Producto>
    {
        private static readonly string ArchivoXml = Environment.CurrentDirectory + ConfigurationManager.AppSettings["XML_Productos"].ToString();

        public void Alta(Producto productoXml)
        {           
                List<Producto> listaProductos = new List<Producto>();

                if (File.Exists(ArchivoXml))
                    listaProductos = XmlHelper.FromXmlFile<List<Producto>>(ArchivoXml);

                int idMaximo = listaProductos.Select(r => r.ID)
                                            .DefaultIfEmpty()
                                            .Max();

                productoXml.ID = idMaximo + 1;

                listaProductos.Add(productoXml);
                XmlHelper.ToXmlFile(listaProductos, ArchivoXml);
        }

        public void Baja(Producto productoXml)
        {
            List<Producto> listaProductos = new List<Producto>();

            if (File.Exists(ArchivoXml))
                listaProductos = XmlHelper.FromXmlFile<List<Producto>>(ArchivoXml);

            var index = listaProductos.FindIndex(x => x.ID == productoXml.ID);
            listaProductos.RemoveAt(index);

            XmlHelper.ToXmlFile(listaProductos, ArchivoXml);
        }

        public void Modificacion(Producto productoXml)
        {
            List<Producto> listaProductos = new List<Producto>();

            if (File.Exists(ArchivoXml))
                listaProductos = XmlHelper.FromXmlFile<List<Producto>>(ArchivoXml);

            var index = listaProductos.FindIndex(x => x.ID == productoXml.ID);
            listaProductos[index] = productoXml;

            XmlHelper.ToXmlFile(listaProductos, ArchivoXml);
        }
        public List<Producto> TraerTodos()
        {
            List<Producto> listaProductos = new List<Producto>();

            if (File.Exists(ArchivoXml))
            {
                listaProductos = XmlHelper.FromXmlFile<List<Producto>>(ArchivoXml);
            }
            return listaProductos;       
        }

        public string ObtenerNombreProductoPorId(int pId)
        {
            List<Producto> listaProductos = new List<Producto>();

            if (File.Exists(ArchivoXml)) 
            {
                listaProductos = XmlHelper.FromXmlFile<List<Producto>>(ArchivoXml);
            }
            Producto productoAux = listaProductos.Find(x => x.ID == pId);
            return productoAux.Nombre;
        }
        public int ObtenerPrecioProductoPorId(int pId)
        {
            List<Producto> listaProductos = new List<Producto>();

            if (File.Exists(ArchivoXml))
            {
                listaProductos = XmlHelper.FromXmlFile<List<Producto>>(ArchivoXml);
            }
            Producto productoAux = listaProductos.Find(x => x.ID == pId);
            return productoAux.Precio;
        }

        public int ObtenerIdPorDescripcionEImporte(string pNombre, int pPrecio)
        {
            List<Producto> listaProductos = new List<Producto>();

            if (File.Exists(ArchivoXml))
            {
                listaProductos = XmlHelper.FromXmlFile<List<Producto>>(ArchivoXml);
            }
            Producto productoAux = listaProductos.Find(x => x.Nombre == pNombre && x.Precio == pPrecio);
            return productoAux.ID;
        }
    }
} 


