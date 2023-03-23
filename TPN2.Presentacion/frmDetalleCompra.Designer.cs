namespace TPN2.Presentacion
{
    partial class frmDetalleCompra
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
            this.grillaDetalleCompra = new System.Windows.Forms.DataGridView();
            this.grillaClientes = new System.Windows.Forms.DataGridView();
            this.lblClientesCompradores = new System.Windows.Forms.Label();
            this.lblHistorialDeCompras = new System.Windows.Forms.Label();
            this.lblTicket = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDetalleCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaDetalleCompra
            // 
            this.grillaDetalleCompra.AllowUserToAddRows = false;
            this.grillaDetalleCompra.AllowUserToDeleteRows = false;
            this.grillaDetalleCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDetalleCompra.Location = new System.Drawing.Point(25, 237);
            this.grillaDetalleCompra.Name = "grillaDetalleCompra";
            this.grillaDetalleCompra.ReadOnly = true;
            this.grillaDetalleCompra.RowHeadersVisible = false;
            this.grillaDetalleCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaDetalleCompra.Size = new System.Drawing.Size(366, 202);
            this.grillaDetalleCompra.TabIndex = 1;
            this.grillaDetalleCompra.SelectionChanged += new System.EventHandler(this.grillaDetalleCompra_SelectionChanged);
            // 
            // grillaClientes
            // 
            this.grillaClientes.AllowUserToAddRows = false;
            this.grillaClientes.AllowUserToDeleteRows = false;
            this.grillaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaClientes.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaClientes.Location = new System.Drawing.Point(25, 55);
            this.grillaClientes.MultiSelect = false;
            this.grillaClientes.Name = "grillaClientes";
            this.grillaClientes.ReadOnly = true;
            this.grillaClientes.RowHeadersVisible = false;
            this.grillaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaClientes.Size = new System.Drawing.Size(366, 105);
            this.grillaClientes.TabIndex = 9;
            this.grillaClientes.SelectionChanged += new System.EventHandler(this.grillaClientes_SelectionChanged);
            // 
            // lblClientesCompradores
            // 
            this.lblClientesCompradores.AutoSize = true;
            this.lblClientesCompradores.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesCompradores.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblClientesCompradores.Location = new System.Drawing.Point(125, 20);
            this.lblClientesCompradores.Name = "lblClientesCompradores";
            this.lblClientesCompradores.Size = new System.Drawing.Size(182, 21);
            this.lblClientesCompradores.TabIndex = 11;
            this.lblClientesCompradores.Text = "Clientes Compradores:";
            // 
            // lblHistorialDeCompras
            // 
            this.lblHistorialDeCompras.AutoSize = true;
            this.lblHistorialDeCompras.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialDeCompras.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblHistorialDeCompras.Location = new System.Drawing.Point(64, 193);
            this.lblHistorialDeCompras.Name = "lblHistorialDeCompras";
            this.lblHistorialDeCompras.Size = new System.Drawing.Size(264, 21);
            this.lblHistorialDeCompras.TabIndex = 12;
            this.lblHistorialDeCompras.Text = "Facturas del cliente seleccionado:";
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Location = new System.Drawing.Point(456, 83);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(273, 21);
            this.lblTicket.TabIndex = 13;
            this.lblTicket.Text = "Detalle de la Factura seleccionada:";
            // 
            // txtFactura
            // 
            this.txtFactura.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtFactura.Location = new System.Drawing.Point(507, 134);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.ReadOnly = true;
            this.txtFactura.Size = new System.Drawing.Size(150, 210);
            this.txtFactura.TabIndex = 14;
            this.txtFactura.Text = "";
            // 
            // frmDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 451);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.lblHistorialDeCompras);
            this.Controls.Add(this.lblClientesCompradores);
            this.Controls.Add(this.grillaClientes);
            this.Controls.Add(this.grillaDetalleCompra);
            this.Name = "frmDetalleCompra";
            this.Text = "Detalle de compras";
            this.Load += new System.EventHandler(this.frmDetalleCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaDetalleCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grillaDetalleCompra;
        private System.Windows.Forms.DataGridView grillaClientes;
        private System.Windows.Forms.Label lblClientesCompradores;
        private System.Windows.Forms.Label lblHistorialDeCompras;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.RichTextBox txtFactura;
    }
}