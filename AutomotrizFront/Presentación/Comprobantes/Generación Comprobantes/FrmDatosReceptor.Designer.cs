namespace Automotriz.Presentación
{
    partial class FrmDatosReceptor
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCondicionIVA = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cboCondicionIVA = new System.Windows.Forms.ComboBox();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBoxCondicionVenta = new System.Windows.Forms.GroupBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBoxAdvertenciaDoc = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(163, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "label1";
            // 
            // lblCondicionIVA
            // 
            this.lblCondicionIVA.AutoSize = true;
            this.lblCondicionIVA.Location = new System.Drawing.Point(64, 70);
            this.lblCondicionIVA.Name = "lblCondicionIVA";
            this.lblCondicionIVA.Size = new System.Drawing.Size(115, 13);
            this.lblCondicionIVA.TabIndex = 1;
            this.lblCondicionIVA.Text = "Condición frente al IVA";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(44, 100);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(135, 13);
            this.lblDocumento.TabIndex = 2;
            this.lblDocumento.Text = "Tipo y Nro.  de Documento";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(12, 130);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(167, 13);
            this.lblRazonSocial.TabIndex = 3;
            this.lblRazonSocial.Text = "Apellido y Nombre o Razón Social";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(81, 160);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(98, 13);
            this.lblDomicilio.TabIndex = 4;
            this.lblDomicilio.Text = "Domicilio Comercial";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(147, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // cboCondicionIVA
            // 
            this.cboCondicionIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCondicionIVA.FormattingEnabled = true;
            this.cboCondicionIVA.Location = new System.Drawing.Point(185, 67);
            this.cboCondicionIVA.Name = "cboCondicionIVA";
            this.cboCondicionIVA.Size = new System.Drawing.Size(246, 21);
            this.cboCondicionIVA.TabIndex = 6;
            this.cboCondicionIVA.SelectedIndexChanged += new System.EventHandler(this.cboCondicionIVA_SelectedIndexChanged);
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(185, 97);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(120, 21);
            this.cboTipoDoc.TabIndex = 7;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(311, 97);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(120, 20);
            this.txtDocumento.TabIndex = 8;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(185, 127);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(246, 20);
            this.txtRazonSocial.TabIndex = 9;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Enabled = false;
            this.txtDomicilio.Location = new System.Drawing.Point(185, 157);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(246, 20);
            this.txtDomicilio.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(185, 187);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // groupBoxCondicionVenta
            // 
            this.groupBoxCondicionVenta.Location = new System.Drawing.Point(85, 230);
            this.groupBoxCondicionVenta.Name = "groupBoxCondicionVenta";
            this.groupBoxCondicionVenta.Size = new System.Drawing.Size(290, 230);
            this.groupBoxCondicionVenta.TabIndex = 12;
            this.groupBoxCondicionVenta.TabStop = false;
            this.groupBoxCondicionVenta.Text = "Condición de Venta";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(230, 476);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 13;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(129, 476);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBoxAdvertenciaDoc
            // 
            this.groupBoxAdvertenciaDoc.ForeColor = System.Drawing.Color.Red;
            this.groupBoxAdvertenciaDoc.Location = new System.Drawing.Point(311, 61);
            this.groupBoxAdvertenciaDoc.Name = "groupBoxAdvertenciaDoc";
            this.groupBoxAdvertenciaDoc.Size = new System.Drawing.Size(120, 30);
            this.groupBoxAdvertenciaDoc.TabIndex = 14;
            this.groupBoxAdvertenciaDoc.TabStop = false;
            this.groupBoxAdvertenciaDoc.Text = "Número de documento inválido";
            this.groupBoxAdvertenciaDoc.Visible = false;
            // 
            // FrmDatosReceptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 521);
            this.Controls.Add(this.groupBoxAdvertenciaDoc);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.groupBoxCondicionVenta);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.cboTipoDoc);
            this.Controls.Add(this.cboCondicionIVA);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblCondicionIVA);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(465, 560);
            this.MinimumSize = new System.Drawing.Size(465, 560);
            this.Name = "FrmDatosReceptor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Receptor";
            this.Load += new System.EventHandler(this.FrmDatosRecepcion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCondicionIVA;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cboCondicionIVA;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBoxCondicionVenta;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBoxAdvertenciaDoc;
    }
}