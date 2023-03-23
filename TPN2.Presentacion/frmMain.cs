using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPN2.Entidades;
using TPN2.LogicaDeNegocio;
using System.Configuration;

namespace TPN2.Presentacion
{
    public partial class frmMain : Form
    {

        Usuario usuarioLogueado;
        BLLPermiso bLLPermiso;
        string sourceDirName = Environment.CurrentDirectory + ConfigurationManager.AppSettings["DirectorioXML"].ToString();
        string destDirName = Environment.CurrentDirectory +  ConfigurationManager.AppSettings["DirectorioBackup"].ToString();


        public frmMain(Usuario _usuarioLogueado)
        {
            InitializeComponent();
            bLLPermiso = new BLLPermiso();
            usuarioLogueado = _usuarioLogueado;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(!(usuarioLogueado is Administrador))
            {
                
                CargarToolStripSegunPermisos();
                // Recorrer la lista y habilitar los puntos de menu
            }
        }

        public void CargarToolStripSegunPermisos()
        {
            int idPerfilDelUsuario = ((Cliente)usuarioLogueado).PerfilAsignado;
            List<string> permisosDelUsuario = bLLPermiso.TrearPermisosPorPerfil(idPerfilDelUsuario);
            List<string> listaToolStrip = GetAllMenuStripItems(menuStrip);
           foreach(ToolStripMenuItem c in menuStrip.Items)
            {
                
                foreach(ToolStripMenuItem j in c.DropDownItems)
                {
                    if(j is ToolStripMenuItem)
                    {
                        if (!permisosDelUsuario.Contains(j.Name.ToString()))
                        {
                            j.Visible = false;
                        }
                    }
                }

            }
            
            
           
        }

        private List<string> GetAllMenuStripItems(MenuStrip menuStrip)
        {
           
            List<string> items = new List<string>();
            foreach (ToolStripMenuItem c in menuStrip.Items)
            {
                if (c.DropDownItems.Count == 0)
                    items.Add(c.Name);
                else
                {
                    foreach (ToolStripMenuItem j in c.DropDownItems)
                    {

                        if (j is ToolStripMenuItem)
                            items.Add(j.Name);
                    }
                }
            }
            return items;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aBMClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmClientesAux = new frmClientes();
            frmClientesAux.MdiParent = this;
            frmClientesAux.Show();
        }


        private void detalleDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetalleCompra frmDetalleCompraAux = new frmDetalleCompra();
            frmDetalleCompraAux.MdiParent = this;
            frmDetalleCompraAux.Show();
        }

        private void historialDeLoginsEnXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial frmXMLaux = new frmHistorial();
            frmXMLaux.MdiParent = this;
            frmXMLaux.Show();
        }

       

        private void reseteoDeClavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReseteoDeClaves frmAux = new frmReseteoDeClaves();
            frmAux.MdiParent = this;
            frmAux.Show();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerfiles frmaux = new frmPerfiles();
            frmaux.MdiParent = this;
            frmaux.Show();
        }    

        private void puntosDeMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> listaToolStripMenuItems = GetAllMenuStripItems(menuStrip);
            frmPuntosDeMenu frmaux = new frmPuntosDeMenu(listaToolStripMenuItems);
            frmaux.MdiParent = this;
            frmaux.Show();
        }

        private void realizarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();
            
            
            //Creo la carpeta de Backup si no existe
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            string directorio = Path.Combine(destDirName, DateTime.Now.ToString("yyyyMMdd_HHmmss"));
            //Creo la carpeta de la fecha de backup si no existe
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(directorio, file.Name);
                file.CopyTo(temppath, false);
            }
            

            MessageBox.Show("Backup realizado exitosamente");
        }

        private void restaurarDesdeBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmRestaurarDesdeBackup frmaux = new frmRestaurarDesdeBackup();
            frmaux.MdiParent = this;
            frmaux.Show();
        }

        private void historialDeLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorial frmAux = new frmHistorial();
            frmAux.MdiParent = this;
            frmAux.Show();
        }

        private void aBMProductosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmProductos frmProductosAux = new frmProductos();
            frmProductosAux.MdiParent = this;
            frmProductosAux.Show();
        }

        private void comprarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCompra frmCompraAux = new frmCompra();
            frmCompraAux.MdiParent = this;
            frmCompraAux.Show();
        }

        private void altaDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCursos aux = new frmCursos();
            aux.MdiParent = this;
            aux.Show();
        }

        private void inscripcionACursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInscripcionCurso frmAux = new frmInscripcionCurso();
            frmAux.MdiParent = this;
            frmAux.Show();
        }

        private void administracionDePermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministracionPermisos frmAux = new frmAdministracionPermisos();
            frmAux.MdiParent = this;
            frmAux.Show();
        }

        private void desencriptacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDesencriptacion frmaux = new frmDesencriptacion();
            frmaux.MdiParent = this;
            frmaux.Show();
        }


        private void gastosCorrientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmGastoCorriente frmAux = new frmGastoCorriente();
            frmAux.MdiParent = this;
            frmAux.Show();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevoluciones frmAux = new frmDevoluciones();
            frmAux.MdiParent = this;
            frmAux.Show();
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadoFinanciero frmAux = new frmEstadoFinanciero();
            frmAux.MdiParent = this;
            frmAux.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin aux = new frmLogin();
            aux.ShowDialog();

        }
    }
}
