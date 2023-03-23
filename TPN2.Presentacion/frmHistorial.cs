using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using TPN2.Entidades;
using TPN2.LogicaDeNegocio;


namespace TPN2.Presentacion
{
    public partial class frmHistorial : Form
    {
        BLLUserRecord bllUserRecord;
        public frmHistorial()
        {
            InitializeComponent();
            bllUserRecord = new BLLUserRecord();    
            
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarGrilla(bllUserRecord.TraerDatos());
        }

        public void CargarCombo()
        {           
            cbFecha.DataSource = ObtenerFechasFiltradas();
            cbFecha.SelectedIndex = -1;
        }

        public void CargarGrilla(List<UserRecord> listaDeLogins)
        {
            dgvHistorial.DataSource = listaDeLogins;
            dgvHistorial.Columns[2].Visible = false;
            dgvHistorial.AlternatingRowsDefaultCellStyle.BackColor = Color.GreenYellow;
        }

        public List<string> ObtenerFechasFiltradas()
        {
            List<UserRecord> listaClientesLogueados = bllUserRecord.TraerDatos();
            List<string> listaFechas = (from lista in listaClientesLogueados
                                        select lista.FechaDeLogueo.Date.ToShortDateString()).Distinct().ToList();

            return listaFechas;
        }
        

        private void cbFecha_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<UserRecord> listaClientesLogueados = bllUserRecord.TraerDatos();
            DateTime FechaSeleccionada = Convert.ToDateTime(cbFecha.SelectedItem);
            List<UserRecord> listaFiltada = listaClientesLogueados.FindAll(x => x.FechaDeLogueo > FechaSeleccionada && x.FechaDeLogueo < FechaSeleccionada.AddDays(1));

            CargarGrilla(listaFiltada);
        }

        private void cbFecha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
