using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPN2.Entidades;
using TPN2.LogicaDeNegocio;

namespace TPN2.Presentacion
{
    public partial class frmInscripcionCurso : Form
    {
        
        BLLCurso cursoNegocio;
        BLLUsuario ClienteNegocio;

        public frmInscripcionCurso()
        {
            InitializeComponent();
        }

        private void cbCursoSeleccionado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarComboCursos();
            CargarGrilla();
            
        }

        private void frmInscripcionCurso_Load(object sender, EventArgs e)
        {
            ClienteNegocio = new BLLUsuario();
            cursoNegocio = new BLLCurso();
            CargarComboCursos();
            CargarComboClientes();
            cbCursos_SelectionChangeCommitted(sender,e);
            
        }

        private void CargarComboClientes()
        {
            cbClientes.DataSource = ClienteNegocio.TraerTodosLosClientes();
            cbClientes.DisplayMember = "Nombre";
            cbClientes.ValueMember = "ID";

        }

        private void CargarComboCursos()
        {
           cbCursos.ValueMember = "ID";
           cbCursos.DisplayMember = "Descripcion";
           
           cbCursos.DataSource = cursoNegocio.TraerTodos();
        }

        

        private void CargarGrilla()
        {
            dgvAlumnosPorCurso.DataSource = null;
            dgvAlumnosPorCurso.DataSource = ObtenerListaDeClientesPorCurso();
            
        }

        private List<ClienteDelCursoDto> ObtenerListaDeClientesPorCurso()
        {
            int idDelCursoSeleccionado = (int)cbCursos.SelectedValue;
            List<ClientePorCurso> listaClientesPorCurso = cursoNegocio.ObtenerClientesDelCursoPorId(idDelCursoSeleccionado);
            return ObtenerVistaDeClientesPorCurso(listaClientesPorCurso);

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = (int)cbClientes.SelectedValue;
                int idCurso = (int)cbCursos.SelectedValue;
                if (!cursoNegocio.ClienteExisteEnElCurso(idCurso, idCliente) && cursoNegocio.CursoLleno(idCurso))
                {
                    ClientePorCurso ClientePorCursoSeleccionado = new ClientePorCurso
                    {
                        FK_Cliente = idCliente,
                        FK_Curso = idCurso
                    };
                    cursoNegocio.AgregarClienteACurso(ClientePorCursoSeleccionado);
                    CargarGrilla();
                }
                else
                    MessageBox.Show("El Cliente ya esta anotado en el curso o ya se lleno el cupo de 3 alumnos.");
            }
            catch { }
        }

        private List<ClienteDelCursoDto> ObtenerVistaDeClientesPorCurso(List<ClientePorCurso> pListaClientesPorCurso)
        {
            List<ClienteDelCursoDto> listaVista = pListaClientesPorCurso.Select(p =>  new ClienteDelCursoDto()
            {
                Nombre = ClienteNegocio.ObtenerNombrePorId(p.FK_Cliente),
                Apellido = ClienteNegocio.ObtenerApellidoPorId(p.FK_Cliente)
            }).ToList();

            return listaVista;
        }

        private void cbCursos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
