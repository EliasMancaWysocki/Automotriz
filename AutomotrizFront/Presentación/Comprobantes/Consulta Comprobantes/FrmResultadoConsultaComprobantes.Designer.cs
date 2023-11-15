namespace Automotriz.Presentación.Consultas.Consultar_Comprobantes
{
    partial class FrmResultadoConsultaComprobantes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.colFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxResultados = new System.Windows.Forms.GroupBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnNuevaBusqueda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.groupBoxResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.AllowUserToResizeColumns = false;
            this.dgvResultados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFechaEmision,
            this.colNumComprobante,
            this.colTipoDoc,
            this.colNumDoc,
            this.colImporte,
            this.colVer});
            this.dgvResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultados.Location = new System.Drawing.Point(3, 16);
            this.dgvResultados.MultiSelect = false;
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultados.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.ShowCellErrors = false;
            this.dgvResultados.ShowCellToolTips = false;
            this.dgvResultados.ShowEditingIcon = false;
            this.dgvResultados.ShowRowErrors = false;
            this.dgvResultados.Size = new System.Drawing.Size(524, 479);
            this.dgvResultados.TabIndex = 0;
            this.dgvResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellContentClick);
            // 
            // colFechaEmision
            // 
            this.colFechaEmision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colFechaEmision.DefaultCellStyle = dataGridViewCellStyle2;
            this.colFechaEmision.HeaderText = "Fecha Emisión";
            this.colFechaEmision.Name = "colFechaEmision";
            this.colFechaEmision.ReadOnly = true;
            this.colFechaEmision.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFechaEmision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFechaEmision.Width = 74;
            // 
            // colNumComprobante
            // 
            this.colNumComprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNumComprobante.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNumComprobante.HeaderText = "Num. Comprobante";
            this.colNumComprobante.Name = "colNumComprobante";
            this.colNumComprobante.ReadOnly = true;
            this.colNumComprobante.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNumComprobante.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNumComprobante.Width = 94;
            // 
            // colTipoDoc
            // 
            this.colTipoDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTipoDoc.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTipoDoc.HeaderText = "Tipo Doc. Receptor";
            this.colTipoDoc.Name = "colTipoDoc";
            this.colTipoDoc.ReadOnly = true;
            this.colTipoDoc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTipoDoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTipoDoc.Width = 96;
            // 
            // colNumDoc
            // 
            this.colNumDoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNumDoc.DefaultCellStyle = dataGridViewCellStyle5;
            this.colNumDoc.HeaderText = "Num. Doc. Receptor";
            this.colNumDoc.Name = "colNumDoc";
            this.colNumDoc.ReadOnly = true;
            this.colNumDoc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNumDoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colImporte
            // 
            this.colImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colImporte.DefaultCellStyle = dataGridViewCellStyle6;
            this.colImporte.HeaderText = "Importe Total";
            this.colImporte.Name = "colImporte";
            this.colImporte.ReadOnly = true;
            this.colImporte.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colImporte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colImporte.Width = 68;
            // 
            // colVer
            // 
            this.colVer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVer.HeaderText = "Ver";
            this.colVer.Name = "colVer";
            this.colVer.ReadOnly = true;
            this.colVer.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colVer.Text = "Ver";
            // 
            // groupBoxResultados
            // 
            this.groupBoxResultados.Controls.Add(this.dgvResultados);
            this.groupBoxResultados.Location = new System.Drawing.Point(12, 12);
            this.groupBoxResultados.Name = "groupBoxResultados";
            this.groupBoxResultados.Size = new System.Drawing.Size(530, 498);
            this.groupBoxResultados.TabIndex = 1;
            this.groupBoxResultados.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.btnMenu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(130, 530);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(121, 30);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Menú Principal";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnNuevaBusqueda
            // 
            this.btnNuevaBusqueda.AutoSize = true;
            this.btnNuevaBusqueda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaBusqueda.Location = new System.Drawing.Point(270, 530);
            this.btnNuevaBusqueda.Name = "btnNuevaBusqueda";
            this.btnNuevaBusqueda.Size = new System.Drawing.Size(133, 30);
            this.btnNuevaBusqueda.TabIndex = 4;
            this.btnNuevaBusqueda.Text = "Nueva Búsqueda";
            this.btnNuevaBusqueda.UseVisualStyleBackColor = true;
            this.btnNuevaBusqueda.Click += new System.EventHandler(this.btnNuevaBusqueda_Click);
            // 
            // FrmResultadoConsultaComprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 591);
            this.Controls.Add(this.btnNuevaBusqueda);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.groupBoxResultados);
<<<<<<< HEAD
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(570, 630);
            this.MinimumSize = new System.Drawing.Size(570, 630);
=======
>>>>>>> parent of 014f9ef (Añadida responsividad a los botones del menú principal)
            this.Name = "FrmResultadoConsultaComprobantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado Consulta Comprobantes";
            this.Load += new System.EventHandler(this.ResultadoConsultaComprobantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.groupBoxResultados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.GroupBox groupBoxResultados;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
        private System.Windows.Forms.DataGridViewButtonColumn colVer;
        private System.Windows.Forms.Button btnNuevaBusqueda;
    }
}