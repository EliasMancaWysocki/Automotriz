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
            this.txtImporteBonif = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
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
            this.cboAutoplan = new System.Windows.Forms.ComboBox();
            this.lblAutoplan = new System.Windows.Forms.Label();
            this.lblSubtotal2 = new System.Windows.Forms.Label();
            this.cboDescuentos = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTipProd = new System.Windows.Forms.Label();
            this.cboTipoProd = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalImp = new System.Windows.Forms.Label();
            this.lblSubtotalImp = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblOtrosImportes = new System.Windows.Forms.Label();
            this.lblOtrosImp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.layoutCodigo.SuspendLayout();
            this.layoutProducto.SuspendLayout();
            this.layoutCantidad.SuspendLayout();
            this.layoutUnMedida.SuspendLayout();
            this.layoutPrecio.SuspendLayout();
            this.layoutBonif.SuspendLayout();
            this.layoutImpBonif.SuspendLayout();
            this.layoutSubtotal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(536, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(60, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "label1";
            // 
            // cboUnidadMedida
            // 
            this.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadMedida.Enabled = false;
            this.cboUnidadMedida.FormattingEnabled = true;
            this.cboUnidadMedida.ItemHeight = 16;
            this.cboUnidadMedida.Location = new System.Drawing.Point(440, 98);
            this.cboUnidadMedida.Margin = new System.Windows.Forms.Padding(4);
            this.cboUnidadMedida.Name = "cboUnidadMedida";
            this.cboUnidadMedida.Size = new System.Drawing.Size(160, 24);
            this.cboUnidadMedida.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(609, 98);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(119, 22);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // txtImporteBonif
            // 
            this.txtImporteBonif.Enabled = false;
            this.txtImporteBonif.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtImporteBonif.Location = new System.Drawing.Point(812, 98);
            this.txtImporteBonif.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporteBonif.Name = "txtImporteBonif";
            this.txtImporteBonif.Size = new System.Drawing.Size(119, 22);
            this.txtImporteBonif.TabIndex = 8;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(940, 98);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(119, 22);
            this.txtSubtotal.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1068, 96);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.ItemHeight = 16;
            this.cboProducto.Location = new System.Drawing.Point(91, 98);
            this.cboProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(265, 24);
            this.cboProducto.TabIndex = 3;
            this.cboProducto.SelectionChangeCommitted += new System.EventHandler(this.cboProducto_SelectionChangeCommitted);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AllowUserToResizeColumns = false;
            this.dgvDetalles.AllowUserToResizeRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColProducto,
            this.ColCantidad,
            this.ColUnidadMedida,
            this.ColPrecio,
            this.ColBonificacion,
            this.ColImporteBonif,
            this.ColSubtotal,
            this.ColEliminar});
            this.dgvDetalles.Location = new System.Drawing.Point(16, 132);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalles.MultiSelect = false;
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersVisible = false;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.ShowCellErrors = false;
            this.dgvDetalles.ShowCellToolTips = false;
            this.dgvDetalles.ShowEditingIcon = false;
            this.dgvDetalles.ShowRowErrors = false;
            this.dgvDetalles.Size = new System.Drawing.Size(1152, 308);
            this.dgvDetalles.TabIndex = 11;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // ColCodigo
            // 
            this.ColCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.MinimumWidth = 6;
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCodigo.Width = 50;
            // 
            // ColProducto
            // 
            this.ColProducto.HeaderText = "Producto/Servicio";
            this.ColProducto.MinimumWidth = 6;
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.ReadOnly = true;
            this.ColProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColProducto.Width = 210;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cant.";
            this.ColCantidad.MinimumWidth = 6;
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            this.ColCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCantidad.Width = 50;
            // 
            // ColUnidadMedida
            // 
            this.ColUnidadMedida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColUnidadMedida.HeaderText = "Un. Medida";
            this.ColUnidadMedida.MinimumWidth = 6;
            this.ColUnidadMedida.Name = "ColUnidadMedida";
            this.ColUnidadMedida.ReadOnly = true;
            this.ColUnidadMedida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColUnidadMedida.Width = 130;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio Unit.";
            this.ColPrecio.MinimumWidth = 6;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColPrecio.Width = 125;
            // 
            // ColBonificacion
            // 
            this.ColBonificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColBonificacion.HeaderText = "%Bonif.";
            this.ColBonificacion.MinimumWidth = 6;
            this.ColBonificacion.Name = "ColBonificacion";
            this.ColBonificacion.ReadOnly = true;
            this.ColBonificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColBonificacion.Width = 50;
            // 
            // ColImporteBonif
            // 
            this.ColImporteBonif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColImporteBonif.HeaderText = "Importe Bonif.";
            this.ColImporteBonif.MinimumWidth = 6;
            this.ColImporteBonif.Name = "ColImporteBonif";
            this.ColImporteBonif.ReadOnly = true;
            this.ColImporteBonif.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColImporteBonif.Width = 125;
            // 
            // ColSubtotal
            // 
            this.ColSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColSubtotal.HeaderText = "Subtotal";
            this.ColSubtotal.MinimumWidth = 6;
            this.ColSubtotal.Name = "ColSubtotal";
            this.ColSubtotal.ReadOnly = true;
            this.ColSubtotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColSubtotal.Width = 125;
            // 
            // ColEliminar
            // 
            this.ColEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEliminar.HeaderText = "Eliminar";
            this.ColEliminar.MinimumWidth = 6;
            this.ColEliminar.Name = "ColEliminar";
            this.ColEliminar.ReadOnly = true;
            this.ColEliminar.Text = "Eliminar";
            this.ColEliminar.UseColumnTextForButtonValue = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(4, 0);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(4, 0);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(114, 16);
            this.lblProducto.TabIndex = 13;
            this.lblProducto.Text = "Producto/Servicio";
            // 
            // layoutCodigo
            // 
            this.layoutCodigo.BackColor = System.Drawing.Color.Transparent;
            this.layoutCodigo.Controls.Add(this.lblCodigo);
            this.layoutCodigo.Location = new System.Drawing.Point(16, 71);
            this.layoutCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.layoutCodigo.Name = "layoutCodigo";
            this.layoutCodigo.Size = new System.Drawing.Size(67, 20);
            this.layoutCodigo.TabIndex = 14;
            // 
            // layoutProducto
            // 
            this.layoutProducto.BackColor = System.Drawing.Color.Transparent;
            this.layoutProducto.Controls.Add(this.lblProducto);
            this.layoutProducto.Location = new System.Drawing.Point(91, 71);
            this.layoutProducto.Margin = new System.Windows.Forms.Padding(4);
            this.layoutProducto.Name = "layoutProducto";
            this.layoutProducto.Size = new System.Drawing.Size(267, 20);
            this.layoutProducto.TabIndex = 15;
            // 
            // layoutCantidad
            // 
            this.layoutCantidad.BackColor = System.Drawing.Color.Transparent;
            this.layoutCantidad.Controls.Add(this.lblCantidad);
            this.layoutCantidad.Location = new System.Drawing.Point(365, 71);
            this.layoutCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.layoutCantidad.Name = "layoutCantidad";
            this.layoutCantidad.Size = new System.Drawing.Size(67, 20);
            this.layoutCantidad.TabIndex = 15;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(4, 0);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(37, 16);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cant.";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutUnMedida
            // 
            this.layoutUnMedida.BackColor = System.Drawing.Color.Transparent;
            this.layoutUnMedida.Controls.Add(this.lblUnMedida);
            this.layoutUnMedida.Location = new System.Drawing.Point(440, 71);
            this.layoutUnMedida.Margin = new System.Windows.Forms.Padding(4);
            this.layoutUnMedida.Name = "layoutUnMedida";
            this.layoutUnMedida.Size = new System.Drawing.Size(161, 20);
            this.layoutUnMedida.TabIndex = 16;
            // 
            // lblUnMedida
            // 
            this.lblUnMedida.AutoSize = true;
            this.lblUnMedida.Location = new System.Drawing.Point(4, 0);
            this.lblUnMedida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnMedida.Name = "lblUnMedida";
            this.lblUnMedida.Size = new System.Drawing.Size(76, 16);
            this.lblUnMedida.TabIndex = 12;
            this.lblUnMedida.Text = "Un. Medida";
            this.lblUnMedida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutPrecio
            // 
            this.layoutPrecio.BackColor = System.Drawing.Color.Transparent;
            this.layoutPrecio.Controls.Add(this.lblPrecio);
            this.layoutPrecio.Location = new System.Drawing.Point(609, 71);
            this.layoutPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.layoutPrecio.Name = "layoutPrecio";
            this.layoutPrecio.Size = new System.Drawing.Size(120, 20);
            this.layoutPrecio.TabIndex = 17;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(4, 0);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(75, 16);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio Unit.";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutBonif
            // 
            this.layoutBonif.BackColor = System.Drawing.Color.Transparent;
            this.layoutBonif.Controls.Add(this.lblBonificacion);
            this.layoutBonif.Location = new System.Drawing.Point(737, 71);
            this.layoutBonif.Margin = new System.Windows.Forms.Padding(4);
            this.layoutBonif.Name = "layoutBonif";
            this.layoutBonif.Size = new System.Drawing.Size(67, 20);
            this.layoutBonif.TabIndex = 18;
            // 
            // lblBonificacion
            // 
            this.lblBonificacion.AutoSize = true;
            this.lblBonificacion.Location = new System.Drawing.Point(4, 0);
            this.lblBonificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBonificacion.Name = "lblBonificacion";
            this.lblBonificacion.Size = new System.Drawing.Size(52, 16);
            this.lblBonificacion.TabIndex = 12;
            this.lblBonificacion.Text = "%Bonif.";
            this.lblBonificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutImpBonif
            // 
            this.layoutImpBonif.BackColor = System.Drawing.Color.Transparent;
            this.layoutImpBonif.Controls.Add(this.lblImporteBonif);
            this.layoutImpBonif.Location = new System.Drawing.Point(812, 71);
            this.layoutImpBonif.Margin = new System.Windows.Forms.Padding(4);
            this.layoutImpBonif.Name = "layoutImpBonif";
            this.layoutImpBonif.Size = new System.Drawing.Size(120, 20);
            this.layoutImpBonif.TabIndex = 19;
            // 
            // lblImporteBonif
            // 
            this.lblImporteBonif.AutoSize = true;
            this.lblImporteBonif.Location = new System.Drawing.Point(4, 0);
            this.lblImporteBonif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImporteBonif.Name = "lblImporteBonif";
            this.lblImporteBonif.Size = new System.Drawing.Size(88, 16);
            this.lblImporteBonif.TabIndex = 12;
            this.lblImporteBonif.Text = "Importe Bonif.";
            this.lblImporteBonif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutSubtotal
            // 
            this.layoutSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.layoutSubtotal.Controls.Add(this.lblSubtotal);
            this.layoutSubtotal.Location = new System.Drawing.Point(940, 71);
            this.layoutSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.layoutSubtotal.Name = "layoutSubtotal";
            this.layoutSubtotal.Size = new System.Drawing.Size(120, 20);
            this.layoutSubtotal.TabIndex = 20;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(4, 0);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(56, 16);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "Subtotal";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(16, 100);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.MaxLength = 9;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(65, 22);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(365, 100);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.MaxLength = 9;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(65, 22);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // cboAutoplan
            // 
            this.cboAutoplan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutoplan.FormattingEnabled = true;
            this.cboAutoplan.Location = new System.Drawing.Point(151, 447);
            this.cboAutoplan.Margin = new System.Windows.Forms.Padding(4);
            this.cboAutoplan.Name = "cboAutoplan";
            this.cboAutoplan.Size = new System.Drawing.Size(160, 24);
            this.cboAutoplan.TabIndex = 12;
            this.cboAutoplan.Visible = false;
            // 
            // lblAutoplan
            // 
            this.lblAutoplan.AutoSize = true;
            this.lblAutoplan.BackColor = System.Drawing.Color.Transparent;
            this.lblAutoplan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoplan.Location = new System.Drawing.Point(16, 449);
            this.lblAutoplan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutoplan.Name = "lblAutoplan";
            this.lblAutoplan.Size = new System.Drawing.Size(120, 23);
            this.lblAutoplan.TabIndex = 26;
            this.lblAutoplan.Text = "AUTOPLAN";
            this.lblAutoplan.Visible = false;
            // 
            // lblSubtotal2
            // 
            this.lblSubtotal2.AutoSize = true;
            this.lblSubtotal2.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal2.Location = new System.Drawing.Point(832, 449);
            this.lblSubtotal2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal2.Name = "lblSubtotal2";
            this.lblSubtotal2.Size = new System.Drawing.Size(130, 23);
            this.lblSubtotal2.TabIndex = 27;
            this.lblSubtotal2.Text = "SUBTOTAL $";
            // 
            // cboDescuentos
            // 
            this.cboDescuentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDescuentos.Enabled = false;
            this.cboDescuentos.FormattingEnabled = true;
            this.cboDescuentos.ItemHeight = 16;
            this.cboDescuentos.Location = new System.Drawing.Point(737, 98);
            this.cboDescuentos.Margin = new System.Windows.Forms.Padding(4);
            this.cboDescuentos.Name = "cboDescuentos";
            this.cboDescuentos.Size = new System.Drawing.Size(65, 24);
            this.cboDescuentos.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(873, 535);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 23);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "TOTAL $";
            // 
            // lblTipProd
            // 
            this.lblTipProd.AutoSize = true;
            this.lblTipProd.Location = new System.Drawing.Point(12, 39);
            this.lblTipProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipProd.Name = "lblTipProd";
            this.lblTipProd.Size = new System.Drawing.Size(111, 16);
            this.lblTipProd.TabIndex = 35;
            this.lblTipProd.Text = "Tipo de Producto";
            this.lblTipProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboTipoProd
            // 
            this.cboTipoProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoProd.FormattingEnabled = true;
            this.cboTipoProd.Location = new System.Drawing.Point(139, 36);
            this.cboTipoProd.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoProd.Name = "cboTipoProd";
            this.cboTipoProd.Size = new System.Drawing.Size(217, 24);
            this.cboTipoProd.TabIndex = 1;
            this.cboTipoProd.SelectionChangeCommitted += new System.EventHandler(this.cboTipoProd_SelectionChangeCommitted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalImp);
            this.panel1.Controls.Add(this.lblOtrosImp);
            this.panel1.Controls.Add(this.lblSubtotalImp);
            this.panel1.Location = new System.Drawing.Point(979, 449);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 110);
            this.panel1.TabIndex = 37;
            // 
            // lblTotalImp
            // 
            this.lblTotalImp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalImp.AutoSize = true;
            this.lblTotalImp.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalImp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalImp.Location = new System.Drawing.Point(4, 86);
            this.lblTotalImp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalImp.Name = "lblTotalImp";
            this.lblTotalImp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalImp.Size = new System.Drawing.Size(170, 23);
            this.lblTotalImp.TabIndex = 37;
            this.lblTotalImp.Text = "100.000.000.000,00";
            this.lblTotalImp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSubtotalImp
            // 
            this.lblSubtotalImp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotalImp.AutoSize = true;
            this.lblSubtotalImp.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotalImp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalImp.Location = new System.Drawing.Point(4, 0);
            this.lblSubtotalImp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotalImp.Name = "lblSubtotalImp";
            this.lblSubtotalImp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSubtotalImp.Size = new System.Drawing.Size(170, 23);
            this.lblSubtotalImp.TabIndex = 35;
            this.lblSubtotalImp.Text = "100.000.000.000,00";
            this.lblSubtotalImp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(617, 587);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(120, 37);
            this.btnImprimir.TabIndex = 13;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(441, 587);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 37);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblOtrosImportes
            // 
            this.lblOtrosImportes.AutoSize = true;
            this.lblOtrosImportes.BackColor = System.Drawing.Color.Transparent;
            this.lblOtrosImportes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtrosImportes.Location = new System.Drawing.Point(651, 492);
            this.lblOtrosImportes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOtrosImportes.Name = "lblOtrosImportes";
            this.lblOtrosImportes.Size = new System.Drawing.Size(298, 23);
            this.lblOtrosImportes.TabIndex = 29;
            this.lblOtrosImportes.Text = "IMPORTE OTROS TRIBUTOS $";
            // 
            // lblOtrosImp
            // 
            this.lblOtrosImp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOtrosImp.AutoSize = true;
            this.lblOtrosImp.BackColor = System.Drawing.Color.Transparent;
            this.lblOtrosImp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtrosImp.Location = new System.Drawing.Point(4, 43);
            this.lblOtrosImp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOtrosImp.Name = "lblOtrosImp";
            this.lblOtrosImp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOtrosImp.Size = new System.Drawing.Size(170, 23);
            this.lblOtrosImp.TabIndex = 36;
            this.lblOtrosImp.Text = "100.000.000.000,00";
            this.lblOtrosImp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmDatosOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1192, 656);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboTipoProd);
            this.Controls.Add(this.lblTipProd);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cboDescuentos);
            this.Controls.Add(this.lblOtrosImportes);
            this.Controls.Add(this.lblSubtotal2);
            this.Controls.Add(this.lblAutoplan);
            this.Controls.Add(this.cboAutoplan);
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
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtImporteBonif);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cboUnidadMedida);
            this.Controls.Add(this.lblTitulo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDatosOperacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de la Operación";
            this.Load += new System.EventHandler(this.FrmDatosOperacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboUnidadMedida;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtImporteBonif;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.DataGridView dgvDetalles;
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
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBonificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImporteBonif;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubtotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColEliminar;
        private System.Windows.Forms.ComboBox cboAutoplan;
        private System.Windows.Forms.Label lblAutoplan;
        private System.Windows.Forms.Label lblSubtotal2;
        private System.Windows.Forms.ComboBox cboDescuentos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTipProd;
        private System.Windows.Forms.ComboBox cboTipoProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalImp;
        private System.Windows.Forms.Label lblSubtotalImp;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblOtrosImp;
        private System.Windows.Forms.Label lblOtrosImportes;
    }
}