namespace TPN2.Presentacion
{
    partial class frmEstadoFinanciero
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
            this.lblTotalDeClientes = new System.Windows.Forms.Label();
            this.lblTotalDeProductos = new System.Windows.Forms.Label();
            this.dgvEgresos = new System.Windows.Forms.DataGridView();
            this.lblFacturacionProductos = new System.Windows.Forms.Label();
            this.btnVerDevoluciones = new System.Windows.Forms.Button();
            this.btnVerGastosCorrientes = new System.Windows.Forms.Button();
            this.lblEgresosPorDevoluciones = new System.Windows.Forms.Label();
            this.lblEgresosPorGastosCorrientes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalDeClientes
            // 
            this.lblTotalDeClientes.AutoSize = true;
            this.lblTotalDeClientes.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeClientes.Location = new System.Drawing.Point(32, 45);
            this.lblTotalDeClientes.Name = "lblTotalDeClientes";
            this.lblTotalDeClientes.Size = new System.Drawing.Size(138, 21);
            this.lblTotalDeClientes.TabIndex = 2;
            this.lblTotalDeClientes.Text = "Total de clientes:";
            // 
            // lblTotalDeProductos
            // 
            this.lblTotalDeProductos.AutoSize = true;
            this.lblTotalDeProductos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeProductos.Location = new System.Drawing.Point(32, 9);
            this.lblTotalDeProductos.Name = "lblTotalDeProductos";
            this.lblTotalDeProductos.Size = new System.Drawing.Size(158, 21);
            this.lblTotalDeProductos.TabIndex = 3;
            this.lblTotalDeProductos.Text = "Total de productos:";
            // 
            // dgvEgresos
            // 
            this.dgvEgresos.AllowUserToAddRows = false;
            this.dgvEgresos.AllowUserToDeleteRows = false;
            this.dgvEgresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEgresos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEgresos.Location = new System.Drawing.Point(12, 224);
            this.dgvEgresos.MultiSelect = false;
            this.dgvEgresos.Name = "dgvEgresos";
            this.dgvEgresos.ReadOnly = true;
            this.dgvEgresos.RowHeadersVisible = false;
            this.dgvEgresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEgresos.Size = new System.Drawing.Size(776, 214);
            this.dgvEgresos.TabIndex = 9;
            // 
            // lblFacturacionProductos
            // 
            this.lblFacturacionProductos.AutoSize = true;
            this.lblFacturacionProductos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturacionProductos.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblFacturacionProductos.Location = new System.Drawing.Point(32, 90);
            this.lblFacturacionProductos.Name = "lblFacturacionProductos";
            this.lblFacturacionProductos.Size = new System.Drawing.Size(264, 21);
            this.lblFacturacionProductos.TabIndex = 10;
            this.lblFacturacionProductos.Text = "Ingresos por productos vendidos:";
            // 
            // btnVerDevoluciones
            // 
            this.btnVerDevoluciones.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDevoluciones.Location = new System.Drawing.Point(128, 169);
            this.btnVerDevoluciones.Name = "btnVerDevoluciones";
            this.btnVerDevoluciones.Size = new System.Drawing.Size(168, 38);
            this.btnVerDevoluciones.TabIndex = 11;
            this.btnVerDevoluciones.Text = "Ver devoluciones";
            this.btnVerDevoluciones.UseVisualStyleBackColor = true;
            this.btnVerDevoluciones.Click += new System.EventHandler(this.btnVerDevoluciones_Click);
            // 
            // btnVerGastosCorrientes
            // 
            this.btnVerGastosCorrientes.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerGastosCorrientes.Location = new System.Drawing.Point(419, 168);
            this.btnVerGastosCorrientes.Name = "btnVerGastosCorrientes";
            this.btnVerGastosCorrientes.Size = new System.Drawing.Size(196, 39);
            this.btnVerGastosCorrientes.TabIndex = 12;
            this.btnVerGastosCorrientes.Text = "Ver Gastos Corrientes";
            this.btnVerGastosCorrientes.UseVisualStyleBackColor = true;
            this.btnVerGastosCorrientes.Click += new System.EventHandler(this.btnVerGastosCorrientes_Click);
            // 
            // lblEgresosPorDevoluciones
            // 
            this.lblEgresosPorDevoluciones.AutoSize = true;
            this.lblEgresosPorDevoluciones.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgresosPorDevoluciones.ForeColor = System.Drawing.Color.Crimson;
            this.lblEgresosPorDevoluciones.Location = new System.Drawing.Point(415, 34);
            this.lblEgresosPorDevoluciones.Name = "lblEgresosPorDevoluciones";
            this.lblEgresosPorDevoluciones.Size = new System.Drawing.Size(207, 21);
            this.lblEgresosPorDevoluciones.TabIndex = 13;
            this.lblEgresosPorDevoluciones.Text = "Egresos por devoluciones:";
            // 
            // lblEgresosPorGastosCorrientes
            // 
            this.lblEgresosPorGastosCorrientes.AutoSize = true;
            this.lblEgresosPorGastosCorrientes.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgresosPorGastosCorrientes.ForeColor = System.Drawing.Color.Crimson;
            this.lblEgresosPorGastosCorrientes.Location = new System.Drawing.Point(415, 79);
            this.lblEgresosPorGastosCorrientes.Name = "lblEgresosPorGastosCorrientes";
            this.lblEgresosPorGastosCorrientes.Size = new System.Drawing.Size(237, 21);
            this.lblEgresosPorGastosCorrientes.TabIndex = 14;
            this.lblEgresosPorGastosCorrientes.Text = "Egresos por gastos corrientes:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(775, 10);
            this.button1.TabIndex = 15;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmEstadoFinanciero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblEgresosPorGastosCorrientes);
            this.Controls.Add(this.lblEgresosPorDevoluciones);
            this.Controls.Add(this.btnVerGastosCorrientes);
            this.Controls.Add(this.btnVerDevoluciones);
            this.Controls.Add(this.lblFacturacionProductos);
            this.Controls.Add(this.dgvEgresos);
            this.Controls.Add(this.lblTotalDeProductos);
            this.Controls.Add(this.lblTotalDeClientes);
            this.Name = "frmEstadoFinanciero";
            this.Text = "Estado Financiero";
            this.Load += new System.EventHandler(this.frmEstadoFinanciero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalDeClientes;
        private System.Windows.Forms.Label lblTotalDeProductos;
        private System.Windows.Forms.DataGridView dgvEgresos;
        private System.Windows.Forms.Label lblFacturacionProductos;
        private System.Windows.Forms.Button btnVerDevoluciones;
        private System.Windows.Forms.Button btnVerGastosCorrientes;
        private System.Windows.Forms.Label lblEgresosPorDevoluciones;
        private System.Windows.Forms.Label lblEgresosPorGastosCorrientes;
        private System.Windows.Forms.Button button1;
    }
}