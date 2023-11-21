namespace AutomotrizFront.Presentación.Comprobantes.Consulta_Comprobantes
{
    partial class FrmReporteComprobante
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteComprobante));
            this.sPREPORTECOMPROBANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSComprobante = new AutomotrizFront.Presentación.Comprobantes.Consulta_Comprobantes.Reporte.DSComprobante();
            this.rvComprobante = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_REPORTE_COMPROBANTETableAdapter = new AutomotrizFront.Presentación.Comprobantes.Consulta_Comprobantes.Reporte.DSComprobanteTableAdapters.SP_REPORTE_COMPROBANTETableAdapter();
            this.sPDATOSFACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DATOS_FACTURATableAdapter = new AutomotrizFront.Presentación.Comprobantes.Consulta_Comprobantes.Reporte.DSComprobanteTableAdapters.SP_DATOS_FACTURATableAdapter();
            this.SP_REPORTE_COMPROBANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_DATOS_FACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automotrizDataSet3 = new AutomotrizFront.AutomotrizDataSet3();
            this.sPTIPOCOMPROBANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_TIPO_COMPROBANTETableAdapter = new AutomotrizFront.AutomotrizDataSet3TableAdapters.SP_TIPO_COMPROBANTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTECOMPROBANTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDATOSFACTURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_COMPROBANTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_FACTURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotrizDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPTIPOCOMPROBANTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sPREPORTECOMPROBANTEBindingSource
            // 
            this.sPREPORTECOMPROBANTEBindingSource.DataMember = "SP_REPORTE_COMPROBANTE";
            this.sPREPORTECOMPROBANTEBindingSource.DataSource = this.dSComprobante;
            // 
            // dSComprobante
            // 
            this.dSComprobante.DataSetName = "DSComprobante";
            this.dSComprobante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvComprobante
            // 
            this.rvComprobante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rvComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvComprobante.IsDocumentMapWidthFixed = true;
            reportDataSource1.Name = "TipoComprobante";
            reportDataSource1.Value = this.sPTIPOCOMPROBANTEBindingSource;
            this.rvComprobante.LocalReport.DataSources.Add(reportDataSource1);
            this.rvComprobante.LocalReport.ReportEmbeddedResource = "AutomotrizFront.Presentación.Comprobantes.Consulta Comprobantes.Reporte.RptCompro" +
    "bante.rdlc";
            this.rvComprobante.Location = new System.Drawing.Point(0, 0);
            this.rvComprobante.Name = "rvComprobante";
            this.rvComprobante.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.rvComprobante.ServerReport.BearerToken = null;
            this.rvComprobante.Size = new System.Drawing.Size(781, 467);
            this.rvComprobante.TabIndex = 0;
            // 
            // sP_REPORTE_COMPROBANTETableAdapter
            // 
            this.sP_REPORTE_COMPROBANTETableAdapter.ClearBeforeFill = true;
            // 
            // sPDATOSFACTURABindingSource
            // 
            this.sPDATOSFACTURABindingSource.DataMember = "SP_DATOS_FACTURA";
            this.sPDATOSFACTURABindingSource.DataSource = this.dSComprobante;
            // 
            // sP_DATOS_FACTURATableAdapter
            // 
            this.sP_DATOS_FACTURATableAdapter.ClearBeforeFill = true;
            // 
            // SP_REPORTE_COMPROBANTEBindingSource
            // 
            this.SP_REPORTE_COMPROBANTEBindingSource.DataMember = "SP_REPORTE_COMPROBANTE";
            this.SP_REPORTE_COMPROBANTEBindingSource.DataSource = this.dSComprobante;
            // 
            // SP_DATOS_FACTURABindingSource
            // 
            this.SP_DATOS_FACTURABindingSource.DataMember = "SP_DATOS_FACTURA";
            this.SP_DATOS_FACTURABindingSource.DataSource = this.dSComprobante;
            // 
            // automotrizDataSet3
            // 
            this.automotrizDataSet3.DataSetName = "AutomotrizDataSet3";
            this.automotrizDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPTIPOCOMPROBANTEBindingSource
            // 
            this.sPTIPOCOMPROBANTEBindingSource.DataMember = "SP_TIPO_COMPROBANTE";
            this.sPTIPOCOMPROBANTEBindingSource.DataSource = this.automotrizDataSet3;
            // 
            // sP_TIPO_COMPROBANTETableAdapter
            // 
            this.sP_TIPO_COMPROBANTETableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteComprobante
            // 
            this.ClientSize = new System.Drawing.Size(781, 467);
            this.Controls.Add(this.rvComprobante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteComprobante_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTECOMPROBANTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDATOSFACTURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTE_COMPROBANTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_DATOS_FACTURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automotrizDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPTIPOCOMPROBANTEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvComprobante;
        private System.Windows.Forms.BindingSource sPREPORTECOMPROBANTEBindingSource;
        private Reporte.DSComprobante dSComprobante;
        private Reporte.DSComprobanteTableAdapters.SP_REPORTE_COMPROBANTETableAdapter sP_REPORTE_COMPROBANTETableAdapter;
        private System.Windows.Forms.BindingSource sPDATOSFACTURABindingSource;
        private Reporte.DSComprobanteTableAdapters.SP_DATOS_FACTURATableAdapter sP_DATOS_FACTURATableAdapter;
        private System.Windows.Forms.BindingSource SP_REPORTE_COMPROBANTEBindingSource;
        private System.Windows.Forms.BindingSource SP_DATOS_FACTURABindingSource;
        private System.Windows.Forms.BindingSource sPTIPOCOMPROBANTEBindingSource;
        private AutomotrizDataSet3 automotrizDataSet3;
        private AutomotrizDataSet3TableAdapters.SP_TIPO_COMPROBANTETableAdapter sP_TIPO_COMPROBANTETableAdapter;
    }
}