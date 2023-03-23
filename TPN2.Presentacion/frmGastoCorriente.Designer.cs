namespace TPN2.Presentacion
{
    partial class frmGastoCorriente
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
            this.lblNuevoGastoCorriente = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.cbTipoDeGasto = new System.Windows.Forms.ComboBox();
            this.dgvGastos = new System.Windows.Forms.DataGridView();
            this.btnAgregarGastoCorriente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevoGastoCorriente
            // 
            this.lblNuevoGastoCorriente.AutoSize = true;
            this.lblNuevoGastoCorriente.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoGastoCorriente.Location = new System.Drawing.Point(100, 9);
            this.lblNuevoGastoCorriente.Name = "lblNuevoGastoCorriente";
            this.lblNuevoGastoCorriente.Size = new System.Drawing.Size(217, 25);
            this.lblNuevoGastoCorriente.TabIndex = 0;
            this.lblNuevoGastoCorriente.Text = "Nuevo gasto corriente";
            this.lblNuevoGastoCorriente.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(12, 71);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(102, 21);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(12, 115);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(75, 21);
            this.lblImporte.TabIndex = 2;
            this.lblImporte.Text = "Importe:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(12, 151);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(47, 21);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(120, 71);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(282, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(93, 115);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(92, 20);
            this.txtImporte.TabIndex = 5;
            // 
            // cbTipoDeGasto
            // 
            this.cbTipoDeGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDeGasto.FormattingEnabled = true;
            this.cbTipoDeGasto.Location = new System.Drawing.Point(84, 151);
            this.cbTipoDeGasto.Name = "cbTipoDeGasto";
            this.cbTipoDeGasto.Size = new System.Drawing.Size(121, 21);
            this.cbTipoDeGasto.TabIndex = 6;
            // 
            // dgvGastos
            // 
            this.dgvGastos.AllowUserToAddRows = false;
            this.dgvGastos.AllowUserToDeleteRows = false;
            this.dgvGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGastos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastos.Location = new System.Drawing.Point(16, 229);
            this.dgvGastos.MultiSelect = false;
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.ReadOnly = true;
            this.dgvGastos.RowHeadersVisible = false;
            this.dgvGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGastos.Size = new System.Drawing.Size(386, 214);
            this.dgvGastos.TabIndex = 9;
            // 
            // btnAgregarGastoCorriente
            // 
            this.btnAgregarGastoCorriente.Location = new System.Drawing.Point(169, 190);
            this.btnAgregarGastoCorriente.Name = "btnAgregarGastoCorriente";
            this.btnAgregarGastoCorriente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarGastoCorriente.TabIndex = 10;
            this.btnAgregarGastoCorriente.Text = "Agregar";
            this.btnAgregarGastoCorriente.UseVisualStyleBackColor = true;
            this.btnAgregarGastoCorriente.Click += new System.EventHandler(this.btnAgregarGastoCorriente_Click);
            // 
            // frmGastoCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 464);
            this.Controls.Add(this.btnAgregarGastoCorriente);
            this.Controls.Add(this.dgvGastos);
            this.Controls.Add(this.cbTipoDeGasto);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNuevoGastoCorriente);
            this.Name = "frmGastoCorriente";
            this.Text = "Egreso por gasto corriente";
            this.Load += new System.EventHandler(this.frmGastoCorriente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoGastoCorriente;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.ComboBox cbTipoDeGasto;
        private System.Windows.Forms.DataGridView dgvGastos;
        private System.Windows.Forms.Button btnAgregarGastoCorriente;
    }
}