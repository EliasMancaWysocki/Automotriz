namespace AutomotrizFront.Presentación.Soporte.Clientes
{
    partial class ClientesConsulta2
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblConsultaClientes = new System.Windows.Forms.Label();
            this.nudDesde = new System.Windows.Forms.NumericUpDown();
            this.nudHasta = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(15, 105);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(853, 369);
            this.dgvClientes.TabIndex = 7;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(684, 36);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(184, 23);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblConsultaClientes
            // 
            this.lblConsultaClientes.AutoSize = true;
            this.lblConsultaClientes.Location = new System.Drawing.Point(12, 18);
            this.lblConsultaClientes.Name = "lblConsultaClientes";
            this.lblConsultaClientes.Size = new System.Drawing.Size(92, 13);
            this.lblConsultaClientes.TabIndex = 5;
            this.lblConsultaClientes.Text = "Consultas clientes";
            // 
            // nudDesde
            // 
            this.nudDesde.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudDesde.Location = new System.Drawing.Point(113, 39);
            this.nudDesde.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.nudDesde.Name = "nudDesde";
            this.nudDesde.Size = new System.Drawing.Size(120, 20);
            this.nudDesde.TabIndex = 8;
            // 
            // nudHasta
            // 
            this.nudHasta.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudHasta.Location = new System.Drawing.Point(280, 39);
            this.nudHasta.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.nudHasta.Name = "nudHasta";
            this.nudHasta.Size = new System.Drawing.Size(120, 20);
            this.nudHasta.TabIndex = 9;
            // 
            // ClientesConsulta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 486);
            this.Controls.Add(this.nudHasta);
            this.Controls.Add(this.nudDesde);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblConsultaClientes);
            this.Name = "ClientesConsulta2";
            this.Text = "ClientesConsulta2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblConsultaClientes;
        private System.Windows.Forms.NumericUpDown nudDesde;
        private System.Windows.Forms.NumericUpDown nudHasta;
    }
}