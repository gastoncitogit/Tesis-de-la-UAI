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
    public partial class frmGastoCorriente : Form
    {
        GastoCorriente gastoCorrienteObj;
        BLLGastoCorriente gastoCorrienteNegocio;
        
        public frmGastoCorriente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CargarCombo()
        {
            cbTipoDeGasto.DataSource = Enum.GetValues(typeof(GastoCorriente.TipoDeGasto));
            
        }
        private void ActualizarGrilla()
        {
            dgvGastos.DataSource = gastoCorrienteNegocio.TraerTodos();
            dgvGastos.Columns[3].Visible = false;
        }

        private void btnAgregarGastoCorriente_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtDescripcion.Text != "" && txtImporte.Text != "")
                {
                    gastoCorrienteObj.Descripcion = txtDescripcion.Text;
                    gastoCorrienteObj.Importe = Convert.ToInt32(txtImporte.Text);

                    gastoCorrienteObj.TipoDeGastoSeleccionado = cbTipoDeGasto.SelectedValue.ToString();
                    gastoCorrienteNegocio.Alta(gastoCorrienteObj);
                    MessageBox.Show("Gasto corriente agregado correctamente!");
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("Complete los campos por favor");
                }
                
            }
            catch { }
            
            
            
        }

        private void frmGastoCorriente_Load(object sender, EventArgs e)
        {
            
            gastoCorrienteObj = new GastoCorriente();
            gastoCorrienteNegocio = new BLLGastoCorriente();
            CargarCombo();
            ActualizarGrilla();
        }
    }
}
