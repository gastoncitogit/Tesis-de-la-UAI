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
using TPN2.Servicios;

namespace TPN2.Presentacion
{
    public partial class frmDesencriptacion : Form
    {
        BLLUsuario bLLUsuario;
        public frmDesencriptacion()
        {
            InitializeComponent();
        }

        private void frmDesencriptacion_Load(object sender, EventArgs e)
        {
            bLLUsuario = new BLLUsuario();
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = bLLUsuario.TraerTodosLosClientes();
            dgvUsuarios.Columns[2].Visible = false;
            dgvUsuarios.Columns[5].Visible = false;
            dgvUsuarios.Columns[4].Visible = false;
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            Cliente ClienteAux = (Cliente)dgvUsuarios.CurrentRow.DataBoundItem;
            MessageBox.Show("La contraseña desencriptada es: " + Encriptacion.Desencriptar(ClienteAux.Contraseña));
        }
    }
}
