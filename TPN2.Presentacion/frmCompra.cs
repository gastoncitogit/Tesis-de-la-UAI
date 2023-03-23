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
using TPN2.Presentacion.Clases_de_vista;

namespace TPN2.Presentacion
{
    public partial class frmCompra : Form
    {
        BLLProducto productoNegocio;
        BLLUsuario ClienteNegocio;
        Cliente ClienteSeleccionado;
        Compra compraARealizar;
        Factura facturaARealizar;
        BLLFactura facturaNegocio;
        public frmCompra()
        {
            InitializeComponent();
            productoNegocio = new BLLProducto();
            ClienteNegocio = new BLLUsuario();
            facturaARealizar = new Factura();
            facturaNegocio = new BLLFactura();
        }

        public void CargarClientes()
        {
            GrillaClientesCargados.DataSource = null;
            GrillaClientesCargados.DataSource = ClienteNegocio.TraerTodosLosClientes();
            GrillaClientesCargados.Columns[2].Visible = false;
            GrillaClientesCargados.Columns[5].Visible = false;
            GrillaClientesCargados.Columns[4].Visible = false;
        }
        
        public void MostrarCompra()
        {
            GrillaCarritoCliente.DataSource = null;
            GrillaCarritoCliente.DataSource = ObtenerVistaCompra();
        }
        private List<ProductoDto> ObtenerVistaCompra()
        {
            List<ProductoDto> listaVista = compraARealizar.ListaProductosComprados.Select(p => new ProductoDto()
            {
                Nombre = productoNegocio.ObtenerNombreProductoPorId(p),
                Precio = productoNegocio.ObtenerPrecioProductoPorId(p)
            }).ToList();

            return listaVista;  
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {

            CargarClientes();
        }

        public void CargarProductos()
        {
            GrillaProductosCargados.DataSource = productoNegocio.TraerTodos();
            GrillaProductosCargados.Columns[3].Visible = false;
        }
        

        private void ActualizarMontoTotal()
        {
            int saldoTotal = 0;
            BLLProducto bLLProducto = new BLLProducto();
            foreach (int idProducto in compraARealizar.ListaProductosComprados)
            {
                int precio = bLLProducto.ObtenerPrecioProductoPorId(idProducto);
                saldoTotal += precio;
            }

            lblMontoCalculado.Text = saldoTotal.ToString();
        }

        private void btnCambiarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("Si usted desea cambiar de Cliente, se borrara la compra.", "", MessageBoxButtons.OKCancel);

                if( respuesta == DialogResult.OK)
                {
                    LimpiarCampos();
                }
            }
            catch (Exception ex) { MessageBox.Show("ERROR"); }
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteSeleccionado = (Cliente)GrillaClientesCargados.CurrentRow.DataBoundItem;
                compraARealizar = new Compra(ClienteSeleccionado.ID);
                btnSeleccionarCliente.Enabled = false;
                btnCambiarCliente.Enabled = true;
                GrillaClientesCargados.Enabled = false;
                btnAgregarProducto.Enabled = true;
                CargarProductos();
            }
            catch (Exception ex) { MessageBox.Show("ERROR"); }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (GrillaProductosCargados.Rows.Count > 0)
            {
                Producto productoSeleccionado = (Producto)GrillaProductosCargados.CurrentRow.DataBoundItem;
                compraARealizar.AgregarProducto(productoSeleccionado.ID);
                btnComprar.Enabled = true;

                ActualizarMontoTotal();
                MostrarCompra();
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if(GrillaCarritoCliente.Rows.Count > 0)
            {
                ProductoDto productoSeleccionado = (ProductoDto)GrillaCarritoCliente.CurrentRow.DataBoundItem;
                int idProducto = productoNegocio.ObtenerIdPorDescripcionEImporte(productoSeleccionado.Nombre, productoSeleccionado.Precio);
                compraARealizar.EliminarProducto(idProducto);
                ActualizarMontoTotal();
                MostrarCompra();
            }

            btnComprar.Enabled = (GrillaCarritoCliente.Rows.Count > 0);
        }

        

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                BLLCompra bllCompra = new BLLCompra();
                bllCompra.Alta(compraARealizar);
                GenerarFactura();
                MessageBox.Show("La compra ha sido realizada exitosamente.");
                GrillaProductosCargados.DataSource = null;
                GrillaCarritoCliente.DataSource = null;
                lblMontoCalculado.Text = "0";
                LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }              
        }
        public void GenerarFactura()
        {
            
            foreach(int productoID in compraARealizar.ListaProductosComprados)
            {
                facturaARealizar.ListaProductos.Add($"Nombre del producto: {productoNegocio.ObtenerNombreProductoPorId(productoID)} Precio:{productoNegocio.ObtenerPrecioProductoPorId(productoID)}");
            }
            ClienteSeleccionado = (Cliente)GrillaClientesCargados.CurrentRow.DataBoundItem;
            facturaARealizar.NombreClienteComprador = ClienteNegocio.ObtenerNombrePorId(ClienteSeleccionado.ID);
            facturaARealizar.fechaDeCompra = compraARealizar.FechaDeLaCompra;
            facturaNegocio.Alta(facturaARealizar);
            
        }

        private void LimpiarCampos()
        {
            compraARealizar.BorrarListaDeProductos();
            ClienteSeleccionado = null;
            btnSeleccionarCliente.Enabled = true;
            btnCambiarCliente.Enabled = false;
            GrillaClientesCargados.Enabled = true;
            GrillaProductosCargados.DataSource = null;
            btnAgregarProducto.Enabled = false;
            GrillaCarritoCliente.DataSource = null;
        }

        
    }
}
