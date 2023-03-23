namespace TPN2.Presentacion
{
    partial class frmInscripcionCurso
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
            this.btnAsignar = new System.Windows.Forms.Button();
            this.lblAlumnoAInscribir = new System.Windows.Forms.Label();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.lblCursoAElegir = new System.Windows.Forms.Label();
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.dgvAlumnosPorCurso = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCursos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosPorCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(32, 256);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(159, 23);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar Cliente a Curso ->";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // lblAlumnoAInscribir
            // 
            this.lblAlumnoAInscribir.AutoSize = true;
            this.lblAlumnoAInscribir.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnoAInscribir.Location = new System.Drawing.Point(27, 25);
            this.lblAlumnoAInscribir.Name = "lblAlumnoAInscribir";
            this.lblAlumnoAInscribir.Size = new System.Drawing.Size(177, 25);
            this.lblAlumnoAInscribir.TabIndex = 3;
            this.lblAlumnoAInscribir.Text = "Cliente a Inscribir:";
            // 
            // cbClientes
            // 
            this.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(53, 71);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(121, 21);
            this.cbClientes.TabIndex = 4;
            // 
            // lblCursoAElegir
            // 
            this.lblCursoAElegir.AutoSize = true;
            this.lblCursoAElegir.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursoAElegir.Location = new System.Drawing.Point(27, 141);
            this.lblCursoAElegir.Name = "lblCursoAElegir";
            this.lblCursoAElegir.Size = new System.Drawing.Size(191, 25);
            this.lblCursoAElegir.TabIndex = 5;
            this.lblCursoAElegir.Text = "Cursos Disponibles:";
            // 
            // cbCursos
            // 
            this.cbCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCursos.FormattingEnabled = true;
            this.cbCursos.Location = new System.Drawing.Point(53, 187);
            this.cbCursos.Name = "cbCursos";
            this.cbCursos.Size = new System.Drawing.Size(121, 21);
            this.cbCursos.TabIndex = 6;
            this.cbCursos.SelectionChangeCommitted += new System.EventHandler(this.cbCursos_SelectionChangeCommitted);
            // 
            // dgvAlumnosPorCurso
            // 
            this.dgvAlumnosPorCurso.AllowUserToAddRows = false;
            this.dgvAlumnosPorCurso.AllowUserToDeleteRows = false;
            this.dgvAlumnosPorCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnosPorCurso.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvAlumnosPorCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnosPorCurso.Location = new System.Drawing.Point(322, 65);
            this.dgvAlumnosPorCurso.MultiSelect = false;
            this.dgvAlumnosPorCurso.Name = "dgvAlumnosPorCurso";
            this.dgvAlumnosPorCurso.ReadOnly = true;
            this.dgvAlumnosPorCurso.RowHeadersVisible = false;
            this.dgvAlumnosPorCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnosPorCurso.Size = new System.Drawing.Size(386, 214);
            this.dgvAlumnosPorCurso.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(254, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 326);
            this.button1.TabIndex = 16;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursos.Location = new System.Drawing.Point(403, 12);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(236, 21);
            this.lblCursos.TabIndex = 17;
            this.lblCursos.Text = "Listado de alumnos del curso:";
            // 
            // frmInscripcionCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 355);
            this.Controls.Add(this.lblCursos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAlumnosPorCurso);
            this.Controls.Add(this.cbCursos);
            this.Controls.Add(this.lblCursoAElegir);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.lblAlumnoAInscribir);
            this.Controls.Add(this.btnAsignar);
            this.Name = "frmInscripcionCurso";
            this.Text = "Inscripcion a Curso";
            this.Load += new System.EventHandler(this.frmInscripcionCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnosPorCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label lblAlumnoAInscribir;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label lblCursoAElegir;
        private System.Windows.Forms.ComboBox cbCursos;
        private System.Windows.Forms.DataGridView dgvAlumnosPorCurso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCursos;
    }
}