namespace Automotriz.Presentación.Soporte.Vendedores
{
    partial class VendedoresConsulta1
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
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblConsultaVendedores = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.AllowUserToAddRows = false;
            this.dgvVendedores.AllowUserToDeleteRows = false;
            this.dgvVendedores.AllowUserToOrderColumns = true;
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedores.Location = new System.Drawing.Point(13, 70);
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.ReadOnly = true;
            this.dgvVendedores.RowHeadersWidth = 51;
            this.dgvVendedores.Size = new System.Drawing.Size(777, 397);
            this.dgvVendedores.TabIndex = 7;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(606, 31);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(184, 23);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblConsultaVendedores
            // 
            this.lblConsultaVendedores.AutoSize = true;
            this.lblConsultaVendedores.Location = new System.Drawing.Point(12, 9);
            this.lblConsultaVendedores.Name = "lblConsultaVendedores";
            this.lblConsultaVendedores.Size = new System.Drawing.Size(112, 13);
            this.lblConsultaVendedores.TabIndex = 5;
            this.lblConsultaVendedores.Text = "Consultas vendedores";
            // 
            // nudValor
            // 
            this.nudValor.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudValor.Location = new System.Drawing.Point(291, 34);
            this.nudValor.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(120, 20);
            this.nudValor.TabIndex = 8;
            // 
            // VendedoresConsulta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 490);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(this.dgvVendedores);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblConsultaVendedores);
            this.Name = "VendedoresConsulta1";
            this.Text = "VendedoresConsulta1";
            this.Load += new System.EventHandler(this.VendedoresConsulta1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendedores;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblConsultaVendedores;
        private System.Windows.Forms.NumericUpDown nudValor;
    }
}