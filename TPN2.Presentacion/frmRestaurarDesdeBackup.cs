using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPN2.Presentacion
{
    public partial class frmRestaurarDesdeBackup : Form
    {
        string backupDirectory = Environment.CurrentDirectory + ConfigurationManager.AppSettings["DirectorioBackup"].ToString();
        string xmlDirectory = Environment.CurrentDirectory + ConfigurationManager.AppSettings["DirectorioXML"].ToString();
        public frmRestaurarDesdeBackup()
        {
            InitializeComponent();
            
        }

        
        public List<string> ObtenerBackups()
        {
            List<string> backups = new List<string>();

            DirectoryInfo di = new DirectoryInfo(backupDirectory);
            foreach (DirectoryInfo fi in di.GetDirectories())
            {
                backups.Add(fi.Name);
            }

            return backups;
        }

        public void CargarComboBackup()
        {

            cbBackup.DataSource = ObtenerBackups();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbBackup.Items.Count > 0)
                {
                    string mensaje = "Va a restaurar el backup seleccionado, esta seguro?";
                    var seleccion = MessageBox.Show(mensaje, "Restauracion de backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (seleccion == DialogResult.Yes)
                    {
                        string backupSeleccionado = cbBackup.SelectedValue.ToString();
                        RestaurarDesdeBackup(backupSeleccionado);
                        MessageBox.Show("Se ha restaurado el backup exitosamente");
                    }
                }
                else
                {
                    MessageBox.Show("No hay backups para elegir");
                }
            }
            catch { }
            
            
        }
        public void RestaurarDesdeBackup(string pBackup)
        {
            DirectoryInfo di = new DirectoryInfo(backupDirectory + "\\" + pBackup);
            foreach(FileInfo file in di.GetFiles())
            {
                file.CopyTo(Path.Combine(xmlDirectory,file.Name),true);
            }
        }
        private void frmRestaurarDesdeBackup_Load(object sender, EventArgs e)
        {
            if (DirectoryExists())
            {
                CargarComboBackup();
                cbBackup_SelectionChangeCommitted(sender, e);
            }
            else
            {
                
                MessageBox.Show("No se encontraron backups!");
                

            }
            

        }
        public bool DirectoryExists()
        {
            return Directory.Exists(backupDirectory);
        }
        

        private void cbBackup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbBackup.Items.Count > 0)
            {
                string fechaDesglosada = cbBackup.SelectedValue.ToString();
                fechaDesglosada = fechaDesglosada.Substring(0, fechaDesglosada.IndexOf('_'));
                var parsedDate = DateTime.ParseExact(fechaDesglosada, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                var formattedDate = parsedDate.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                lblFecha.Text = formattedDate.ToString();
            }
            else
            {
                MessageBox.Show("Primero realice un backup para despues restaurar!");
            }
                
            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
