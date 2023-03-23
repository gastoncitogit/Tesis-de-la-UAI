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
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;


namespace TPN2.Presentacion
{
    public partial class frmClientes : Form
    {
        BLLUsuario bllUsuario;
        Cliente ClienteNuevo;
        

        public frmClientes()
        {
            InitializeComponent();
            bllUsuario = new BLLUsuario();
            ClienteNuevo = new Cliente();
        }
        private void ActualizarGrilla()
        {
            GrillaClientes.DataSource = null;
            GrillaClientes.DataSource = bllUsuario.TraerTodosLosClientes();
            GrillaClientes.Columns[2].Visible = false;
            GrillaClientes.Columns[5].Visible = false;
            GrillaClientes.Columns[4].Visible = false;
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            frmClienteSecundario frm = new frmClienteSecundario();
            frm.ShowDialog();
            ActualizarGrilla();
        }

        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            
            if (GrillaClientes.Rows.Count > 0)
            {
                try
                {
                    Cliente ClienteSeleccionado = (Cliente)GrillaClientes.CurrentRow.DataBoundItem;
                    bllUsuario.Baja(ClienteSeleccionado);
                    ActualizarGrilla();

                }
                catch (Exception ex) { MessageBox.Show("Error"); }
            }

            else
            {
                btnBajaCliente.Enabled = false;
                MessageBox.Show("No hay Clientes para eliminar.");
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (GrillaClientes.Rows.Count > 0)
            {
                try
                {
                    Cliente ClienteAux = (Cliente)GrillaClientes.CurrentRow.DataBoundItem;
                    frmModificacionCliente frmAux = new frmModificacionCliente(ClienteAux);
                    frmAux.ShowDialog();
                    ActualizarGrilla();

                }
                catch (Exception ex) { MessageBox.Show("Error"); }
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

    }
}
