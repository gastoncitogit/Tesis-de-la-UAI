namespace TPN2.Presentacion
{
    partial class frmPerfiles
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
            this.GrillaPerfiles = new System.Windows.Forms.DataGridView();
            this.lblPerfiles = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAltaPerfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPerfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaPerfiles
            // 
            this.GrillaPerfiles.AllowUserToAddRows = false;
            this.GrillaPerfiles.AllowUserToDeleteRows = false;
            this.GrillaPerfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaPerfiles.Location = new System.Drawing.Point(12, 63);
            this.GrillaPerfiles.Name = "GrillaPerfiles";
            this.GrillaPerfiles.ReadOnly = true;
            this.GrillaPerfiles.RowHeadersVisible = false;
            this.GrillaPerfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaPerfiles.Size = new System.Drawing.Size(390, 203);
            this.GrillaPerfiles.TabIndex = 0;
            // 
            // lblPerfiles
            // 
            this.lblPerfiles.AutoSize = true;
            this.lblPerfiles.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfiles.Location = new System.Drawing.Point(157, 9);
            this.lblPerfiles.Name = "lblPerfiles";
            this.lblPerfiles.Size = new System.Drawing.Size(90, 28);
            this.lblPerfiles.TabIndex = 1;
            this.lblPerfiles.Text = "Perfiles";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(13, 289);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 21);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 289);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(120, 346);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // btnAltaPerfil
            // 
            this.btnAltaPerfil.Location = new System.Drawing.Point(292, 346);
            this.btnAltaPerfil.Name = "btnAltaPerfil";
            this.btnAltaPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnAltaPerfil.TabIndex = 6;
            this.btnAltaPerfil.Text = "Alta";
            this.btnAltaPerfil.UseVisualStyleBackColor = true;
            this.btnAltaPerfil.Click += new System.EventHandler(this.btnAltaPerfil_Click);
            // 
            // frmPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 397);
            this.Controls.Add(this.btnAltaPerfil);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPerfiles);
            this.Controls.Add(this.GrillaPerfiles);
            this.Name = "frmPerfiles";
            this.Text = "Alta De Perfiles";
            this.Load += new System.EventHandler(this.frmPerfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPerfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaPerfiles;
        private System.Windows.Forms.Label lblPerfiles;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAltaPerfil;
    }
}