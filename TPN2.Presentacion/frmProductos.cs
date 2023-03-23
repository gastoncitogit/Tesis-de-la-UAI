using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using TPN2.Entidades;
using TPN2.LogicaDeNegocio;

namespace TPN2.Presentacion
{
    public partial class frmProductos : Form
    {

        BLLProducto productoNegocio;
        BLLFactura facturaNegocio;
        BLLDevolucion devolucionNegocio;
       

        public frmProductos()
        {
            InitializeComponent();
            productoNegocio = new BLLProducto();
            facturaNegocio = new BLLFactura();
            devolucionNegocio = new BLLDevolucion();
            
        }

        private void GrillaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActualizarGrilla()
        {
            GrillaProductos.DataSource = productoNegocio.TraerTodos();
            GrillaProductos.Columns[3].Visible = false;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

            frmProductoSecundario frmSecundario = new frmProductoSecundario();
            frmSecundario.ShowDialog();
            ActualizarGrilla();
                 
        }
        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (GrillaProductos.Rows.Count > 0)
            {
                try
                {
                    Producto productoSeleccionado = (Producto)GrillaProductos.CurrentRow.DataBoundItem;
                    List<Factura> listaFacturas = facturaNegocio.TraerTodos();
                    List<Devolucion> listaDevoluciones = devolucionNegocio.TraerTodos();
                    if (listaFacturas.Any(x => x.ListaProductos.Any(y => y.Contains(productoSeleccionado.Nombre))))
                    {
                        
                        MessageBox.Show("Ese producto esta asociado a una factura, no es posible darlo de baja.");

                    }
                    if (listaDevoluciones.Any(x => x.ID == productoSeleccionado.ID))
                    {
                        MessageBox.Show("Ese producto esta asociado a una devolucion, no es posible darlo de baja.");
                    }
                    else
                    {
                        productoNegocio.Baja(productoSeleccionado);

                        ActualizarGrilla();
                    }

                    

                }
                catch (Exception ex) { MessageBox.Show("Error"); }

            }

            else
            {
                MessageBox.Show("No hay productos para eliminar.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (GrillaProductos.Rows.Count > 0)
            {
                try
                {

                    Producto productoModificado = (Producto)GrillaProductos.CurrentRow.DataBoundItem;

                    productoModificado.Nombre = Interaction.InputBox("Agregue un nuevo nombre por favor:  ");
                    productoModificado.Precio = Convert.ToInt32(Interaction.InputBox("Agrege un nuevo precio por  favor:  "))+ productoModificado.ValorAgregado;


                    productoNegocio.Modificacion(productoModificado);


                    ActualizarGrilla();

                }
                catch (Exception ex) { MessageBox.Show("Error"); }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
