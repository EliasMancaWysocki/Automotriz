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

namespace AutomotrizFront.Presentación.Comprobantes.Consulta_Comprobantes
{
    public partial class FrmReporteComprobante : Form
    {
        int nroComprobante;
        public FrmReporteComprobante(int nroComprobante)
        {
            InitializeComponent();
            this.nroComprobante = nroComprobante;
        }

        private void FrmReporteComprobante_Load_1(object sender, EventArgs e)
        {

            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = "RptComprobante.rdlc";
            DataTable dt = sP_REPORTE_COMPROBANTETableAdapter.GetData(nroComprobante);
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DetallesComprobante", dt));

            
            

            reportViewer1.RefreshReport();
        }
    }
}
