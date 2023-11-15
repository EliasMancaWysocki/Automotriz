
namespace AutomotrizFront.Presentación.Soporte
{
    partial class FrmResultadoConsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListaResultado = new System.Windows.Forms.DataGridView();
            this.NroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaResultado
            // 
            this.dgvListaResultado.AllowUserToAddRows = false;
            this.dgvListaResultado.AllowUserToDeleteRows = false;
            this.dgvListaResultado.AllowUserToOrderColumns = true;
            this.dgvListaResultado.AllowUserToResizeColumns = false;
            this.dgvListaResultado.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroCliente,
            this.Seleccionar});
            this.dgvListaResultado.Location = new System.Drawing.Point(12, 38);
            this.dgvListaResultado.MultiSelect = false;
            this.dgvListaResultado.Name = "dgvListaResultado";
            this.dgvListaResultado.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvListaResultado.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaResultado.Size = new System.Drawing.Size(876, 379);
            this.dgvListaResultado.TabIndex = 1;
            // 
            // NroCliente
            // 
            this.NroCliente.DataPropertyName = "Nro Cliente";
            this.NroCliente.HeaderText = "NroCliente";
            this.NroCliente.Name = "NroCliente";
            this.NroCliente.Visible = false;
            // 
            // Seleccionar
            // 
            this.Seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Seleccionar.HeaderText = "Ver";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // FrmResultadoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 446);
            this.Controls.Add(this.dgvListaResultado);
            this.Name = "FrmResultadoConsulta";
            this.Text = "RESULTADO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCliente;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}