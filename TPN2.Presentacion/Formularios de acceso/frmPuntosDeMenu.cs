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
    public partial class frmPuntosDeMenu : Form
    {

        BLLPermiso bllPermiso;
        List<string> listaMenues;

        public frmPuntosDeMenu(List<string> listaDePuntosDeMenu)
        {
            InitializeComponent();
            listaMenues = listaDePuntosDeMenu;   
            bllPermiso = new BLLPermiso();
        }

        private void frmPuntosDeMenu_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            GrillaPuntosDeMenu.DataSource = bllPermiso.TraerTodosPuntosDeMenu();
            GrillaPuntosDeMenu.Columns[2].Visible = false;

        }

        private void CargarCombo()
        {
            cbMenuStrip.DataSource = listaMenues;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            PuntosDeMenu puntosDeMenuaux = new PuntosDeMenu();
            puntosDeMenuaux.Nombre = (string)cbMenuStrip.SelectedValue;
            puntosDeMenuaux.Descripcion = txtDescripcion.Text;

            if (!bllPermiso.PermisoYaExiste(puntosDeMenuaux) && txtDescripcion.Text != string.Empty)
            {
                
                bllPermiso.Alta(puntosDeMenuaux);
                CargarGrilla();
                txtDescripcion.Text = "";
            }
            else
            {
                MessageBox.Show("El punto de menu ya existe o esta vacia la descripcion!");
            }    
        }
    }
}
