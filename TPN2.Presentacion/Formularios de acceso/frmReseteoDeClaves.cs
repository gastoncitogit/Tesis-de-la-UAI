using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPN2.LogicaDeNegocio;
using TPN2.Entidades;
using TPN2.Servicios;

namespace TPN2.Presentacion
{
    public partial class frmReseteoDeClaves : Form
    {
        BLLUsuario BLLUsuario;
        Cliente ClienteSeleccionado;
        public frmReseteoDeClaves()
        {
            InitializeComponent();
            BLLUsuario = new BLLUsuario();
            ClienteSeleccionado = new Cliente();
            cbClientes.DataSource = BLLUsuario.TraerTodosLosClientes();
            cbClientes.DisplayMember = "Mail";
        }

        private void CambiarContraseña()
        {
            ClienteSeleccionado = (Cliente)cbClientes.SelectedValue;
            ClienteSeleccionado.Contraseña = txtContraseñaNueva.Text;
            ClienteSeleccionado.Contraseña = Encriptacion.EncriptarClave(ClienteSeleccionado.Contraseña);
            BLLUsuario.Modificacion(ClienteSeleccionado);
            MessageBox.Show("Se ha reseteado la clave");

        }

        private void frmReseteoDeClaves_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtContraseñaNueva.Text == string.Empty)
            {
                MessageBox.Show("Tiene que ingresar una contraseña nueva, no puede estar vacia!!");
            }
            if (!ExpresionesRegulares.ContraseñaEsValida(txtContraseñaNueva.Text))
            {
                MessageBox.Show("La contraseña que intenta ingresar es invalida"); 
            }
            else
            {
                CambiarContraseña();
            }
            
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
