
using System.Windows.Forms;

namespace AutomotrizFront.Presentación.Soporte
{
    partial class FrmActualizarCliente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizarCliente));
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.dgvListacl = new System.Windows.Forms.DataGridView();
            this.NroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicionIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mostrarClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automotrizDataSet2 = new AutomotrizFront.AutomotrizDataSet2();
            this.gbBotones = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbboxCampos = new System.Windows.Forms.GroupBox();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.cboCIva = new System.Windows.Forms.ComboBox();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.cboBarrios = new System.Windows.Forms.ComboBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.cboTCliente = new System.Windows.Forms.ComboBox();
            this.lbltipoCliente = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automotrizDataSet = new AutomotrizFront.AutomotrizDataSet();
            this.clientesTableAdapter = new AutomotrizFront.AutomotrizDataSetTableAdapters.ClientesTableAdapter();
            this.automotrizDataSet1 = new AutomotrizFront.AutomotrizDataSet1();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter1 = new AutomotrizFront.AutomotrizDataSet1TableAdapters.ClientesTableAdapter();
            this.mostrar_ClienteTableAdapter = new AutomotrizFront.AutomotrizDataSet2TableAdapters.Mostrar_ClienteTableAdapter();
            this.gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListacl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotrizDataSet2)).BeginInit();
            this.gbBotones.SuspendLayout();
            this.gbboxCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotrizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotrizDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.dgvListacl);
            this.gbClientes.Location = new System.Drawing.Point(12, 12);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(958, 240);
            this.gbClientes.TabIndex = 0;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "LISTA CLIENTES";
            // 
            // dgvListacl
            // 
            this.dgvListacl.AllowUserToAddRows = false;
            this.dgvListacl.AllowUserToDeleteRows = false;
            this.dgvListacl.AllowUserToResizeColumns = false;
            this.dgvListacl.AllowUserToResizeRows = false;
            this.dgvListacl.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListacl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListacl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListacl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroCliente,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.calleDataGridViewTextBoxColumn,
            this.alturaDataGridViewTextBoxColumn,
            this.barrioDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.tipoDocumentoDataGridViewTextBoxColumn,
            this.tipoClienteDataGridViewTextBoxColumn,
            this.condicionIVADataGridViewTextBoxColumn,
            this.Seleccionar});
            this.dgvListacl.DataSource = this.mostrarClienteBindingSource;
            this.dgvListacl.Location = new System.Drawing.Point(6, 19);
            this.dgvListacl.MultiSelect = false;
            this.dgvListacl.Name = "dgvListacl";
            this.dgvListacl.ReadOnly = true;
            this.dgvListacl.RowHeadersVisible = false;
            this.dgvListacl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvListacl.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListacl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListacl.Size = new System.Drawing.Size(946, 215);
            this.dgvListacl.TabIndex = 0;
            this.dgvListacl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListacl_CellContentClick);
            // 
            // NroCliente
            // 
            this.NroCliente.DataPropertyName = "Nro Cliente";
            this.NroCliente.HeaderText = "NroCliente";
            this.NroCliente.Name = "NroCliente";
            this.NroCliente.ReadOnly = true;
            this.NroCliente.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nombreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 69;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.apellidoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 69;
            // 
            // calleDataGridViewTextBoxColumn
            // 
            this.calleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.calleDataGridViewTextBoxColumn.DataPropertyName = "Calle";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.calleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.calleDataGridViewTextBoxColumn.HeaderText = "Calle";
            this.calleDataGridViewTextBoxColumn.Name = "calleDataGridViewTextBoxColumn";
            this.calleDataGridViewTextBoxColumn.ReadOnly = true;
            this.calleDataGridViewTextBoxColumn.Width = 55;
            // 
            // alturaDataGridViewTextBoxColumn
            // 
            this.alturaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.alturaDataGridViewTextBoxColumn.DataPropertyName = "Altura";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.alturaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.alturaDataGridViewTextBoxColumn.HeaderText = "Altura";
            this.alturaDataGridViewTextBoxColumn.Name = "alturaDataGridViewTextBoxColumn";
            this.alturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.alturaDataGridViewTextBoxColumn.Width = 59;
            // 
            // barrioDataGridViewTextBoxColumn
            // 
            this.barrioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.barrioDataGridViewTextBoxColumn.DataPropertyName = "Barrio";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.barrioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.barrioDataGridViewTextBoxColumn.HeaderText = "Barrio";
            this.barrioDataGridViewTextBoxColumn.Name = "barrioDataGridViewTextBoxColumn";
            this.barrioDataGridViewTextBoxColumn.ReadOnly = true;
            this.barrioDataGridViewTextBoxColumn.Width = 59;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.documentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentoDataGridViewTextBoxColumn.Width = 87;
            // 
            // tipoDocumentoDataGridViewTextBoxColumn
            // 
            this.tipoDocumentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "Tipo Documento";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tipoDocumentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.tipoDocumentoDataGridViewTextBoxColumn.HeaderText = "Tipo Documento";
            this.tipoDocumentoDataGridViewTextBoxColumn.Name = "tipoDocumentoDataGridViewTextBoxColumn";
            this.tipoDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDocumentoDataGridViewTextBoxColumn.Width = 102;
            // 
            // tipoClienteDataGridViewTextBoxColumn
            // 
            this.tipoClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipoClienteDataGridViewTextBoxColumn.DataPropertyName = "Tipo Cliente";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tipoClienteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.tipoClienteDataGridViewTextBoxColumn.HeaderText = "Tipo Cliente";
            this.tipoClienteDataGridViewTextBoxColumn.Name = "tipoClienteDataGridViewTextBoxColumn";
            this.tipoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoClienteDataGridViewTextBoxColumn.Width = 81;
            // 
            // condicionIVADataGridViewTextBoxColumn
            // 
            this.condicionIVADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.condicionIVADataGridViewTextBoxColumn.DataPropertyName = "Condicion IVA";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.condicionIVADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.condicionIVADataGridViewTextBoxColumn.HeaderText = "Condicion IVA";
            this.condicionIVADataGridViewTextBoxColumn.Name = "condicionIVADataGridViewTextBoxColumn";
            this.condicionIVADataGridViewTextBoxColumn.ReadOnly = true;
            this.condicionIVADataGridViewTextBoxColumn.Width = 91;
            // 
            // Seleccionar
            // 
            this.Seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Seleccionar.HeaderText = "Ver";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Text = "Ver";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // mostrarClienteBindingSource
            // 
            this.mostrarClienteBindingSource.DataMember = "Mostrar_Cliente";
            this.mostrarClienteBindingSource.DataSource = this.automotrizDataSet2;
            // 
            // automotrizDataSet2
            // 
            this.automotrizDataSet2.DataSetName = "AutomotrizDataSet2";
            this.automotrizDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbBotones
            // 
            this.gbBotones.BackColor = System.Drawing.Color.Transparent;
            this.gbBotones.Controls.Add(this.btnCancelar);
            this.gbBotones.Controls.Add(this.btnModificar);
            this.gbBotones.Controls.Add(this.btnSalir);
            this.gbBotones.Controls.Add(this.btnNuevo);
            this.gbBotones.Location = new System.Drawing.Point(15, 447);
            this.gbBotones.Name = "gbBotones";
            this.gbBotones.Size = new System.Drawing.Size(882, 68);
            this.gbBotones.TabIndex = 1;
            this.gbBotones.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(248, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(506, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 30);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(791, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 30);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(7, 20);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 30);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbboxCampos
            // 
            this.gbboxCampos.BackColor = System.Drawing.Color.Transparent;
            this.gbboxCampos.Controls.Add(this.lblCondicion);
            this.gbboxCampos.Controls.Add(this.cboCIva);
            this.gbboxCampos.Controls.Add(this.cboTipoDoc);
            this.gbboxCampos.Controls.Add(this.label3);
            this.gbboxCampos.Controls.Add(this.txtDocumento);
            this.gbboxCampos.Controls.Add(this.lblDocumento);
            this.gbboxCampos.Controls.Add(this.cboBarrios);
            this.gbboxCampos.Controls.Add(this.lblBarrio);
            this.gbboxCampos.Controls.Add(this.lblApellido);
            this.gbboxCampos.Controls.Add(this.lblnom);
            this.gbboxCampos.Controls.Add(this.cboTCliente);
            this.gbboxCampos.Controls.Add(this.lbltipoCliente);
            this.gbboxCampos.Controls.Add(this.txtAltura);
            this.gbboxCampos.Controls.Add(this.label2);
            this.gbboxCampos.Controls.Add(this.txtCalle);
            this.gbboxCampos.Controls.Add(this.lblCalle);
            this.gbboxCampos.Controls.Add(this.txtApellido);
            this.gbboxCampos.Controls.Add(this.txtNombre);
            this.gbboxCampos.Controls.Add(this.lblIdCliente);
            this.gbboxCampos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbboxCampos.Location = new System.Drawing.Point(15, 258);
            this.gbboxCampos.Name = "gbboxCampos";
            this.gbboxCampos.Size = new System.Drawing.Size(955, 160);
            this.gbboxCampos.TabIndex = 2;
            this.gbboxCampos.TabStop = false;
            this.gbboxCampos.Text = "Datos del Cliente";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(560, 115);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(105, 19);
            this.lblCondicion.TabIndex = 46;
            this.lblCondicion.Text = "Condicion IVA";
            // 
            // cboCIva
            // 
            this.cboCIva.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCIva.FormattingEnabled = true;
            this.cboCIva.Location = new System.Drawing.Point(671, 112);
            this.cboCIva.Name = "cboCIva";
            this.cboCIva.Size = new System.Drawing.Size(193, 27);
            this.cboCIva.TabIndex = 45;
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(671, 82);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(193, 27);
            this.cboTipoDoc.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tipo de Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(671, 52);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(193, 26);
            this.txtDocumento.TabIndex = 42;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(580, 55);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(85, 19);
            this.lblDocumento.TabIndex = 41;
            this.lblDocumento.Text = "Documento";
            // 
            // cboBarrios
            // 
            this.cboBarrios.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBarrios.FormattingEnabled = true;
            this.cboBarrios.Location = new System.Drawing.Point(671, 23);
            this.cboBarrios.Name = "cboBarrios";
            this.cboBarrios.Size = new System.Drawing.Size(193, 27);
            this.cboBarrios.TabIndex = 40;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(613, 25);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(52, 19);
            this.lblBarrio.TabIndex = 39;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(274, 25);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 19);
            this.lblApellido.TabIndex = 38;
            this.lblApellido.Text = "Apellido";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(54, 25);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(63, 19);
            this.lblnom.TabIndex = 37;
            this.lblnom.Text = "Nombre";
            // 
            // cboTCliente
            // 
            this.cboTCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTCliente.FormattingEnabled = true;
            this.cboTCliente.Location = new System.Drawing.Point(136, 82);
            this.cboTCliente.Name = "cboTCliente";
            this.cboTCliente.Size = new System.Drawing.Size(132, 27);
            this.cboTCliente.TabIndex = 36;
            // 
            // lbltipoCliente
            // 
            this.lbltipoCliente.AutoSize = true;
            this.lbltipoCliente.Location = new System.Drawing.Point(6, 85);
            this.lbltipoCliente.Name = "lbltipoCliente";
            this.lbltipoCliente.Size = new System.Drawing.Size(111, 19);
            this.lbltipoCliente.TabIndex = 35;
            this.lbltipoCliente.Text = "Tipo de Cliente";
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(344, 52);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(43, 26);
            this.txtAltura.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Altura";
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(136, 52);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(132, 26);
            this.txtCalle.TabIndex = 32;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(73, 55);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(44, 19);
            this.lblCalle.TabIndex = 31;
            this.lblCalle.Text = "Calle";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(136, 22);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 26);
            this.txtApellido.TabIndex = 30;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(344, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 26);
            this.txtNombre.TabIndex = 29;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(151, 0);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(87, 19);
            this.lblIdCliente.TabIndex = 28;
            this.lblIdCliente.Text = "Nro Cliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.automotrizDataSet;
            // 
            // automotrizDataSet
            // 
            this.automotrizDataSet.DataSetName = "AutomotrizDataSet";
            this.automotrizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // automotrizDataSet1
            // 
            this.automotrizDataSet1.DataSetName = "AutomotrizDataSet1";
            this.automotrizDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.automotrizDataSet1;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // mostrar_ClienteTableAdapter
            // 
            this.mostrar_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmActualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1007, 537);
            this.Controls.Add(this.gbboxCampos);
            this.Controls.Add(this.gbBotones);
            this.Controls.Add(this.gbClientes);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmActualizarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Cliente";
            this.Load += new System.EventHandler(this.FrmActualizarCliente_Load);
            this.gbClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListacl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotrizDataSet2)).EndInit();
            this.gbBotones.ResumeLayout(false);
            this.gbboxCampos.ResumeLayout(false);
            this.gbboxCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotrizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotrizDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClientes;
        private AutomotrizDataSet automotrizDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private AutomotrizDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.GroupBox gbBotones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gbboxCampos;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.ComboBox cboTCliente;
        private System.Windows.Forms.Label lbltipoCliente;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.ComboBox cboBarrios;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.ComboBox cboCIva;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListacl;
        private AutomotrizDataSet1 automotrizDataSet1;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private AutomotrizDataSet1TableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private AutomotrizDataSet2 automotrizDataSet2;
        private System.Windows.Forms.BindingSource mostrarClienteBindingSource;
        private AutomotrizDataSet2TableAdapters.Mostrar_ClienteTableAdapter mostrar_ClienteTableAdapter;
        private System.Windows.Forms.Button btnBorrar;
        private DataGridViewTextBoxColumn NroCliente;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alturaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barrioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn condicionIVADataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Seleccionar;
        private Button btnCancelar;
    }
}