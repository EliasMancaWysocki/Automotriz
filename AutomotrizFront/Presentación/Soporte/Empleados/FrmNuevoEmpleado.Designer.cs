
namespace Automotriz.Presentación.Soporte
{
    partial class FrmNuevoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoEmpleado));
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblTipoEmpleado = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.BackColor = System.Drawing.Color.Transparent;
            this.lblLegajo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.Location = new System.Drawing.Point(115, 25);
            this.lblLegajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(55, 19);
            this.lblLegajo.TabIndex = 0;
            this.lblLegajo.Text = "Legajo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(178, 87);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(107, 90);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(338, 90);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 19);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(410, 87);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 26);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.BackColor = System.Drawing.Color.Transparent;
            this.lblCalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(126, 120);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(44, 19);
            this.lblCalle.TabIndex = 5;
            this.lblCalle.Text = "Calle";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(178, 117);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(148, 26);
            this.txtCalle.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(410, 117);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 26);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.BackColor = System.Drawing.Color.Transparent;
            this.lblAltura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(351, 120);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(51, 19);
            this.lblAltura.TabIndex = 8;
            this.lblAltura.Text = "Altura";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 148);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 26);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(41, 150);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(129, 19);
            this.lblFechaNacimiento.TabIndex = 11;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // cboBarrio
            // 
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(178, 177);
            this.cboBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(180, 27);
            this.cboBarrio.TabIndex = 12;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.BackColor = System.Drawing.Color.Transparent;
            this.lblBarrio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(118, 180);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(52, 19);
            this.lblBarrio.TabIndex = 13;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.BackColor = System.Drawing.Color.Transparent;
            this.lblDocumento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(85, 210);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(85, 19);
            this.lblDocumento.TabIndex = 14;
            this.lblDocumento.Text = "Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(178, 207);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(148, 26);
            this.txtDocumento.TabIndex = 15;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(410, 207);
            this.cboTipoDoc.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(180, 27);
            this.cboTipoDoc.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(178, 237);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(412, 27);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.Location = new System.Drawing.Point(328, 210);
            this.lblTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(74, 19);
            this.lblTipoDocumento.TabIndex = 18;
            this.lblTipoDocumento.Text = "Tipo Doc.";
            // 
            // lblTipoEmpleado
            // 
            this.lblTipoEmpleado.AutoSize = true;
            this.lblTipoEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoEmpleado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEmpleado.Location = new System.Drawing.Point(61, 240);
            this.lblTipoEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoEmpleado.Name = "lblTipoEmpleado";
            this.lblTipoEmpleado.Size = new System.Drawing.Size(109, 19);
            this.lblTipoEmpleado.TabIndex = 19;
            this.lblTipoEmpleado.Text = "Tipo Empleado";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(126, 296);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 44);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(410, 296);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(135, 44);
            this.btnGrabar.TabIndex = 21;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // FrmNuevoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(614, 351);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTipoEmpleado);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cboTipoDoc);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.cboBarrio);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblLegajo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(630, 390);
            this.MinimumSize = new System.Drawing.Size(630, 390);
            this.Name = "FrmNuevoEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Empleado";
            this.Load += new System.EventHandler(this.FrmNuevoEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblTipoEmpleado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
    }
}