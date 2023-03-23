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
    public class MPPCurso : IGestor<Curso>
    {
        private static readonly string ArchivoXml = Environment.CurrentDirectory + ConfigurationManager.AppSettings["XML_Cursos"].ToString();
        private static readonly string ArchivoXmlAlumnosPorCurso = Environment.CurrentDirectory + ConfigurationManager.AppSettings["XML_AlumnosPorCurso"].ToString(); 


        public void Alta(Curso cursoXml)
        {
            List<Curso> listaCursos = new List<Curso>();

            if (File.Exists(ArchivoXml))
                listaCursos = XmlHelper.FromXmlFile<List<Curso>>(ArchivoXml);

            int idMaximo = listaCursos.Select(r => r.ID)
                                        .DefaultIfEmpty()
                                        .Max();

            cursoXml.ID = idMaximo + 1;

            listaCursos.Add(cursoXml);
            XmlHelper.ToXmlFile(listaCursos, ArchivoXml);
        }

        public void Baja(Curso Objeto)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Curso Objeto)
        {
            throw new NotImplementedException();
        }

        public List<Curso> TraerTodos()
        {
            List<Curso> listaCursos = new List<Curso>();

            if (File.Exists(ArchivoXml))
            {
                listaCursos = XmlHelper.FromXmlFile<List<Curso>>(ArchivoXml);
            }
            return listaCursos;
        }

        public void AgregarClienteACurso(ClientePorCurso pClientePorCurso)
        {
            List<ClientePorCurso> listaClientesPorCurso = new List<ClientePorCurso>();

            if (File.Exists(ArchivoXmlAlumnosPorCurso))
                listaClientesPorCurso = XmlHelper.FromXmlFile<List<ClientePorCurso>>(ArchivoXmlAlumnosPorCurso);

            int idMaximo = listaClientesPorCurso.Select(r => r.ID)
                                        .DefaultIfEmpty()
                                        .Max();

            pClientePorCurso.ID = idMaximo + 1;

            listaClientesPorCurso.Add(pClientePorCurso);
            XmlHelper.ToXmlFile(listaClientesPorCurso, ArchivoXmlAlumnosPorCurso);
        }

        public List<ClientePorCurso> ObtenerClientesDelCursoPorId(int pId)
        {
            List<ClientePorCurso> listaCursos = new List<ClientePorCurso>();

            if (File.Exists(ArchivoXmlAlumnosPorCurso))
            {
                listaCursos = XmlHelper.FromXmlFile<List<ClientePorCurso>>(ArchivoXmlAlumnosPorCurso);
            }

            listaCursos = listaCursos.FindAll(r => r.FK_Curso == pId);
            return listaCursos;
        }
    }
}
