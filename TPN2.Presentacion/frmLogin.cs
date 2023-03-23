using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TPN2.LogicaDeNegocio;
using TPN2.Entidades;
using TPN2.Servicios;
using System.Xml;
using System.IO;

namespace TPN2.Presentacion
{
    public partial class frmLogin : Form
    {

        BLLUsuario bllUsuario;
        BLLUserRecord bllUserRecord;
        public frmLogin()
        {
            InitializeComponent();
            bllUsuario = new BLLUsuario();   
            bllUserRecord = new BLLUserRecord();
            FacilitarAcceso();
        }
        private void FacilitarAcceso()
        {
            txtMail.Text = "Admin@hotmail.com";
            txtClave.Text = "Admin1234!";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMail.Text != String.Empty && txtClave.Text != String.Empty)
            {
                string mail = txtMail.Text;
                string claveEncriptada = Encriptacion.EncriptarClave(txtClave.Text);
                Usuario usuarioIntentandoLoguear = bllUsuario.CargarUsuario(mail,claveEncriptada);

                if(usuarioIntentandoLoguear != null)
                {
                    UserRecord userXml = new UserRecord
                    {
                        Mail = mail
                    };
                    bllUserRecord.GuardarDatos(userXml);

                    frmMain obj = new frmMain(usuarioIntentandoLoguear);
                    this.Hide();
                    obj.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mail o contraseña invalidos, intente de vuelta.");
                }
            }
            else
            {
                MessageBox.Show("Por favor complete los 2 campos.");
            }
                     
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtMail.Text = string.Empty;
            txtClave.Text = string.Empty;
        }
    }
}
