using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
using Automotriz.Servicio;
using Automotriz.Servicio.Implementación;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomotrizFront.Presentación.Comprobantes.Consulta_Comprobantes;
using AutomotrizFront.Presentación.Comprobantes.Consulta_Comprobantes.Reporte.DSComprobanteTableAdapters;

namespace Automotriz.Presentación.Consultas.Consultar_Comprobantes
{
    public partial class FrmResultadoConsultaComprobantes : Form
    {
        IServicioDAO Servicio;
        List<Parametro> resultadosComprobantes;

        public FrmResultadoConsultaComprobantes(List<Parametro> lst)
        {
            InitializeComponent();
            Servicio = new ServicioDAO();
            resultadosComprobantes = lst;
        }

        private void ResultadoConsultaComprobantes_Load(object sender, EventArgs e)
        {
            dgvResultados.Rows.Clear();
            foreach (ResultadoComprobante rc in Servicio.FiltrarComprobantes(resultadosComprobantes))
            {
                dgvResultados.Rows.Add(new object[] {
                    rc.FechaEmision.ToString("d"),
                    rc.NumComprobante.ToString(),
                    rc.TipoDoc.ToString(),
                    rc.Documento.ToString(),
                    rc.Importe.ToString()});
            }

            CentrarBotones();
            CentrarTitulo();
        }

        //Funciones
        private void CentrarTitulo()
        {
            int x = (Width - 15 - lblTitulo.Width) / 2;
            lblTitulo.Location = new Point(x, 25);
        }
        private void CentrarBotones()
        {
            int x = (Width - 15 - btnMenu.Width * 2) / 2;
            btnMenu.Location = new Point(x, 530);
            btnNuevaBusqueda.Location = new Point(x + 125, 530);
        }


        //Botones
        private void btnNuevaBusqueda_Click(object sender, EventArgs e)
        {
            Dispose();
            FrmConsultaComprobantes frmConsultaComprobantes = new FrmConsultaComprobantes();
            frmConsultaComprobantes.ShowDialog();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        //Eventos
        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvResultados.CurrentCell.ColumnIndex == 5)
            {
                int nroComprobante = Convert.ToInt32(dgvResultados.CurrentRow.Cells["colNumComprobante"].Value);
                FrmReporteComprobante frmReporteComprobante = new FrmReporteComprobante(nroComprobante);
                frmReporteComprobante.ShowDialog();
            }
        }
    }
}
