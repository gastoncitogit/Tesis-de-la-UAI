namespace TPN2.Presentacion
{
    partial class frmCompra
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
            this.GrillaClientesCargados = new System.Windows.Forms.DataGridView();
            this.GrillaCarritoCliente = new System.Windows.Forms.DataGridView();
            this.GrillaProductosCargados = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.btnCambiarCliente = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMontoCalculado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientesCargados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCarritoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProductosCargados)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaClientesCargados
            // 
            this.GrillaClientesCargados.AllowUserToAddRows = false;
            this.GrillaClientesCargados.AllowUserToDeleteRows = false;
            this.GrillaClientesCargados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaClientesCargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaClientesCargados.Location = new System.Drawing.Point(12, 20);
            this.GrillaClientesCargados.Name = "GrillaClientesCargados";
            this.GrillaClientesCargados.ReadOnly = true;
            this.GrillaClientesCargados.RowHeadersVisible = false;
            this.GrillaClientesCargados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaClientesCargados.Size = new System.Drawing.Size(417, 188);
            this.GrillaClientesCargados.TabIndex = 0;
            // 
            // GrillaCarritoCliente
            // 
            this.GrillaCarritoCliente.AllowUserToAddRows = false;
            this.GrillaCarritoCliente.AllowUserToDeleteRows = false;
            this.GrillaCarritoCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaCarritoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaCarritoCliente.Location = new System.Drawing.Point(260, 255);
            this.GrillaCarritoCliente.Name = "GrillaCarritoCliente";
            this.GrillaCarritoCliente.ReadOnly = true;
            this.GrillaCarritoCliente.RowHeadersVisible = false;
            this.GrillaCarritoCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaCarritoCliente.Size = new System.Drawing.Size(477, 186);
            this.GrillaCarritoCliente.TabIndex = 1;
            // 
            // GrillaProductosCargados
            // 
            this.GrillaProductosCargados.AllowUserToAddRows = false;
            this.GrillaProductosCargados.AllowUserToDeleteRows = false;
            this.GrillaProductosCargados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaProductosCargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaProductosCargados.Location = new System.Drawing.Point(568, 20);
            this.GrillaProductosCargados.Name = "GrillaProductosCargados";
            this.GrillaProductosCargados.ReadOnly = true;
            this.GrillaProductosCargados.RowHeadersVisible = false;
            this.GrillaProductosCargados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaProductosCargados.Size = new System.Drawing.Size(396, 188);
            this.GrillaProductosCargados.TabIndex = 2;
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(12, 214);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(169, 35);
            this.btnSeleccionarCliente.TabIndex = 3;
            this.btnSeleccionarCliente.Text = "Seleccionar Cliente";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = true;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // btnCambiarCliente
            // 
            this.btnCambiarCliente.Enabled = false;
            this.btnCambiarCliente.Location = new System.Drawing.Point(260, 214);
            this.btnCambiarCliente.Name = "btnCambiarCliente";
            this.btnCambiarCliente.Size = new System.Drawing.Size(169, 35);
            this.btnCambiarCliente.TabIndex = 4;
            this.btnCambiarCliente.Text = "Cambiar Cliente";
            this.btnCambiarCliente.UseVisualStyleBackColor = true;
            this.btnCambiarCliente.Click += new System.EventHandler(this.btnCambiarCliente_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Enabled = false;
            this.btnAgregarProducto.Location = new System.Drawing.Point(568, 214);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(169, 35);
            this.btnAgregarProducto.TabIndex = 5;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(795, 214);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(169, 35);
            this.btnEliminarProducto.TabIndex = 6;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Enabled = false;
            this.btnComprar.Location = new System.Drawing.Point(435, 173);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(127, 35);
            this.btnComprar.TabIndex = 7;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Monto Total:";
            // 
            // lblMontoCalculado
            // 
            this.lblMontoCalculado.AutoSize = true;
            this.lblMontoCalculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoCalculado.Location = new System.Drawing.Point(518, 76);
            this.lblMontoCalculado.Name = "lblMontoCalculado";
            this.lblMontoCalculado.Size = new System.Drawing.Size(14, 16);
            this.lblMontoCalculado.TabIndex = 9;
            this.lblMontoCalculado.Text = "0";
            // 
            // frmCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(976, 453);
            this.Controls.Add(this.lblMontoCalculado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.btnCambiarCliente);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.GrillaProductosCargados);
            this.Controls.Add(this.GrillaCarritoCliente);
            this.Controls.Add(this.GrillaClientesCargados);
            this.Name = "frmCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Compra";
            this.Load += new System.EventHandler(this.frmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientesCargados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaCarritoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProductosCargados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaClientesCargados;
        private System.Windows.Forms.DataGridView GrillaCarritoCliente;
        private System.Windows.Forms.DataGridView GrillaProductosCargados;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.Button btnCambiarCliente;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMontoCalculado;
    }
}