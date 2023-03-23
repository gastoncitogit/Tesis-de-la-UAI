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
    public partial class frmEstadoFinanciero : Form
    {
        BLLUsuario bLLUsuario;
        BLLProducto bLLProducto;
        BLLCompra bLLCompra;
        BLLDevolucion bllDevolucion;
        BLLGastoCorriente bLLGastoCorriente;
        public frmEstadoFinanciero()
        {
            InitializeComponent();
        }

        private int CargarClientesTotales()
        {
            List<Cliente> listaClientes = bLLUsuario.TraerTodosLosClientes();
            return listaClientes.Count();
        }

        private int CargarProductosTotales()
        {
            List<Producto> listaProductos = bLLProducto.TraerTodos();
            return listaProductos.Count();

           
        }

        private int CargarGanancias()
        {
            int gananciasTotales = bLLCompra.ObtenerImporteTotalDeLasCompras();
            return gananciasTotales;
        }
        private int CargarGastosEnDevoluciones()
        {
            int gastosTotales = bllDevolucion.TraerMontoTotalDeDevoluciones();
            return gastosTotales;
        }
        private int CargarGastosCorrientesTotales()
        {
            int gastosTotales = bLLGastoCorriente.TraerEgresosTotales();
            return gastosTotales;
        }
        private void frmEstadoFinanciero_Load(object sender, EventArgs e)
        {
            bLLGastoCorriente = new BLLGastoCorriente();
            bllDevolucion = new BLLDevolucion();
            bLLCompra = new BLLCompra();
            bLLUsuario = new BLLUsuario();
            bLLProducto = new BLLProducto();
            lblFacturacionProductos.Text = $"Total de ganancias: {CargarGanancias()}";
            lblTotalDeClientes.Text = $"Total de clientes: {CargarClientesTotales()}";
            lblTotalDeProductos.Text = $"Total de productos: {CargarProductosTotales()}";
            lblEgresosPorGastosCorrientes.Text = $"Egresos por gastos corrientes: {CargarGastosCorrientesTotales()}";
            lblEgresosPorDevoluciones.Text = $"Egresos por devoluciones: {CargarGastosEnDevoluciones()}";
        }

        private void btnVerDevoluciones_Click(object sender, EventArgs e)
        {
            dgvEgresos.DataSource = bllDevolucion.TraerTodos();
            //dgvEgresos.Columns[0].Visible = false;
            //dgvEgresos.Columns[1].Visible = false;
            dgvEgresos.Columns[4].Visible = false;
        }

        private void btnVerGastosCorrientes_Click(object sender, EventArgs e)
        {
            dgvEgresos.DataSource = bLLGastoCorriente.TraerTodos();
            dgvEgresos.Columns[3].Visible = false;
        }

        
    }
}
