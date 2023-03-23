namespace TPN2.Presentacion
{
    partial class frmPuntosDeMenu
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
            this.cbMenuStrip = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.GrillaPuntosDeMenu = new System.Windows.Forms.DataGridView();
            this.lblDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPuntosDeMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMenuStrip
            // 
            this.cbMenuStrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenuStrip.FormattingEnabled = true;
            this.cbMenuStrip.Location = new System.Drawing.Point(43, 255);
            this.cbMenuStrip.Name = "cbMenuStrip";
            this.cbMenuStrip.Size = new System.Drawing.Size(306, 21);
            this.cbMenuStrip.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(132, 324);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(274, 324);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 2;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // GrillaPuntosDeMenu
            // 
            this.GrillaPuntosDeMenu.AllowUserToAddRows = false;
            this.GrillaPuntosDeMenu.AllowUserToDeleteRows = false;
            this.GrillaPuntosDeMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaPuntosDeMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaPuntosDeMenu.Location = new System.Drawing.Point(12, 26);
            this.GrillaPuntosDeMenu.Name = "GrillaPuntosDeMenu";
            this.GrillaPuntosDeMenu.ReadOnly = true;
            this.GrillaPuntosDeMenu.RowHeadersVisible = false;
            this.GrillaPuntosDeMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaPuntosDeMenu.Size = new System.Drawing.Size(377, 202);
            this.GrillaPuntosDeMenu.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(39, 324);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 19);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción";
            // 
            // frmPuntosDeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 366);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.GrillaPuntosDeMenu);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cbMenuStrip);
            this.Name = "frmPuntosDeMenu";
            this.Text = "Puntos De Menu";
            this.Load += new System.EventHandler(this.frmPuntosDeMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPuntosDeMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMenuStrip;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.DataGridView GrillaPuntosDeMenu;
        private System.Windows.Forms.Label lblDescripcion;
    }
}