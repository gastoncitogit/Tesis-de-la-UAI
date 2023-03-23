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
    public partial class frmProductoSecundario : Form
    {
        BLLProducto productoNegocio;
        public frmProductoSecundario()
        {
            InitializeComponent();
            productoNegocio = new BLLProducto();
        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmProductoSecundario_Load(object sender, EventArgs e)
        {

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
            if (!ExpresionesRegulares.PrecioEsValido(txtPrecio.Text))
            {
                mensajesDeError += "El precio que intenta ingresar es invalido.\n";
            }
            else if (txtPrecio.Text == string.Empty)
            {
                mensajesDeError += "Falta ingresar un precio.\n";
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

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            if (FormularioValidado())
            {
                try
                {

                    if (rdbNacional.Checked)
                    {


                        ProductoNacional productoNacionalNuevo = new ProductoNacional();
                        productoNacionalNuevo.Nombre = txtNombre.Text;
                        productoNacionalNuevo.Precio = Convert.ToInt32(txtPrecio.Text);
                        productoNacionalNuevo.Provincia = txtProvincia.Text;
                        productoNacionalNuevo.Precio = productoNacionalNuevo.ValorAgregado + productoNacionalNuevo.Precio;
                        MessageBox.Show($"Con valor agregado nacional el producto tendra un valor final de: {productoNacionalNuevo.Precio}.");
                        productoNegocio.Alta(productoNacionalNuevo);

                    }
                    else
                    {

                        ProductoInternacional productoInternacionalNuevo = new ProductoInternacional();
                        productoInternacionalNuevo.Nombre = txtNombre.Text;
                        productoInternacionalNuevo.Precio = Convert.ToInt32(txtPrecio.Text);
                        productoInternacionalNuevo.Pais = txtPais.Text;
                        productoInternacionalNuevo.Precio = productoInternacionalNuevo.ValorAgregado + productoInternacionalNuevo.Precio;
                        MessageBox.Show($"Con valor agregado nacional el producto tendra un valor final de: {productoInternacionalNuevo.Precio}.");
                        productoNegocio.Alta(productoInternacionalNuevo);

                    }
                    this.Close();

                }
                catch (Exception ex) { MessageBox.Show("Error, ingrese los datos por favor."); }
            }
            
        }

        private void rdbNacional_CheckedChanged(object sender, EventArgs e)
        {
            txtProvincia.Enabled = true;
            txtPais.Enabled = false;
        }

        private void rdbInternacional_CheckedChanged(object sender, EventArgs e)
        {
            txtPais.Enabled = true;
            txtProvincia.Enabled = false;
        }
    }
}
