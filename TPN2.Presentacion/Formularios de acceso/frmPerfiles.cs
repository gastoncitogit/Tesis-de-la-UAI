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
    public partial class frmPerfiles : Form
    {
        Perfil perfilNuevo;
        BLLPermiso bllPermiso;

        private void ActualizarGrilla()
        {
            GrillaPerfiles.DataSource = bllPermiso.TraerTodosPerfiles();
        }
        
        public frmPerfiles()
        {
            InitializeComponent();
            perfilNuevo = new Perfil();
            bllPermiso = new BLLPermiso();
            ActualizarGrilla();
            
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
            if (!ExpresionesRegulares.DescripcionEsValida(txtDescripcion.Text))
            {
                mensajesDeError += "La descripcion que intenta ingresar es invalida.\n";
            }

            else if (txtDescripcion.Text == string.Empty)
            {
                mensajesDeError += "Falta ingresar la descripcion.\n";
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
        private void btnAltaPerfil_Click(object sender, EventArgs e)
        {
            perfilNuevo.Descripcion = txtDescripcion.Text;
            perfilNuevo.Nombre = txtNombre.Text;
            if (!bllPermiso.PermisoYaExiste(perfilNuevo))
            {
                if (FormularioValidado())
                {
                    bllPermiso.Alta(perfilNuevo);
                    ActualizarGrilla();
                }
            }
            else
            {
                MessageBox.Show("El perfil ya ha sido dado de alta!");
            }
            
           

        }

        private void frmPerfiles_Load(object sender, EventArgs e)
        {
            GrillaPerfiles.Columns["ID"].Visible = false;
        }
    }
}
