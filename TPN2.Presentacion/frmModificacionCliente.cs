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
    public partial class frmModificacionCliente : Form
    {
        private Cliente clienteAux;
        BLLPermiso bllPermiso;
        BLLUsuario bllUsuario;

        public frmModificacionCliente(Cliente clienteAux)
        {
            InitializeComponent();
            this.clienteAux = clienteAux;
            bllUsuario = new BLLUsuario();
            bllPermiso = new BLLPermiso();
        }
        public bool FormularioValidado()
        {
            string mensajesDeError = string.Empty;

            if (!ExpresionesRegulares.NombreEsValido(txtNombre.Text))
            {
                mensajesDeError += "El nombre que intenta ingresar es invalido.\n";
            }
            else if (txtNombre.Text == string.Empty)
            {
                mensajesDeError += "Falta ingresar el nombre.\n";
            }
            if (!ExpresionesRegulares.NombreEsValido(txtApellido.Text))
            {
                mensajesDeError += "El apellido que intenta ingresar es invalido.\n";
            }
            else if (txtApellido.Text == string.Empty)
            {
                mensajesDeError += "Falta ingresar el apellido.\n";
            }

            if (mensajesDeError == string.Empty)
            {
                return true;
            }
            else
            {
                MessageBox.Show(mensajesDeError);
                return false;
            }
        }
        private void CargarCombo()
        {
            cbPerfil.DataSource = bllPermiso.TraerTodosPerfiles();
            cbPerfil.DisplayMember = "Nombre";
            cbPerfil.ValueMember = "ID";
        }

        private void frmModificacionCliente_Load(object sender, EventArgs e)
        {
            CargarCombo();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormularioValidado())
                {
                    clienteAux.Nombre = txtNombre.Text;
                    clienteAux.Apellido = txtApellido.Text;
                    clienteAux.PerfilAsignado = (int)cbPerfil.SelectedValue;
                    bllUsuario.Modificacion(clienteAux);
                    MessageBox.Show("El Cliente ha sido modificado exitosamente.");
                    this.Close();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
