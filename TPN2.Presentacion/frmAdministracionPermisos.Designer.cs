namespace TPN2.Presentacion
{
    partial class frmAdministracionPermisos
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
            this.tvPerfiles = new System.Windows.Forms.TreeView();
            this.cbAdministracion = new System.Windows.Forms.ComboBox();
            this.rbPerfil = new System.Windows.Forms.RadioButton();
            this.rbPuntosDeMenu = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvPerfiles = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // tvPerfiles
            // 
            this.tvPerfiles.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tvPerfiles.Location = new System.Drawing.Point(445, 12);
            this.tvPerfiles.Name = "tvPerfiles";
            this.tvPerfiles.Size = new System.Drawing.Size(260, 332);
            this.tvPerfiles.TabIndex = 0;
            // 
            // cbAdministracion
            // 
            this.cbAdministracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdministracion.FormattingEnabled = true;
            this.cbAdministracion.Location = new System.Drawing.Point(63, 305);
            this.cbAdministracion.Name = "cbAdministracion";
            this.cbAdministracion.Size = new System.Drawing.Size(291, 21);
            this.cbAdministracion.TabIndex = 1;
            // 
            // rbPerfil
            // 
            this.rbPerfil.AutoSize = true;
            this.rbPerfil.Checked = true;
            this.rbPerfil.Location = new System.Drawing.Point(63, 282);
            this.rbPerfil.Name = "rbPerfil";
            this.rbPerfil.Size = new System.Drawing.Size(48, 17);
            this.rbPerfil.TabIndex = 2;
            this.rbPerfil.TabStop = true;
            this.rbPerfil.Text = "Perfil";
            this.rbPerfil.UseVisualStyleBackColor = true;
            this.rbPerfil.CheckedChanged += new System.EventHandler(this.rbPerfil_CheckedChanged);
            // 
            // rbPuntosDeMenu
            // 
            this.rbPuntosDeMenu.AutoSize = true;
            this.rbPuntosDeMenu.Location = new System.Drawing.Point(257, 282);
            this.rbPuntosDeMenu.Name = "rbPuntosDeMenu";
            this.rbPuntosDeMenu.Size = new System.Drawing.Size(97, 17);
            this.rbPuntosDeMenu.TabIndex = 3;
            this.rbPuntosDeMenu.Text = "Punto de menu";
            this.rbPuntosDeMenu.UseVisualStyleBackColor = true;
            this.rbPuntosDeMenu.CheckedChanged += new System.EventHandler(this.rbPuntosDeMenu_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(136, 348);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar permiso al perfil";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvPerfiles
            // 
            this.dgvPerfiles.AllowUserToAddRows = false;
            this.dgvPerfiles.AllowUserToDeleteRows = false;
            this.dgvPerfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerfiles.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfiles.Location = new System.Drawing.Point(12, 12);
            this.dgvPerfiles.MultiSelect = false;
            this.dgvPerfiles.Name = "dgvPerfiles";
            this.dgvPerfiles.ReadOnly = true;
            this.dgvPerfiles.RowHeadersVisible = false;
            this.dgvPerfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerfiles.Size = new System.Drawing.Size(386, 214);
            this.dgvPerfiles.TabIndex = 8;
            this.dgvPerfiles.SelectionChanged += new System.EventHandler(this.dgvPerfiles_SelectionChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(63, 232);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(291, 26);
            this.btnBorrar.TabIndex = 9;
            this.btnBorrar.Text = "Borrar permisos del perfil seleccionado";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmAdministracionPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 383);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvPerfiles);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rbPuntosDeMenu);
            this.Controls.Add(this.rbPerfil);
            this.Controls.Add(this.cbAdministracion);
            this.Controls.Add(this.tvPerfiles);
            this.Name = "frmAdministracionPermisos";
            this.Text = "Administracion de Permisos";
            this.Load += new System.EventHandler(this.frmAdministracionPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvPerfiles;
        private System.Windows.Forms.ComboBox cbAdministracion;
        private System.Windows.Forms.RadioButton rbPerfil;
        private System.Windows.Forms.RadioButton rbPuntosDeMenu;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvPerfiles;
        private System.Windows.Forms.Button btnBorrar;
    }
}