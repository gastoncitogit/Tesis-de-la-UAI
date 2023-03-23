using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPN2.Presentacion
{
    public partial class UC_Fecha : UserControl
    {
        public UC_Fecha()
        {
            InitializeComponent();
        }

        private void MostrarFecha()
        {
            lblMostrarFecha.Text = DateTime.Now.ToString("t");
        }

        private void UC_Fecha_Load(object sender, EventArgs e)
        {
            MostrarFecha();
        }
    }
}
