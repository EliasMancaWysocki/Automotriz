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
            this.sPREPORTECOMPROBANTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSComprobante = new AutomotrizFront.Presentación.Comprobantes.Consulta_Comprobantes.Reporte.DSComprobante();
            this.rvComprobante = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_REPORTE_COMPROBANTETableAdapter = new AutomotrizFront.Presentación.Comprobantes.Consulta_Comprobantes.Reporte.DSComprobanteTableAdapters.SP_REPORTE_COMPROBANTETableAdapter();
            this.sPDATOSFACTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DATOS_FACTURATableAdapter = new AutomotrizFront.Presentación.Comprobantes.Consulta_Comprobantes.Reporte.DSComprobanteTableAdapters.SP_DATOS_FACTURATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTECOMPROBANTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDATOSFACTURABindingSource)).BeginInit();
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
            this.rvComprobante.LocalReport.ReportEmbeddedResource = "AutomotrizFront.Presentación.Comprobantes.Consulta Comprobantes.Reporte.RptCompro" +
    "bante.rdlc";
            this.rvComprobante.Location = new System.Drawing.Point(0, 0);
            this.rvComprobante.Name = "rvComprobante";
            this.rvComprobante.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            //this.rvComprobante.ServerReport.BearerToken = null;
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
            // FrmReporteComprobante
            // 
            this.ClientSize = new System.Drawing.Size(781, 467);
            this.Controls.Add(this.rvComprobante);
            this.Name = "FrmReporteComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteComprobante_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTECOMPROBANTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPDATOSFACTURABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvComprobante;
        private System.Windows.Forms.BindingSource sPREPORTECOMPROBANTEBindingSource;
        private Reporte.DSComprobante dSComprobante;
        private Reporte.DSComprobanteTableAdapters.SP_REPORTE_COMPROBANTETableAdapter sP_REPORTE_COMPROBANTETableAdapter;
        private System.Windows.Forms.BindingSource sPDATOSFACTURABindingSource;
        private Reporte.DSComprobanteTableAdapters.SP_DATOS_FACTURATableAdapter sP_DATOS_FACTURATableAdapter;
    }
}