namespace TPN2.Presentacion
{
    partial class frmDevoluciones
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
            this.lblBuscarPorCliente = new System.Windows.Forms.Label();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.lblBuscarProducto = new System.Windows.Forms.Label();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.lblMotivoDeLaDevolucion = new System.Windows.Forms.Label();
            this.cbMotivo = new System.Windows.Forms.ComboBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.RichTextBox();
            this.btnGenerarDevolucion = new System.Windows.Forms.Button();
            this.lblValorDelProducto = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.lblBuscarPorCompra = new System.Windows.Forms.Label();
            this.cbCompras = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblBuscarPorCliente
            // 
            this.lblBuscarPorCliente.AutoSize = true;
            this.lblBuscarPorCliente.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorCliente.Location = new System.Drawing.Point(38, 24);
            this.lblBuscarPorCliente.Name = "lblBuscarPorCliente";
            this.lblBuscarPorCliente.Size = new System.Drawing.Size(150, 21);
            this.lblBuscarPorCliente.TabIndex = 2;
            this.lblBuscarPorCliente.Text = "Buscar por cliente:";
            // 
            // cbClientes
            // 
            this.cbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(194, 27);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(176, 21);
            this.cbClientes.TabIndex = 3;
            this.cbClientes.SelectionChangeCommitted += new System.EventHandler(this.cbClientes_SelectionChangeCommitted);
            // 
            // lblBuscarProducto
            // 
            this.lblBuscarProducto.AutoSize = true;
            this.lblBuscarProducto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProducto.Location = new System.Drawing.Point(38, 98);
            this.lblBuscarProducto.Name = "lblBuscarProducto";
            this.lblBuscarProducto.Size = new System.Drawing.Size(139, 21);
            this.lblBuscarProducto.TabIndex = 4;
            this.lblBuscarProducto.Text = "Buscar producto:";
            // 
            // cbProductos
            // 
            this.cbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(194, 98);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(176, 21);
            this.cbProductos.TabIndex = 5;
            this.cbProductos.SelectionChangeCommitted += new System.EventHandler(this.cbProductos_SelectionChangeCommitted);
            // 
            // lblMotivoDeLaDevolucion
            // 
            this.lblMotivoDeLaDevolucion.AutoSize = true;
            this.lblMotivoDeLaDevolucion.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoDeLaDevolucion.Location = new System.Drawing.Point(38, 174);
            this.lblMotivoDeLaDevolucion.Name = "lblMotivoDeLaDevolucion";
            this.lblMotivoDeLaDevolucion.Size = new System.Drawing.Size(198, 21);
            this.lblMotivoDeLaDevolucion.TabIndex = 6;
            this.lblMotivoDeLaDevolucion.Text = "Motivo de la devolucion:";
            // 
            // cbMotivo
            // 
            this.cbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotivo.FormattingEnabled = true;
            this.cbMotivo.Location = new System.Drawing.Point(242, 174);
            this.cbMotivo.Name = "cbMotivo";
            this.cbMotivo.Size = new System.Drawing.Size(176, 21);
            this.cbMotivo.TabIndex = 7;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarios.Location = new System.Drawing.Point(143, 219);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(171, 21);
            this.lblComentarios.TabIndex = 8;
            this.lblComentarios.Text = "Dejar un comentario:";
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(12, 259);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(428, 45);
            this.txtComentarios.TabIndex = 9;
            this.txtComentarios.Text = "";
            // 
            // btnGenerarDevolucion
            // 
            this.btnGenerarDevolucion.Location = new System.Drawing.Point(168, 337);
            this.btnGenerarDevolucion.Name = "btnGenerarDevolucion";
            this.btnGenerarDevolucion.Size = new System.Drawing.Size(114, 23);
            this.btnGenerarDevolucion.TabIndex = 10;
            this.btnGenerarDevolucion.Text = "Generar devolucion!";
            this.btnGenerarDevolucion.UseVisualStyleBackColor = true;
            this.btnGenerarDevolucion.Click += new System.EventHandler(this.btnGenerarDevolucion_Click);
            // 
            // lblValorDelProducto
            // 
            this.lblValorDelProducto.AutoSize = true;
            this.lblValorDelProducto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDelProducto.Location = new System.Drawing.Point(38, 134);
            this.lblValorDelProducto.Name = "lblValorDelProducto";
            this.lblValorDelProducto.Size = new System.Drawing.Size(157, 21);
            this.lblValorDelProducto.TabIndex = 11;
            this.lblValorDelProducto.Text = "Valor del producto:";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(201, 134);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.ReadOnly = true;
            this.txtPrecioProducto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProducto.TabIndex = 12;
            // 
            // lblBuscarPorCompra
            // 
            this.lblBuscarPorCompra.AutoSize = true;
            this.lblBuscarPorCompra.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPorCompra.Location = new System.Drawing.Point(38, 62);
            this.lblBuscarPorCompra.Name = "lblBuscarPorCompra";
            this.lblBuscarPorCompra.Size = new System.Drawing.Size(158, 21);
            this.lblBuscarPorCompra.TabIndex = 13;
            this.lblBuscarPorCompra.Text = "Buscar por compra:";
            // 
            // cbCompras
            // 
            this.cbCompras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompras.FormattingEnabled = true;
            this.cbCompras.Location = new System.Drawing.Point(194, 65);
            this.cbCompras.Name = "cbCompras";
            this.cbCompras.Size = new System.Drawing.Size(176, 21);
            this.cbCompras.TabIndex = 14;
            this.cbCompras.SelectionChangeCommitted += new System.EventHandler(this.cbCompras_SelectionChangeCommitted);
            // 
            // frmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 372);
            this.Controls.Add(this.cbCompras);
            this.Controls.Add(this.lblBuscarPorCompra);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.lblValorDelProducto);
            this.Controls.Add(this.btnGenerarDevolucion);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.cbMotivo);
            this.Controls.Add(this.lblMotivoDeLaDevolucion);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.lblBuscarProducto);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.lblBuscarPorCliente);
            this.Name = "frmDevoluciones";
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.frmDevoluciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarPorCliente;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label lblBuscarProducto;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label lblMotivoDeLaDevolucion;
        private System.Windows.Forms.ComboBox cbMotivo;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.RichTextBox txtComentarios;
        private System.Windows.Forms.Button btnGenerarDevolucion;
        private System.Windows.Forms.Label lblValorDelProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label lblBuscarPorCompra;
        private System.Windows.Forms.ComboBox cbCompras;
    }
}