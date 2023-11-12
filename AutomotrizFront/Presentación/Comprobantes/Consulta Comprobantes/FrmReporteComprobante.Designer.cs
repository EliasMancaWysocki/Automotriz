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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSComprobante = new AutomotrizFront.Presentación.Comprobantes.Consulta_Comprobantes.Reporte.DSComprobante();
            this.sPREPORTECOMPROBANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_REPORTE_COMPROBANTETableAdapter = new AutomotrizFront.Presentación.Comprobantes.Consulta_Comprobantes.Reporte.DSComprobanteTableAdapters.SP_REPORTE_COMPROBANTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTECOMPROBANTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sPREPORTECOMPROBANTEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AutomotrizFront.Presentación.Comprobantes.Consulta Comprobantes.Reporte.RptCompro" +
    "bante.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(960, 424);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSComprobante
            // 
            this.dSComprobante.DataSetName = "DSComprobante";
            this.dSComprobante.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPREPORTECOMPROBANTEBindingSource
            // 
            this.sPREPORTECOMPROBANTEBindingSource.DataMember = "SP_REPORTE_COMPROBANTE";
            this.sPREPORTECOMPROBANTEBindingSource.DataSource = this.dSComprobante;
            // 
            // sP_REPORTE_COMPROBANTETableAdapter
            // 
            this.sP_REPORTE_COMPROBANTETableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteComprobante
            // 
            this.ClientSize = new System.Drawing.Size(960, 424);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteComprobante";
            this.Load += new System.EventHandler(this.FrmReporteComprobante_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dSComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTECOMPROBANTEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sPREPORTECOMPROBANTEBindingSource;
        private Reporte.DSComprobante dSComprobante;
        private Reporte.DSComprobanteTableAdapters.SP_REPORTE_COMPROBANTETableAdapter sP_REPORTE_COMPROBANTETableAdapter;
    }
}