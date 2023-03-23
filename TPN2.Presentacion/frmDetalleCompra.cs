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

namespace TPN2.Presentacion
{
    public partial class frmDetalleCompra : Form
    {

        BLLCompra bllCompra;
        BLLUsuario bllUsuario;
        BLLProducto bLLProducto;
        BLLFactura bLLFactura;

        public frmDetalleCompra()
        {
            InitializeComponent();
            bllUsuario = new BLLUsuario();
            bLLProducto = new BLLProducto();
            bllCompra = new BLLCompra();
            bLLFactura = new BLLFactura();
        }

        private void frmDetalleCompra_Load(object sender, EventArgs e)
        {
            ActualizarGrillaClientes();
            ActualizarGrillaDetalleCompra();       
        }

        public void ActualizarGrillaClientes()
        {
            grillaClientes.DataSource = null;
            grillaClientes.DataSource = bllUsuario.TraerTodosLosClientes();
            grillaClientes.Columns[2].Visible = false;
            grillaClientes.Columns[5].Visible = false;
            grillaClientes.Columns[4].Visible = false;
        }

        public void ActualizarGrillaDetalleCompra()
        {
            if (grillaClientes.Rows.Count > 0)
            {
                try
                {
                    Cliente auxd = (Cliente)grillaClientes.CurrentRow.DataBoundItem;
                    List<Compra> listaComprasPorCliente = bllCompra.TraerTodasLasComprasPorUsuario(auxd.ID);

                    grillaDetalleCompra.DataSource = null;
                    grillaDetalleCompra.DataSource = ObtenerVistaDetalleDeCompra(listaComprasPorCliente);
                }
                catch (Exception ex) { MessageBox.Show("Error"); }
            }               
        }

        private void grillaClientes_SelectionChanged(object sender, EventArgs e)
        {
            txtFactura.Text = "";
            ActualizarGrillaDetalleCompra();
        }

        private List<DetalleCompraDto> ObtenerVistaDetalleDeCompra(List<Compra> listaComprasPorCliente)
        {
            List<DetalleCompraDto> listaVista = new List<DetalleCompraDto>();

            foreach (Compra compra in listaComprasPorCliente)
            {
                int cantidadProductos = 0;
                int montoTotal = 0;
              
                foreach(int productoId  in compra.ListaProductosComprados)
                {
                    cantidadProductos++;
                    montoTotal += bLLProducto.ObtenerPrecioProductoPorId(productoId);
                }

                DetalleCompraDto compraDto = new DetalleCompraDto() 
                { 
                    Fecha_de_la_Compra = compra.FechaDeLaCompra, 
                    Cantidad_De_Articulos = cantidadProductos, 
                    Monto_Total = montoTotal
                };

                listaVista.Add(compraDto);
            }

            return listaVista;
        }
        public void MostrarFacturaCorrespondiente()
        {
            
            if (grillaDetalleCompra.Rows.Count > 0)
            {
                Factura objFactura = new Factura();
                DetalleCompraDto compraSeleccionada = (DetalleCompraDto)grillaDetalleCompra.CurrentRow.DataBoundItem;
                objFactura = bLLFactura.TraerFacturaPorFecha(compraSeleccionada.Fecha_de_la_Compra);
                string listaMostradaCorrectamente = string.Join(",\n", objFactura.ListaProductos);
                txtFactura.Text = "Cliente:" + objFactura.NombreClienteComprador.ToString() + "\n" + "Fecha de la compra: " + objFactura.fechaDeCompra.ToString() + "\n" + listaMostradaCorrectamente + "\n" + "FARMACIA UAI" + "\n" + "Gracias por comprar!";
                
            }
            else
            {
                txtFactura.Text = "";
            }

        }

        private void grillaDetalleCompra_SelectionChanged(object sender, EventArgs e)
        {
            MostrarFacturaCorrespondiente();
        }
    }
}
