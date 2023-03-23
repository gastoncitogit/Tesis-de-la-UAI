namespace TPN2.Presentacion
{
    partial class frmModificacionCliente
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
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.lblNuevoApellido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPerfil = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblModificacionCliente = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(12, 42);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(82, 13);
            this.lblNuevoNombre.TabIndex = 0;
            this.lblNuevoNombre.Text = "Nuevo Nombre:";
            // 
            // lblNuevoApellido
            // 
            this.lblNuevoApellido.AutoSize = true;
            this.lblNuevoApellido.Location = new System.Drawing.Point(12, 94);
            this.lblNuevoApellido.Name = "lblNuevoApellido";
            this.lblNuevoApellido.Size = new System.Drawing.Size(82, 13);
            this.lblNuevoApellido.TabIndex = 1;
            this.lblNuevoApellido.Text = "Nuevo Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo Perfil:";
            // 
            // cbPerfil
            // 
            this.cbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.Location = new System.Drawing.Point(91, 122);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(121, 21);
            this.cbPerfil.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(100, 87);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // lblModificacionCliente
            // 
            this.lblModificacionCliente.AutoSize = true;
            this.lblModificacionCliente.Location = new System.Drawing.Point(88, 9);
            this.lblModificacionCliente.Name = "lblModificacionCliente";
            this.lblModificacionCliente.Size = new System.Drawing.Size(105, 13);
            this.lblModificacionCliente.TabIndex = 6;
            this.lblModificacionCliente.Text = "Modificacion Cliente:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(119, 179);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(61, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmModificacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 214);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblModificacionCliente);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cbPerfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNuevoApellido);
            this.Controls.Add(this.lblNuevoNombre);
            this.Name = "frmModificacionCliente";
            this.Text = "Modificacion Cliente";
            this.Load += new System.EventHandler(this.frmModificacionCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.Label lblNuevoApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPerfil;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblModificacionCliente;
        private System.Windows.Forms.Button btnModificar;
    }
}