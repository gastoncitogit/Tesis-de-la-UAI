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
    public partial class frmClienteSecundario : Form
    {
        Cliente ClienteNuevo;
        BLLUsuario bllUsuario;
        BLLPermiso bllPermiso;
        public frmClienteSecundario()
        {
            InitializeComponent();
            ClienteNuevo = new Cliente();
            bllUsuario = new BLLUsuario();
            bllPermiso = new BLLPermiso();
        }

        public bool FormularioValidado()
        {
            string mensajesDeError = string.Empty;

            if (!ExpresionesRegulares.MailEsValido(txtMail.Text))
            {
                mensajesDeError += "El mail que intenta ingresar es invalido.\n";
            }
            else if (txtMail.Text == string.Empty)
            {
                mensajesDeError += "Falta ingresar el mail.\n";
            }
            if (!ExpresionesRegulares.ContraseñaEsValida(txtContraseña.Text))
            {
                mensajesDeError += "La contraseña que intenta ingresar es invalida.\n";
            }
            else if (txtContraseña.Text == string.Empty)
            {
                mensajesDeError += "Falta ingresar la contraseña.\n";
            }

            if (!ExpresionesRegulares.NombreEsValido(txtNombre.Text))
            {
                mensajesDeError += "El nombre que intenta ingresar es invalido.\n";
            }
            else if(txtNombre.Text == string.Empty)
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

            if(mensajesDeError == string.Empty)
            {
                return true;
            }
            else
            {
                MessageBox.Show(mensajesDeError);
                return false;
            }
        }
        

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormularioValidado())
                {
                    ClienteNuevo.Mail = txtMail.Text;
                    ClienteNuevo.Contraseña = Encriptacion.EncriptarClave(txtContraseña.Text);
                    ClienteNuevo.Nombre = txtNombre.Text;
                    ClienteNuevo.Apellido = txtApellido.Text;
                    ClienteNuevo.PerfilAsignado = (int)cbPerfil.SelectedValue;
                    if (!bllUsuario.UsuarioYaExiste(ClienteNuevo))
                    {
                        bllUsuario.Alta(ClienteNuevo);
                        MessageBox.Show("El Cliente ha sido de alta exitosamente.");
                        this.Close();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("El mail ya existe!!");
                    }
                    
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmClienteSecundario_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void CargarCombo()
        {
            cbPerfil.DataSource = bllPermiso.TraerTodosPerfiles();
            cbPerfil.DisplayMember = "Nombre";
            cbPerfil.ValueMember = "ID";
        }

        private void lblAltaCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
