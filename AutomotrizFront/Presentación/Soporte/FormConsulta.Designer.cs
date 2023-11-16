
namespace AutomotrizFront.Presentación.Soporte
{
    partial class FormConsulta
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
            this.tbCondicion = new System.Windows.Forms.TabControl();
            this.pagCliente = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNroCliente = new System.Windows.Forms.TextBox();
            this.lblidcliente = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblnom = new System.Windows.Forms.Label();
            this.tpDocumento = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.tpDomicilio = new System.Windows.Forms.TabPage();
            this.gbDomicilio = new System.Windows.Forms.GroupBox();
            this.cboBarrios = new System.Windows.Forms.ComboBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.tpTipoYCondicion = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCondicionIVA = new System.Windows.Forms.Label();
            this.cboCIva = new System.Windows.Forms.ComboBox();
            this.cboTCliente = new System.Windows.Forms.ComboBox();
            this.lbltipoCliente = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tbCondicion.SuspendLayout();
            this.pagCliente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpDocumento.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tpDomicilio.SuspendLayout();
            this.gbDomicilio.SuspendLayout();
            this.tpTipoYCondicion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCondicion
            // 
            this.tbCondicion.Controls.Add(this.pagCliente);
            this.tbCondicion.Controls.Add(this.tpDocumento);
            this.tbCondicion.Controls.Add(this.tpDomicilio);
            this.tbCondicion.Controls.Add(this.tpTipoYCondicion);
            this.tbCondicion.Location = new System.Drawing.Point(45, 63);
            this.tbCondicion.Name = "tbCondicion";
            this.tbCondicion.SelectedIndex = 0;
            this.tbCondicion.Size = new System.Drawing.Size(439, 228);
            this.tbCondicion.TabIndex = 56;
            // 
            // pagCliente
            // 
            this.pagCliente.Controls.Add(this.groupBox2);
            this.pagCliente.Location = new System.Drawing.Point(4, 22);
            this.pagCliente.Name = "pagCliente";
            this.pagCliente.Padding = new System.Windows.Forms.Padding(3);
            this.pagCliente.Size = new System.Drawing.Size(431, 202);
            this.pagCliente.TabIndex = 0;
            this.pagCliente.Text = "CLIENTE";
            this.pagCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNroCliente);
            this.groupBox2.Controls.Add(this.lblidcliente);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.lblApellido);
            this.groupBox2.Controls.Add(this.txtApellido);
            this.groupBox2.Controls.Add(this.lblnom);
            this.groupBox2.Location = new System.Drawing.Point(53, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 163);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // txtNroCliente
            // 
            this.txtNroCliente.Location = new System.Drawing.Point(144, 33);
            this.txtNroCliente.Name = "txtNroCliente";
            this.txtNroCliente.Size = new System.Drawing.Size(132, 20);
            this.txtNroCliente.TabIndex = 52;
            // 
            // lblidcliente
            // 
            this.lblidcliente.AutoSize = true;
            this.lblidcliente.BackColor = System.Drawing.Color.Transparent;
            this.lblidcliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidcliente.Location = new System.Drawing.Point(39, 33);
            this.lblidcliente.Name = "lblidcliente";
            this.lblidcliente.Size = new System.Drawing.Size(87, 19);
            this.lblidcliente.TabIndex = 51;
            this.lblidcliente.Text = "Nro Cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(145, 74);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNombre.TabIndex = 29;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(39, 118);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 19);
            this.lblApellido.TabIndex = 49;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(145, 120);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 20);
            this.txtApellido.TabIndex = 30;
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.BackColor = System.Drawing.Color.Transparent;
            this.lblnom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom.Location = new System.Drawing.Point(39, 73);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(63, 19);
            this.lblnom.TabIndex = 47;
            this.lblnom.Text = "Nombre";
            // 
            // tpDocumento
            // 
            this.tpDocumento.Controls.Add(this.groupBox3);
            this.tpDocumento.Location = new System.Drawing.Point(4, 22);
            this.tpDocumento.Name = "tpDocumento";
            this.tpDocumento.Padding = new System.Windows.Forms.Padding(3);
            this.tpDocumento.Size = new System.Drawing.Size(431, 202);
            this.tpDocumento.TabIndex = 1;
            this.tpDocumento.Text = "DOCUMENTO";
            this.tpDocumento.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDocumento);
            this.groupBox3.Controls.Add(this.txtDocumento);
            this.groupBox3.Controls.Add(this.lblTipoDoc);
            this.groupBox3.Controls.Add(this.cboTipoDoc);
            this.groupBox3.Location = new System.Drawing.Point(53, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 160);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.BackColor = System.Drawing.Color.Transparent;
            this.lblDocumento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(6, 27);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(85, 19);
            this.lblDocumento.TabIndex = 37;
            this.lblDocumento.Text = "Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(163, 28);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(132, 20);
            this.txtDocumento.TabIndex = 38;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoDoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(6, 71);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(139, 19);
            this.lblTipoDoc.TabIndex = 39;
            this.lblTipoDoc.Text = "Tipo de Documento";
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(163, 72);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(132, 21);
            this.cboTipoDoc.TabIndex = 40;
            // 
            // tpDomicilio
            // 
            this.tpDomicilio.Controls.Add(this.gbDomicilio);
            this.tpDomicilio.Location = new System.Drawing.Point(4, 22);
            this.tpDomicilio.Name = "tpDomicilio";
            this.tpDomicilio.Padding = new System.Windows.Forms.Padding(3);
            this.tpDomicilio.Size = new System.Drawing.Size(431, 202);
            this.tpDomicilio.TabIndex = 2;
            this.tpDomicilio.Text = "DOMICILIO";
            this.tpDomicilio.UseVisualStyleBackColor = true;
            // 
            // gbDomicilio
            // 
            this.gbDomicilio.Controls.Add(this.cboBarrios);
            this.gbDomicilio.Controls.Add(this.lblBarrio);
            this.gbDomicilio.Controls.Add(this.txtAltura);
            this.gbDomicilio.Controls.Add(this.label2);
            this.gbDomicilio.Controls.Add(this.txtCalle);
            this.gbDomicilio.Controls.Add(this.lblCalle);
            this.gbDomicilio.Location = new System.Drawing.Point(59, 27);
            this.gbDomicilio.Name = "gbDomicilio";
            this.gbDomicilio.Size = new System.Drawing.Size(343, 163);
            this.gbDomicilio.TabIndex = 3;
            this.gbDomicilio.TabStop = false;
            // 
            // cboBarrios
            // 
            this.cboBarrios.FormattingEnabled = true;
            this.cboBarrios.Location = new System.Drawing.Point(114, 74);
            this.cboBarrios.Name = "cboBarrios";
            this.cboBarrios.Size = new System.Drawing.Size(132, 21);
            this.cboBarrios.TabIndex = 50;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.BackColor = System.Drawing.Color.Transparent;
            this.lblBarrio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(32, 76);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(52, 19);
            this.lblBarrio.TabIndex = 49;
            this.lblBarrio.Text = "Barrio";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(114, 117);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(43, 20);
            this.txtAltura.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Altura";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(114, 32);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(132, 20);
            this.txtCalle.TabIndex = 46;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.BackColor = System.Drawing.Color.Transparent;
            this.lblCalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(32, 30);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(44, 19);
            this.lblCalle.TabIndex = 45;
            this.lblCalle.Text = "Calle";
            // 
            // tpTipoYCondicion
            // 
            this.tpTipoYCondicion.Controls.Add(this.groupBox1);
            this.tpTipoYCondicion.Location = new System.Drawing.Point(4, 22);
            this.tpTipoYCondicion.Name = "tpTipoYCondicion";
            this.tpTipoYCondicion.Padding = new System.Windows.Forms.Padding(3);
            this.tpTipoYCondicion.Size = new System.Drawing.Size(431, 202);
            this.tpTipoYCondicion.TabIndex = 3;
            this.tpTipoYCondicion.Text = "TIPO Y CONDICION";
            this.tpTipoYCondicion.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCondicionIVA);
            this.groupBox1.Controls.Add(this.cboCIva);
            this.groupBox1.Controls.Add(this.cboTCliente);
            this.groupBox1.Controls.Add(this.lbltipoCliente);
            this.groupBox1.Location = new System.Drawing.Point(56, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblCondicionIVA
            // 
            this.lblCondicionIVA.AutoSize = true;
            this.lblCondicionIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblCondicionIVA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionIVA.Location = new System.Drawing.Point(15, 72);
            this.lblCondicionIVA.Name = "lblCondicionIVA";
            this.lblCondicionIVA.Size = new System.Drawing.Size(105, 19);
            this.lblCondicionIVA.TabIndex = 48;
            this.lblCondicionIVA.Text = "Condicion IVA";
            // 
            // cboCIva
            // 
            this.cboCIva.FormattingEnabled = true;
            this.cboCIva.Location = new System.Drawing.Point(131, 73);
            this.cboCIva.Name = "cboCIva";
            this.cboCIva.Size = new System.Drawing.Size(212, 21);
            this.cboCIva.TabIndex = 45;
            // 
            // cboTCliente
            // 
            this.cboTCliente.FormattingEnabled = true;
            this.cboTCliente.Location = new System.Drawing.Point(132, 28);
            this.cboTCliente.Name = "cboTCliente";
            this.cboTCliente.Size = new System.Drawing.Size(132, 21);
            this.cboTCliente.TabIndex = 42;
            // 
            // lbltipoCliente
            // 
            this.lbltipoCliente.AutoSize = true;
            this.lbltipoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbltipoCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipoCliente.Location = new System.Drawing.Point(15, 28);
            this.lbltipoCliente.Name = "lbltipoCliente";
            this.lbltipoCliente.Size = new System.Drawing.Size(111, 19);
            this.lbltipoCliente.TabIndex = 41;
            this.lbltipoCliente.Text = "Tipo de Cliente";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(153, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 19);
            this.lblTitulo.TabIndex = 55;
            this.lblTitulo.Text = "FILTROS DE BUSQUEDA";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(405, 307);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 57;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(49, 307);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 58;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 351);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.tbCondicion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormConsulta";
            this.Text = "FormConsulta";
            this.tbCondicion.ResumeLayout(false);
            this.pagCliente.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpDocumento.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tpDomicilio.ResumeLayout(false);
            this.gbDomicilio.ResumeLayout(false);
            this.gbDomicilio.PerformLayout();
            this.tpTipoYCondicion.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbCondicion;
        private System.Windows.Forms.TabPage pagCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNroCliente;
        private System.Windows.Forms.Label lblidcliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.TabPage tpDocumento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.TabPage tpDomicilio;
        private System.Windows.Forms.GroupBox gbDomicilio;
        private System.Windows.Forms.ComboBox cboBarrios;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TabPage tpTipoYCondicion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCondicionIVA;
        private System.Windows.Forms.ComboBox cboCIva;
        private System.Windows.Forms.ComboBox cboTCliente;
        private System.Windows.Forms.Label lbltipoCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnVolver;
    }
}