using AutomotrizBack.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomotrizFront.Presentación.Comprobantes.Consulta_Comprobantes.Reporte;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;

namespace AutomotrizFront.Presentación.Comprobantes.Consulta_Comprobantes
{
    public partial class FrmReporteComprobante : Form
    {
        int nroComprobante;
        public FrmReporteComprobante(int nroComprobante)
        {
            InitializeComponent();
            this.nroComprobante = nroComprobante;
            rvComprobante.SetDisplayMode(DisplayMode.PrintLayout);
            rvComprobante.ZoomMode = ZoomMode.FullPage;
            PageSettings pg = new PageSettings();
            pg.Margins.Left = 25;
            pg.Margins.Right = 25;
            pg.Margins.Top = 20;
            pg.Margins.Bottom = 20;
            rvComprobante.SetPageSettings(pg);
        }

        private void FrmReporteComprobante_Load_1(object sender, EventArgs e)
        {
            rvComprobante.ProcessingMode = ProcessingMode.Local;
            rvComprobante.LocalReport.ReportPath = "RptComprobante.rdlc";
            DataTable detallesComprobante = sP_REPORTE_COMPROBANTETableAdapter.GetData(nroComprobante);
            DataTable datosFactura = sP_DATOS_FACTURATableAdapter.GetData(nroComprobante);
            rvComprobante.LocalReport.DataSources.Add(new ReportDataSource("DetallesComprobante", detallesComprobante));
            rvComprobante.LocalReport.DataSources.Add(new ReportDataSource("DatosFactura", datosFactura));
            rvComprobante.RefreshReport();
        }
    }
}
