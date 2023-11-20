namespace AutomotrizFront.Presentación
{
    partial class FrmDatosEmisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatosEmisor));
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblConceptos = new System.Windows.Forms.Label();
            this.cboConceptos = new System.Windows.Forms.ComboBox();
            this.groupBoxActividades = new System.Windows.Forms.GroupBox();
            this.btnActMenos = new System.Windows.Forms.Button();
            this.btnActMas = new System.Windows.Forms.Button();
            this.cboAct5 = new System.Windows.Forms.ComboBox();
            this.lblAct5 = new System.Windows.Forms.Label();
            this.cboAct4 = new System.Windows.Forms.ComboBox();
            this.lblAct4 = new System.Windows.Forms.Label();
            this.cboAct3 = new System.Windows.Forms.ComboBox();
            this.lblAct3 = new System.Windows.Forms.Label();
            this.cboAct2 = new System.Windows.Forms.ComboBox();
            this.lblAct2 = new System.Windows.Forms.Label();
            this.cboAct1 = new System.Windows.Forms.ComboBox();
            this.lblAct1 = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.cboComprobantes = new System.Windows.Forms.ComboBox();
            this.lblTipoComprobate = new System.Windows.Forms.Label();
            this.groupBoxActividades.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 75);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(163, 19);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha del comprobante";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(185, 76);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(101, 20);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2023, 10, 18, 16, 49, 10, 0);
            // 
            // lblConceptos
            // 
            this.lblConceptos.AutoSize = true;
            this.lblConceptos.BackColor = System.Drawing.Color.Transparent;
            this.lblConceptos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConceptos.Location = new System.Drawing.Point(39, 115);
            this.lblConceptos.Name = "lblConceptos";
            this.lblConceptos.Size = new System.Drawing.Size(136, 19);
            this.lblConceptos.TabIndex = 3;
            this.lblConceptos.Text = "Conceptos a incluír";
            // 
            // cboConceptos
            // 
            this.cboConceptos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConceptos.FormattingEnabled = true;
            this.cboConceptos.Location = new System.Drawing.Point(185, 116);
            this.cboConceptos.Name = "cboConceptos";
            this.cboConceptos.Size = new System.Drawing.Size(121, 21);
            this.cboConceptos.TabIndex = 2;
            this.cboConceptos.SelectedIndexChanged += new System.EventHandler(this.cboConceptos_SelectedIndexChanged);
            // 
            // groupBoxActividades
            // 
            this.groupBoxActividades.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxActividades.Controls.Add(this.btnActMenos);
            this.groupBoxActividades.Controls.Add(this.btnActMas);
            this.groupBoxActividades.Controls.Add(this.cboAct5);
            this.groupBoxActividades.Controls.Add(this.lblAct5);
            this.groupBoxActividades.Controls.Add(this.cboAct4);
            this.groupBoxActividades.Controls.Add(this.lblAct4);
            this.groupBoxActividades.Controls.Add(this.cboAct3);
            this.groupBoxActividades.Controls.Add(this.lblAct3);
            this.groupBoxActividades.Controls.Add(this.cboAct2);
            this.groupBoxActividades.Controls.Add(this.lblAct2);
            this.groupBoxActividades.Controls.Add(this.cboAct1);
            this.groupBoxActividades.Controls.Add(this.lblAct1);
            this.groupBoxActividades.Controls.Add(this.lblActividad);
            this.groupBoxActividades.Controls.Add(this.lblNro);
            this.groupBoxActividades.Location = new System.Drawing.Point(15, 149);
            this.groupBoxActividades.Name = "groupBoxActividades";
            this.groupBoxActividades.Size = new System.Drawing.Size(508, 190);
            this.groupBoxActividades.TabIndex = 5;
            this.groupBoxActividades.TabStop = false;
            this.groupBoxActividades.Text = "Actividades Asociadas (opcional)";
            // 
            // btnActMenos
            // 
            this.btnActMenos.Enabled = false;
            this.btnActMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActMenos.Location = new System.Drawing.Point(435, 43);
            this.btnActMenos.Margin = new System.Windows.Forms.Padding(0);
            this.btnActMenos.Name = "btnActMenos";
            this.btnActMenos.Size = new System.Drawing.Size(23, 23);
            this.btnActMenos.TabIndex = 9;
            this.btnActMenos.Text = "-";
            this.btnActMenos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActMenos.UseVisualStyleBackColor = true;
            this.btnActMenos.Click += new System.EventHandler(this.btnActMenos_Click);
            // 
            // btnActMas
            // 
            this.btnActMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActMas.Location = new System.Drawing.Point(407, 43);
            this.btnActMas.Margin = new System.Windows.Forms.Padding(0);
            this.btnActMas.Name = "btnActMas";
            this.btnActMas.Size = new System.Drawing.Size(23, 23);
            this.btnActMas.TabIndex = 8;
            this.btnActMas.Text = "+";
            this.btnActMas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActMas.UseVisualStyleBackColor = true;
            this.btnActMas.Click += new System.EventHandler(this.btnMasAct_Click);
            // 
            // cboAct5
            // 
            this.cboAct5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAct5.FormattingEnabled = true;
            this.cboAct5.Location = new System.Drawing.Point(45, 153);
            this.cboAct5.Name = "cboAct5";
            this.cboAct5.Size = new System.Drawing.Size(355, 21);
            this.cboAct5.TabIndex = 7;
            this.cboAct5.Visible = false;
            // 
            // lblAct5
            // 
            this.lblAct5.AutoSize = true;
            this.lblAct5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAct5.Location = new System.Drawing.Point(12, 156);
            this.lblAct5.Name = "lblAct5";
            this.lblAct5.Size = new System.Drawing.Size(17, 19);
            this.lblAct5.TabIndex = 16;
            this.lblAct5.Text = "5";
            this.lblAct5.Visible = false;
            // 
            // cboAct4
            // 
            this.cboAct4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAct4.FormattingEnabled = true;
            this.cboAct4.Location = new System.Drawing.Point(45, 126);
            this.cboAct4.Name = "cboAct4";
            this.cboAct4.Size = new System.Drawing.Size(355, 21);
            this.cboAct4.TabIndex = 6;
            this.cboAct4.Visible = false;
            // 
            // lblAct4
            // 
            this.lblAct4.AutoSize = true;
            this.lblAct4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAct4.Location = new System.Drawing.Point(12, 129);
            this.lblAct4.Name = "lblAct4";
            this.lblAct4.Size = new System.Drawing.Size(17, 19);
            this.lblAct4.TabIndex = 14;
            this.lblAct4.Text = "4";
            this.lblAct4.Visible = false;
            // 
            // cboAct3
            // 
            this.cboAct3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAct3.FormattingEnabled = true;
            this.cboAct3.Location = new System.Drawing.Point(45, 99);
            this.cboAct3.Name = "cboAct3";
            this.cboAct3.Size = new System.Drawing.Size(355, 21);
            this.cboAct3.TabIndex = 5;
            this.cboAct3.Visible = false;
            // 
            // lblAct3
            // 
            this.lblAct3.AutoSize = true;
            this.lblAct3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAct3.Location = new System.Drawing.Point(12, 102);
            this.lblAct3.Name = "lblAct3";
            this.lblAct3.Size = new System.Drawing.Size(17, 19);
            this.lblAct3.TabIndex = 12;
            this.lblAct3.Text = "3";
            this.lblAct3.Visible = false;
            // 
            // cboAct2
            // 
            this.cboAct2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAct2.FormattingEnabled = true;
            this.cboAct2.Location = new System.Drawing.Point(45, 72);
            this.cboAct2.Name = "cboAct2";
            this.cboAct2.Size = new System.Drawing.Size(355, 21);
            this.cboAct2.TabIndex = 4;
            this.cboAct2.Visible = false;
            // 
            // lblAct2
            // 
            this.lblAct2.AutoSize = true;
            this.lblAct2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAct2.Location = new System.Drawing.Point(12, 75);
            this.lblAct2.Name = "lblAct2";
            this.lblAct2.Size = new System.Drawing.Size(17, 19);
            this.lblAct2.TabIndex = 10;
            this.lblAct2.Text = "2";
            this.lblAct2.Visible = false;
            // 
            // cboAct1
            // 
            this.cboAct1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAct1.FormattingEnabled = true;
            this.cboAct1.Location = new System.Drawing.Point(45, 45);
            this.cboAct1.Name = "cboAct1";
            this.cboAct1.Size = new System.Drawing.Size(355, 21);
            this.cboAct1.TabIndex = 3;
            // 
            // lblAct1
            // 
            this.lblAct1.AutoSize = true;
            this.lblAct1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAct1.Location = new System.Drawing.Point(12, 48);
            this.lblAct1.Name = "lblAct1";
            this.lblAct1.Size = new System.Drawing.Size(17, 19);
            this.lblAct1.TabIndex = 8;
            this.lblAct1.Text = "1";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(42, 26);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(72, 19);
            this.lblActividad.TabIndex = 7;
            this.lblActividad.Text = "Actividad";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.Location = new System.Drawing.Point(12, 26);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(35, 19);
            this.lblNro.TabIndex = 6;
            this.lblNro.Text = "Nro";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(152, 358);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 34);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(258, 360);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 34);
            this.btnSiguiente.TabIndex = 11;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(315, 117);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(101, 26);
            this.dtpDesde.TabIndex = 12;
            this.dtpDesde.Value = new System.DateTime(2023, 10, 18, 16, 49, 10, 0);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(422, 117);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(101, 26);
            this.dtpHasta.TabIndex = 13;
            this.dtpHasta.Value = new System.DateTime(2023, 10, 18, 16, 49, 10, 0);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.BackColor = System.Drawing.Color.Transparent;
            this.lblDesde.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(340, 95);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(52, 19);
            this.lblDesde.TabIndex = 14;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.BackColor = System.Drawing.Color.Transparent;
            this.lblHasta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(446, 95);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(49, 19);
            this.lblHasta.TabIndex = 15;
            this.lblHasta.Text = "Hasta";
            // 
            // cboComprobantes
            // 
            this.cboComprobantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComprobantes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboComprobantes.FormattingEnabled = true;
            this.cboComprobantes.Location = new System.Drawing.Point(185, 31);
            this.cboComprobantes.Name = "cboComprobantes";
            this.cboComprobantes.Size = new System.Drawing.Size(140, 21);
            this.cboComprobantes.TabIndex = 16;
            // 
            // lblTipoComprobate
            // 
            this.lblTipoComprobate.AutoSize = true;
            this.lblTipoComprobate.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoComprobate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoComprobate.Location = new System.Drawing.Point(22, 30);
            this.lblTipoComprobate.Name = "lblTipoComprobate";
            this.lblTipoComprobate.Size = new System.Drawing.Size(153, 19);
            this.lblTipoComprobate.TabIndex = 17;
            this.lblTipoComprobate.Text = "Tipo de Comprobante";
            // 
            // FrmDatosEmisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(539, 411);
            this.Controls.Add(this.cboComprobantes);
            this.Controls.Add(this.lblTipoComprobate);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBoxActividades);
            this.Controls.Add(this.cboConceptos);
            this.Controls.Add(this.lblConceptos);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(555, 450);
            this.MinimumSize = new System.Drawing.Size(555, 450);
            this.Name = "FrmDatosEmisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de Emisión";
            this.Load += new System.EventHandler(this.FrmComprobante_Load);
            this.groupBoxActividades.ResumeLayout(false);
            this.groupBoxActividades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblConceptos;
        private System.Windows.Forms.ComboBox cboConceptos;
        private System.Windows.Forms.GroupBox groupBoxActividades;
        private System.Windows.Forms.ComboBox cboAct5;
        private System.Windows.Forms.Label lblAct5;
        private System.Windows.Forms.ComboBox cboAct4;
        private System.Windows.Forms.Label lblAct4;
        private System.Windows.Forms.ComboBox cboAct3;
        private System.Windows.Forms.Label lblAct3;
        private System.Windows.Forms.ComboBox cboAct2;
        private System.Windows.Forms.Label lblAct2;
        private System.Windows.Forms.ComboBox cboAct1;
        private System.Windows.Forms.Label lblAct1;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Button btnActMas;
        private System.Windows.Forms.Button btnActMenos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.ComboBox cboComprobantes;
        private System.Windows.Forms.Label lblTipoComprobate;
    }
}