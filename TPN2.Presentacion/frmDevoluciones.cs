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
using static TPN2.Entidades.GastoCorriente;
using static TPN2.Entidades.Devolucion;
using TPN2.Presentacion.Clases_de_vista;

namespace TPN2.Presentacion
{
    public partial class frmDevoluciones : Form
    {      
        BLLUsuario usuarioNegocio;
        BLLProducto productoNegocio;
        BLLDevolucion devolucionNegocio;
        BLLCompra compraNegocio;

        public frmDevoluciones()
        {
            InitializeComponent();
        }

        private void frmDevoluciones_Load(object sender, EventArgs e)
        {
            compraNegocio = new BLLCompra();
            devolucionNegocio = new BLLDevolucion();
            usuarioNegocio = new BLLUsuario();
            productoNegocio = new BLLProducto();
            CargarComboClientes();
        }

        public void CargarComboClientes()
        {
            cbClientes.DataSource = usuarioNegocio.TraerTodosLosClientes();
            cbClientes.ValueMember = "ID";
            cbClientes.DisplayMember = "Nombre";          
        }

        private void CargarComboCompras()
        {          
            cbCompras.DataSource = compraNegocio.TraerTodasLasComprasPorUsuario((int)cbClientes.SelectedValue);
            cbCompras.ValueMember = "ID";
            cbCompras.DisplayMember = "FechaDeLaCompra";
        }

        public void CargarComboProductos()
        {
            cbProductos.DataSource = ObtenerVistaProducto(compraNegocio.TraerTodosLosProductosPorCompra((int)cbCompras.SelectedValue));
            cbProductos.ValueMember = "IdProducto";
            cbProductos.DisplayMember = "Nombre";
            cbMotivo.DataSource = Enum.GetValues(typeof(Devolucion.TipoDeDevolucion));
        }

        private void CargarTxt()
        {
            int pId = (int)cbProductos.SelectedValue;
            txtPrecioProducto.Text = productoNegocio.ObtenerPrecioProductoPorId(pId).ToString();
        }

        private List<ProductoDevolucionDto> ObtenerVistaProducto(List<int> listaIdsProductos)
        {
            List<ProductoDevolucionDto> listaVista = new List<ProductoDevolucionDto>();
            int contador = 1;

            foreach(int idProducto in listaIdsProductos)
            {
                listaVista.Add(new ProductoDevolucionDto()
                {
                    Nombre = contador + " - " + productoNegocio.ObtenerNombreProductoPorId(idProducto),
                    IdProducto = idProducto
                });
                contador++;
            }

            return listaVista;
        }

        private void btnGenerarDevolucion_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbProductos.SelectedValue == null)
                {
                    MessageBox.Show("Llene los campos!!");
                }
                else
                {
                    Devolucion devolucion = new Devolucion();
                    devolucion.IdCliente = (int)cbClientes.SelectedValue;
                    devolucion.IdProducto = (int)cbProductos.SelectedValue;
                    devolucion.TipoDeDevolucionSeleccionada = cbMotivo.SelectedValue.ToString();
                    devolucion.ComentariosAdicionales = txtComentarios.Text;
                    devolucionNegocio.Alta(devolucion);
                    MessageBox.Show("La devolucion se ha enviado correctamente.");
                }
                
            }
            catch { }
        }

        private void cbClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarComboCompras();          
        }

        private void cbCompras_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarComboProductos();
        }

        private void cbProductos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarTxt();
        }

    }
}
