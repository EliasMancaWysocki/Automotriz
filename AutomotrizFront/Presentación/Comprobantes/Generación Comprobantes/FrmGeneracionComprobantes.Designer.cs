namespace Automotriz.Presentación
{
    partial class FrmGeneracionComprobantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeneracionComprobantes));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTipoComprobate = new System.Windows.Forms.Label();
            this.cboComprobantes = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(35, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 15);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = " GENERACIÓN DE COMPROBANTES";
            // 
            // lblTipoComprobate
            // 
            this.lblTipoComprobate.AutoSize = true;
            this.lblTipoComprobate.Location = new System.Drawing.Point(12, 72);
            this.lblTipoComprobate.Name = "lblTipoComprobate";
            this.lblTipoComprobate.Size = new System.Drawing.Size(109, 13);
            this.lblTipoComprobate.TabIndex = 1;
            this.lblTipoComprobate.Text = "Tipo de Comprobante";
            // 
            // cboComprobantes
            // 
            this.cboComprobantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComprobantes.FormattingEnabled = true;
            this.cboComprobantes.Location = new System.Drawing.Point(142, 69);
            this.cboComprobantes.Name = "cboComprobantes";
            this.cboComprobantes.Size = new System.Drawing.Size(140, 21);
            this.cboComprobantes.TabIndex = 1;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(38, 115);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(181, 115);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // FrmGeneracionComprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 151);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cboComprobantes);
            this.Controls.Add(this.lblTipoComprobate);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(310, 190);
            this.MinimumSize = new System.Drawing.Size(310, 190);
            this.Name = "FrmGeneracionComprobantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generación de Comprobantes";
            this.Load += new System.EventHandler(this.FrmGeneracionComprobantes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipoComprobate;
        private System.Windows.Forms.ComboBox cboComprobantes;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSiguiente;
    }
}