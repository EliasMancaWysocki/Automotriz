namespace Automotriz.Presentación.Consultas.Consultar_Comprobantes
{
    partial class FrmConsultaComprobantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaComprobantes));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBoxFechaEmision = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.groupBoxComprobante = new System.Windows.Forms.GroupBox();
            this.txtNumComprobante = new System.Windows.Forms.TextBox();
            this.lblNumComprobante = new System.Windows.Forms.Label();
            this.groupBoxReceptor = new System.Windows.Forms.GroupBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblNumDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.groupBoxDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lblNomEmpleado = new System.Windows.Forms.Label();
            this.txtLegajoEmpleado = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBoxFechaEmision.SuspendLayout();
            this.groupBoxComprobante.SuspendLayout();
            this.groupBoxReceptor.SuspendLayout();
            this.groupBoxDatosEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(257, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CONSULTA DE COMPROBANTES";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(6, 30);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(38, 13);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Desde";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(50, 24);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(100, 20);
            this.dtpDesde.TabIndex = 2;
            this.dtpDesde.Value = new System.DateTime(2023, 10, 27, 16, 7, 6, 0);
            // 
            // groupBoxFechaEmision
            // 
            this.groupBoxFechaEmision.Controls.Add(this.dtpHasta);
            this.groupBoxFechaEmision.Controls.Add(this.lblHasta);
            this.groupBoxFechaEmision.Controls.Add(this.lblDesde);
            this.groupBoxFechaEmision.Controls.Add(this.dtpDesde);
            this.groupBoxFechaEmision.Location = new System.Drawing.Point(12, 80);
            this.groupBoxFechaEmision.Name = "groupBoxFechaEmision";
            this.groupBoxFechaEmision.Size = new System.Drawing.Size(330, 60);
            this.groupBoxFechaEmision.TabIndex = 3;
            this.groupBoxFechaEmision.TabStop = false;
            this.groupBoxFechaEmision.Text = "Fecha de Emisión";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(224, 24);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(100, 20);
            this.dtpHasta.TabIndex = 4;
            this.dtpHasta.Value = new System.DateTime(2023, 10, 27, 16, 7, 6, 0);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(180, 30);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta";
            // 
            // groupBoxComprobante
            // 
            this.groupBoxComprobante.Controls.Add(this.txtNumComprobante);
            this.groupBoxComprobante.Controls.Add(this.lblNumComprobante);
            this.groupBoxComprobante.Location = new System.Drawing.Point(12, 146);
            this.groupBoxComprobante.Name = "groupBoxComprobante";
            this.groupBoxComprobante.Size = new System.Drawing.Size(330, 59);
            this.groupBoxComprobante.TabIndex = 4;
            this.groupBoxComprobante.TabStop = false;
            this.groupBoxComprobante.Text = "Comprobante";
            // 
            // txtNumComprobante
            // 
            this.txtNumComprobante.Location = new System.Drawing.Point(113, 27);
            this.txtNumComprobante.Name = "txtNumComprobante";
            this.txtNumComprobante.Size = new System.Drawing.Size(120, 20);
            this.txtNumComprobante.TabIndex = 8;
            // 
            // lblNumComprobante
            // 
            this.lblNumComprobante.AutoSize = true;
            this.lblNumComprobante.Location = new System.Drawing.Point(63, 30);
            this.lblNumComprobante.Name = "lblNumComprobante";
            this.lblNumComprobante.Size = new System.Drawing.Size(44, 13);
            this.lblNumComprobante.TabIndex = 6;
            this.lblNumComprobante.Text = "Número";
            // 
            // groupBoxReceptor
            // 
            this.groupBoxReceptor.Controls.Add(this.txtRazonSocial);
            this.groupBoxReceptor.Controls.Add(this.lblRazonSocial);
            this.groupBoxReceptor.Controls.Add(this.txtNumDoc);
            this.groupBoxReceptor.Controls.Add(this.cboTipoDoc);
            this.groupBoxReceptor.Controls.Add(this.lblNumDoc);
            this.groupBoxReceptor.Controls.Add(this.lblTipoDoc);
            this.groupBoxReceptor.Location = new System.Drawing.Point(12, 211);
            this.groupBoxReceptor.Name = "groupBoxReceptor";
            this.groupBoxReceptor.Size = new System.Drawing.Size(330, 133);
            this.groupBoxReceptor.TabIndex = 9;
            this.groupBoxReceptor.TabStop = false;
            this.groupBoxReceptor.Text = "Datos del Receptor";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(113, 33);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(211, 20);
            this.txtRazonSocial.TabIndex = 10;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(6, 30);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(101, 26);
            this.lblRazonSocial.TabIndex = 9;
            this.lblRazonSocial.Text = "Apellido y Nombre o\r\nRazón Social";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Location = new System.Drawing.Point(113, 100);
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(120, 20);
            this.txtNumDoc.TabIndex = 8;
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(113, 70);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(211, 21);
            this.cboTipoDoc.TabIndex = 7;
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.Location = new System.Drawing.Point(63, 103);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(44, 13);
            this.lblNumDoc.TabIndex = 6;
            this.lblNumDoc.Text = "Número";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(6, 73);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(101, 13);
            this.lblTipoDoc.TabIndex = 5;
            this.lblTipoDoc.Text = "Tipo de Documento";
            // 
            // groupBoxDatosEmpleado
            // 
            this.groupBoxDatosEmpleado.Controls.Add(this.txtEmpleado);
            this.groupBoxDatosEmpleado.Controls.Add(this.lblNomEmpleado);
            this.groupBoxDatosEmpleado.Controls.Add(this.txtLegajoEmpleado);
            this.groupBoxDatosEmpleado.Controls.Add(this.lblLegajo);
            this.groupBoxDatosEmpleado.Location = new System.Drawing.Point(12, 350);
            this.groupBoxDatosEmpleado.Name = "groupBoxDatosEmpleado";
            this.groupBoxDatosEmpleado.Size = new System.Drawing.Size(330, 90);
            this.groupBoxDatosEmpleado.TabIndex = 11;
            this.groupBoxDatosEmpleado.TabStop = false;
            this.groupBoxDatosEmpleado.Text = "Datos del Empleado";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(113, 27);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(211, 20);
            this.txtEmpleado.TabIndex = 10;
            // 
            // lblNomEmpleado
            // 
            this.lblNomEmpleado.AutoSize = true;
            this.lblNomEmpleado.Location = new System.Drawing.Point(15, 30);
            this.lblNomEmpleado.Name = "lblNomEmpleado";
            this.lblNomEmpleado.Size = new System.Drawing.Size(92, 13);
            this.lblNomEmpleado.TabIndex = 9;
            this.lblNomEmpleado.Text = "Apellido y Nombre";
            // 
            // txtLegajoEmpleado
            // 
            this.txtLegajoEmpleado.Location = new System.Drawing.Point(113, 57);
            this.txtLegajoEmpleado.Name = "txtLegajoEmpleado";
            this.txtLegajoEmpleado.Size = new System.Drawing.Size(120, 20);
            this.txtLegajoEmpleado.TabIndex = 8;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(68, 60);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 5;
            this.lblLegajo.Text = "Legajo";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(62, 460);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(152, 460);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmConsultaComprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 501);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBoxDatosEmpleado);
            this.Controls.Add(this.groupBoxReceptor);
            this.Controls.Add(this.groupBoxComprobante);
            this.Controls.Add(this.groupBoxFechaEmision);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 540);
            this.MinimumSize = new System.Drawing.Size(375, 540);
            this.Name = "FrmConsultaComprobantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaComprobantes";
            this.Load += new System.EventHandler(this.FrmConsultaComprobantes_Load);
            this.groupBoxFechaEmision.ResumeLayout(false);
            this.groupBoxFechaEmision.PerformLayout();
            this.groupBoxComprobante.ResumeLayout(false);
            this.groupBoxComprobante.PerformLayout();
            this.groupBoxReceptor.ResumeLayout(false);
            this.groupBoxReceptor.PerformLayout();
            this.groupBoxDatosEmpleado.ResumeLayout(false);
            this.groupBoxDatosEmpleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.GroupBox groupBoxFechaEmision;
        private System.Windows.Forms.GroupBox groupBoxComprobante;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblNumComprobante;
        private System.Windows.Forms.TextBox txtNumComprobante;
        private System.Windows.Forms.GroupBox groupBoxReceptor;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.Label lblNumDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.GroupBox groupBoxDatosEmpleado;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label lblNomEmpleado;
        private System.Windows.Forms.TextBox txtLegajoEmpleado;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBuscar;
    }
}