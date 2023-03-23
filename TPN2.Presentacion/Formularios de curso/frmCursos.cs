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
    public partial class frmCursos : Form
    {
        Curso nuevoCurso;
        BLLCurso cursoNegocio;

        public frmCursos()
        {
            InitializeComponent();
        }

        private void frmCursos_Load(object sender, EventArgs e)
        {
            nuevoCurso = new Curso();
            cursoNegocio = new BLLCurso();
            ActualizarGrilla();
            
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtDescripcion.Text == "")
                {
                    MessageBox.Show("Complete el campo de descripcion");
                }
                else
                {
                    
                    nuevoCurso.Descripcion = txtDescripcion.Text;
                    nuevoCurso.FechaDeInicio = FechaDeInicio.Value;
                    nuevoCurso.FechaDeFinalizacion = FechaDeFinalizacion.Value;
                    if (DateTime.Compare(nuevoCurso.FechaDeFinalizacion, nuevoCurso.FechaDeInicio) > 0)
                    {
                        cursoNegocio.Alta(nuevoCurso);
                        MessageBox.Show("Se ha dado de alta el curso exitosamente!");
                        ActualizarGrilla();
                    }  
                    else
                    {
                        MessageBox.Show("Elija una fecha logica por favor");
                    }
                    
                }
                
            }
            catch { }
            
        }
        private void ActualizarGrilla()
        {
            GrillaCursos.DataSource = cursoNegocio.TraerTodos();
            GrillaCursos.Columns[3].Visible = false;
        }
    }
}
