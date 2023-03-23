using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPN2.Entidades;
using TPN2.LogicaDeNegocio;

namespace TPN2.Presentacion
{
    public partial class frmAdministracionPermisos : Form
    {
        BLLPermiso bllPermiso;
        public frmAdministracionPermisos()
        {
            InitializeComponent();
        }

        private void frmAdministracionPermisos_Load(object sender, EventArgs e)
        {
            bllPermiso = new BLLPermiso();
            CargarCombo();
            ActualizarGrilla();


        }

        private void RefrescarTreeView()
        {
            Perfil perfilSeleccionado = (Perfil)dgvPerfiles.CurrentRow.DataBoundItem;
            tvPerfiles.Nodes.Clear();
            TreeNode root = new TreeNode(perfilSeleccionado.Descripcion);
            List<Permiso> listaPermisosDelPerfilSeleccionado = perfilSeleccionado.GetAll();
            foreach (Permiso permiso in listaPermisosDelPerfilSeleccionado)
            {
                ArmarTreeView(permiso, root);
            }
            tvPerfiles.Nodes.Add(root);
            tvPerfiles.ExpandAll();
            

        }

        private void ArmarTreeView(Permiso pPermiso, TreeNode nodo)
        {
            if (pPermiso is Perfil)
            {
                List<Permiso> lista = ((Perfil)pPermiso).GetAll();
                TreeNode nuevoRoot = new TreeNode(pPermiso.Descripcion);
                nodo.Nodes.Add(nuevoRoot);
                foreach (Permiso permiso in lista)
                {
                    ArmarTreeView(permiso, nuevoRoot);
                }
            }
            else
            {
                nodo.Nodes.Add(pPermiso.Descripcion);
            }

        }

        private void CargarCombo()
        {
            if (rbPerfil.Checked)
            {
                cbAdministracion.DataSource = bllPermiso.TraerTodosPerfiles();
                cbAdministracion.DisplayMember = "Nombre";
                cbAdministracion.ValueMember = "ID";

            }
            else
            {
                cbAdministracion.DataSource = bllPermiso.TraerTodosPuntosDeMenu();
                cbAdministracion.DisplayMember = "Nombre";
                cbAdministracion.ValueMember = "ID";
            }


        }

        private void rbPerfil_CheckedChanged(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void rbPuntosDeMenu_CheckedChanged(object sender, EventArgs e)
        {
            CargarCombo();
        }
        private void ActualizarGrilla()
        {
            dgvPerfiles.SelectionChanged -= dgvPerfiles_SelectionChanged; // Remove the handler.
            dgvPerfiles.DataSource = bllPermiso.TraerTodosPerfiles();
            dgvPerfiles.Columns[2].Visible = false;
            dgvPerfiles.SelectionChanged += dgvPerfiles_SelectionChanged; // Add the handler back.
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (dgvPerfiles.Rows.Count > 0)
            {
                Perfil perfilSeleccionado = (Perfil)dgvPerfiles.CurrentRow.DataBoundItem;
                Permiso Permiso = (Permiso)cbAdministracion.SelectedItem;
                if (Permiso.ID != perfilSeleccionado.ID)
                {
                    //Si permiso no es padre del perfil y no esta asignado
                    if (!bllPermiso.PermisoEsPadreDelPerfil(perfilSeleccionado, Permiso) && (!bllPermiso.PermisoYaEstaAsignadoAPerfil(perfilSeleccionado, Permiso)))
                    {
                        bllPermiso.AsignarPermisoAPerfil(perfilSeleccionado, Permiso);
                    }
                    else
                    {
                        MessageBox.Show("El permiso es padre del perfil seleccionado o bien ya existe en el perfil");
                    }
                }
                else
                {
                    MessageBox.Show("Ambos perfiles son iguales, seleccione otro.");
                }
                dgvPerfiles_SelectionChanged(sender, e);
            }
            else
            {
                MessageBox.Show("No hay perfiles a los cuales asignar permisos");
            }
            

        }

        private void dgvPerfiles_SelectionChanged(object sender, EventArgs e)
        {
            Perfil perfilSeleccionado = (Perfil)dgvPerfiles.CurrentRow.DataBoundItem;
            perfilSeleccionado.Clear();
            bllPermiso.CargarPermisosDelPerfilSeleccionado(perfilSeleccionado, perfilSeleccionado.ID);
            RefrescarTreeView();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.Rows.Count > 0)
            {
                Perfil perfilSeleccionado = (Perfil)dgvPerfiles.CurrentRow.DataBoundItem;
                bllPermiso.RemoverPermisosDelPerfilSeleccionado(perfilSeleccionado);
                dgvPerfiles_SelectionChanged(sender, e);
                

            }
        }
    }
}
