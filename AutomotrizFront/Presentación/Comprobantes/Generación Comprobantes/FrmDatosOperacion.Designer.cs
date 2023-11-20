namespace AutomotrizFront.Presentación
{
    partial class FrmDatosOperacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatosOperacion));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboUnidadMedida = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtBonif = new System.Windows.Forms.TextBox();
            this.txtImporteBonif = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBonificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImporteBonif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.layoutCodigo = new System.Windows.Forms.FlowLayoutPanel();
            this.layoutProducto = new System.Windows.Forms.FlowLayoutPanel();
            this.layoutCantidad = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.layoutUnMedida = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUnMedida = new System.Windows.Forms.Label();
            this.layoutPrecio = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.layoutBonif = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBonificacion = new System.Windows.Forms.Label();
            this.layoutImpBonif = new System.Windows.Forms.FlowLayoutPanel();
            this.lblImporteBonif = new System.Windows.Forms.Label();
            this.layoutSubtotal = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.layoutCodigo.SuspendLayout();
            this.layoutProducto.SuspendLayout();
            this.layoutCantidad.SuspendLayout();
            this.layoutUnMedida.SuspendLayout();
            this.layoutPrecio.SuspendLayout();
            this.layoutBonif.SuspendLayout();
            this.layoutImpBonif.SuspendLayout();
            this.layoutSubtotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(423, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "label1";
            // 
            // cboUnidadMedida
            // 
            this.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadMedida.Enabled = false;
            this.cboUnidadMedida.FormattingEnabled = true;
            this.cboUnidadMedida.Location = new System.Drawing.Point(330, 80);
            this.cboUnidadMedida.Name = "cboUnidadMedida";
            this.cboUnidadMedida.Size = new System.Drawing.Size(121, 21);
            this.cboUnidadMedida.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(457, 80);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(90, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtBonif
            // 
            this.txtBonif.Enabled = false;
            this.txtBonif.Location = new System.Drawing.Point(553, 80);
            this.txtBonif.Name = "txtBonif";
            this.txtBonif.Size = new System.Drawing.Size(50, 20);
            this.txtBonif.TabIndex = 6;
            // 
            // txtImporteBonif
            // 
            this.txtImporteBonif.Enabled = false;
            this.txtImporteBonif.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtImporteBonif.Location = new System.Drawing.Point(609, 80);
            this.txtImporteBonif.Name = "txtImporteBonif";
            this.txtImporteBonif.Size = new System.Drawing.Size(90, 20);
            this.txtImporteBonif.TabIndex = 7;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(705, 80);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(90, 20);
            this.txtSubtotal.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(801, 78);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(68, 80);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(200, 21);
            this.cboProducto.TabIndex = 10;
            this.cboProducto.SelectionChangeCommitted += new System.EventHandler(this.cboProducto_SelectionChangeCommitted);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.AllowUserToResizeColumns = false;
            this.dataGridViewProductos.AllowUserToResizeRows = false;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColProducto,
            this.ColCantidad,
            this.ColUnidadMedida,
            this.ColPrecio,
            this.ColBonificacion,
            this.ColImporteBonif,
            this.ColSubtotal,
            this.ColEliminar});
            this.dataGridViewProductos.Location = new System.Drawing.Point(12, 107);
            this.dataGridViewProductos.MultiSelect = false;
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.RowHeadersVisible = false;
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.ShowCellErrors = false;
            this.dataGridViewProductos.ShowCellToolTips = false;
            this.dataGridViewProductos.ShowEditingIcon = false;
            this.dataGridViewProductos.ShowRowErrors = false;
            this.dataGridViewProductos.Size = new System.Drawing.Size(864, 250);
            this.dataGridViewProductos.TabIndex = 11;
            // 
            // ColCodigo
            // 
            this.ColCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Width = 50;
            // 
            // ColProducto
            // 
            this.ColProducto.HeaderText = "Producto/Servicio";
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.ReadOnly = true;
            this.ColProducto.Width = 210;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cant.";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            this.ColCantidad.Width = 50;
            // 
            // ColUnidadMedida
            // 
            this.ColUnidadMedida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColUnidadMedida.HeaderText = "Un. Medida";
            this.ColUnidadMedida.Name = "ColUnidadMedida";
            this.ColUnidadMedida.ReadOnly = true;
            this.ColUnidadMedida.Width = 130;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio Unit.";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            // 
            // ColBonificacion
            // 
            this.ColBonificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColBonificacion.HeaderText = "%Bonif.";
            this.ColBonificacion.Name = "ColBonificacion";
            this.ColBonificacion.ReadOnly = true;
            this.ColBonificacion.Width = 50;
            // 
            // ColImporteBonif
            // 
            this.ColImporteBonif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColImporteBonif.HeaderText = "Importe Bonif.";
            this.ColImporteBonif.Name = "ColImporteBonif";
            this.ColImporteBonif.ReadOnly = true;
            // 
            // ColSubtotal
            // 
            this.ColSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColSubtotal.HeaderText = "Subtotal";
            this.ColSubtotal.Name = "ColSubtotal";
            this.ColSubtotal.ReadOnly = true;
            // 
            // ColEliminar
            // 
            this.ColEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEliminar.HeaderText = "Eliminar";
            this.ColEliminar.Name = "ColEliminar";
            this.ColEliminar.ReadOnly = true;
            this.ColEliminar.Text = "Eliminar";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(3, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(3, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(93, 13);
            this.lblProducto.TabIndex = 13;
            this.lblProducto.Text = "Producto/Servicio";
            // 
            // layoutCodigo
            // 
            this.layoutCodigo.Controls.Add(this.lblCodigo);
            this.layoutCodigo.Location = new System.Drawing.Point(12, 58);
            this.layoutCodigo.Name = "layoutCodigo";
            this.layoutCodigo.Size = new System.Drawing.Size(50, 16);
            this.layoutCodigo.TabIndex = 14;
            // 
            // layoutProducto
            // 
            this.layoutProducto.Controls.Add(this.lblProducto);
            this.layoutProducto.Location = new System.Drawing.Point(68, 58);
            this.layoutProducto.Name = "layoutProducto";
            this.layoutProducto.Size = new System.Drawing.Size(200, 16);
            this.layoutProducto.TabIndex = 15;
            // 
            // layoutCantidad
            // 
            this.layoutCantidad.Controls.Add(this.lblCantidad);
            this.layoutCantidad.Location = new System.Drawing.Point(274, 58);
            this.layoutCantidad.Name = "layoutCantidad";
            this.layoutCantidad.Size = new System.Drawing.Size(50, 16);
            this.layoutCantidad.TabIndex = 15;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(3, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(32, 13);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cant.";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutUnMedida
            // 
            this.layoutUnMedida.Controls.Add(this.lblUnMedida);
            this.layoutUnMedida.Location = new System.Drawing.Point(330, 58);
            this.layoutUnMedida.Name = "layoutUnMedida";
            this.layoutUnMedida.Size = new System.Drawing.Size(121, 16);
            this.layoutUnMedida.TabIndex = 16;
            // 
            // lblUnMedida
            // 
            this.lblUnMedida.AutoSize = true;
            this.lblUnMedida.Location = new System.Drawing.Point(3, 0);
            this.lblUnMedida.Name = "lblUnMedida";
            this.lblUnMedida.Size = new System.Drawing.Size(62, 13);
            this.lblUnMedida.TabIndex = 12;
            this.lblUnMedida.Text = "Un. Medida";
            this.lblUnMedida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutPrecio
            // 
            this.layoutPrecio.Controls.Add(this.lblPrecio);
            this.layoutPrecio.Location = new System.Drawing.Point(457, 58);
            this.layoutPrecio.Name = "layoutPrecio";
            this.layoutPrecio.Size = new System.Drawing.Size(90, 16);
            this.layoutPrecio.TabIndex = 17;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(3, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(62, 13);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio Unit.";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutBonif
            // 
            this.layoutBonif.Controls.Add(this.lblBonificacion);
            this.layoutBonif.Location = new System.Drawing.Point(553, 58);
            this.layoutBonif.Name = "layoutBonif";
            this.layoutBonif.Size = new System.Drawing.Size(50, 16);
            this.layoutBonif.TabIndex = 18;
            // 
            // lblBonificacion
            // 
            this.lblBonificacion.AutoSize = true;
            this.lblBonificacion.Location = new System.Drawing.Point(3, 0);
            this.lblBonificacion.Name = "lblBonificacion";
            this.lblBonificacion.Size = new System.Drawing.Size(42, 13);
            this.lblBonificacion.TabIndex = 12;
            this.lblBonificacion.Text = "%Bonif.";
            this.lblBonificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutImpBonif
            // 
            this.layoutImpBonif.Controls.Add(this.lblImporteBonif);
            this.layoutImpBonif.Location = new System.Drawing.Point(609, 58);
            this.layoutImpBonif.Name = "layoutImpBonif";
            this.layoutImpBonif.Size = new System.Drawing.Size(90, 16);
            this.layoutImpBonif.TabIndex = 19;
            // 
            // lblImporteBonif
            // 
            this.lblImporteBonif.AutoSize = true;
            this.lblImporteBonif.Location = new System.Drawing.Point(3, 0);
            this.lblImporteBonif.Name = "lblImporteBonif";
            this.lblImporteBonif.Size = new System.Drawing.Size(72, 13);
            this.lblImporteBonif.TabIndex = 12;
            this.lblImporteBonif.Text = "Importe Bonif.";
            this.lblImporteBonif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutSubtotal
            // 
            this.layoutSubtotal.Controls.Add(this.lblSubtotal);
            this.layoutSubtotal.Location = new System.Drawing.Point(705, 58);
            this.layoutSubtotal.Name = "layoutSubtotal";
            this.layoutSubtotal.Size = new System.Drawing.Size(90, 16);
            this.layoutSubtotal.TabIndex = 20;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(3, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "Subtotal";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 81);
            this.txtCodigo.MaxLength = 9;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(50, 20);
            this.txtCodigo.TabIndex = 22;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(274, 81);
            this.txtCantidad.MaxLength = 9;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(50, 20);
            this.txtCantidad.TabIndex = 23;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // FrmDatosOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.layoutCodigo);
            this.Controls.Add(this.layoutSubtotal);
            this.Controls.Add(this.layoutImpBonif);
            this.Controls.Add(this.layoutBonif);
            this.Controls.Add(this.layoutPrecio);
            this.Controls.Add(this.layoutUnMedida);
            this.Controls.Add(this.layoutCantidad);
            this.Controls.Add(this.layoutProducto);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtImporteBonif);
            this.Controls.Add(this.txtBonif);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cboUnidadMedida);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDatosOperacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de la Operación";
            this.Load += new System.EventHandler(this.FrmDatosOperacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.layoutCodigo.ResumeLayout(false);
            this.layoutCodigo.PerformLayout();
            this.layoutProducto.ResumeLayout(false);
            this.layoutProducto.PerformLayout();
            this.layoutCantidad.ResumeLayout(false);
            this.layoutCantidad.PerformLayout();
            this.layoutUnMedida.ResumeLayout(false);
            this.layoutUnMedida.PerformLayout();
            this.layoutPrecio.ResumeLayout(false);
            this.layoutPrecio.PerformLayout();
            this.layoutBonif.ResumeLayout(false);
            this.layoutBonif.PerformLayout();
            this.layoutImpBonif.ResumeLayout(false);
            this.layoutImpBonif.PerformLayout();
            this.layoutSubtotal.ResumeLayout(false);
            this.layoutSubtotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboUnidadMedida;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtBonif;
        private System.Windows.Forms.TextBox txtImporteBonif;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.FlowLayoutPanel layoutCodigo;
        private System.Windows.Forms.FlowLayoutPanel layoutProducto;
        private System.Windows.Forms.FlowLayoutPanel layoutCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.FlowLayoutPanel layoutUnMedida;
        private System.Windows.Forms.Label lblUnMedida;
        private System.Windows.Forms.FlowLayoutPanel layoutPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.FlowLayoutPanel layoutBonif;
        private System.Windows.Forms.Label lblBonificacion;
        private System.Windows.Forms.FlowLayoutPanel layoutImpBonif;
        private System.Windows.Forms.Label lblImporteBonif;
        private System.Windows.Forms.FlowLayoutPanel layoutSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBonificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImporteBonif;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubtotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColEliminar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}