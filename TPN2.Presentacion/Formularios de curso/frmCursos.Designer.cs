namespace TPN2.Presentacion
{
    partial class frmCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrillaCursos = new System.Windows.Forms.DataGridView();
            this.lblAltaDeCurso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaDeInicio = new System.Windows.Forms.DateTimePicker();
            this.FechaDeFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.btnAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaCursos
            // 
            this.GrillaCursos.AllowUserToAddRows = false;
            this.GrillaCursos.AllowUserToDeleteRows = false;
            this.GrillaCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaCursos.Location = new System.Drawing.Point(0, 3);
            this.GrillaCursos.Name = "GrillaCursos";
            this.GrillaCursos.ReadOnly = true;
            this.GrillaCursos.RowHeadersVisible = false;
            this.GrillaCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaCursos.Size = new System.Drawing.Size(517, 193);
            this.GrillaCursos.TabIndex = 0;
            // 
            // lblAltaDeCurso
            // 
            this.lblAltaDeCurso.AutoSize = true;
            this.lblAltaDeCurso.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaDeCurso.Location = new System.Drawing.Point(176, 220);
            this.lblAltaDeCurso.Name = "lblAltaDeCurso";
            this.lblAltaDeCurso.Size = new System.Drawing.Size(164, 22);
            this.lblAltaDeCurso.TabIndex = 1;
            this.lblAltaDeCurso.Text = "Alta de Curso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(104, 264);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(201, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha de Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de Finalizacion:";
            // 
            // FechaDeInicio
            // 
            this.FechaDeInicio.Location = new System.Drawing.Point(121, 301);
            this.FechaDeInicio.Name = "FechaDeInicio";
            this.FechaDeInicio.Size = new System.Drawing.Size(200, 20);
            this.FechaDeInicio.TabIndex = 8;
            // 
            // FechaDeFinalizacion
            // 
            this.FechaDeFinalizacion.Location = new System.Drawing.Point(151, 331);
            this.FechaDeFinalizacion.Name = "FechaDeFinalizacion";
            this.FechaDeFinalizacion.Size = new System.Drawing.Size(200, 20);
            this.FechaDeFinalizacion.TabIndex = 9;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(395, 284);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 10;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 373);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.FechaDeFinalizacion);
            this.Controls.Add(this.FechaDeInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAltaDeCurso);
            this.Controls.Add(this.GrillaCursos);
            this.Name = "frmCursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.frmCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaCursos;
        private System.Windows.Forms.Label lblAltaDeCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechaDeInicio;
        private System.Windows.Forms.DateTimePicker FechaDeFinalizacion;
        private System.Windows.Forms.Button btnAlta;
    }
}