using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automotriz.Presentación.Soporte;
using AutomotrizFront.Presentación.Soporte;
using Automotriz.Presentación.Consultas.Consultar_Comprobantes;


namespace Automotriz.Presentación
{
    public partial class FrmAutomotriz : Form
    {
        public FrmAutomotriz()
        {
            InitializeComponent();
        }

        private void FrmAutomotriz_Load(object sender, EventArgs e)
        {
            CentrarTitulo(panelTitulo, lblAutomotrix);
            CentrarTitulo(panelNuevoClienteTitle, lblNuevoCliente);
            CentrarTitulo(panelConsultarClientesTitle, lblConsultarClientes);
            EndResponsive();
        }

        //Funciones
        private void CentrarTitulo(Panel panel, Label lbl)
        {
            int x = (panel.Width - lbl.Width) / 2;

            lbl.Location = new Point(x, 15);
        }
        private void ResponsiveButton(Panel panel, Label lbl, int padding, Font font)
        {
            panel.Padding = new Padding(padding);
            lbl.Font = font;
            CentrarTitulo(panel, lbl);
        }
        private void EndResponsive()
        {
            Font SmallFont = new Font("Times New Roman", 12, FontStyle.Bold);
            Font MediumFont = new Font("Times New Roman", 16, FontStyle.Bold);
            Font LargeFont = new Font("Times New Roman", 20, FontStyle.Bold);

            if (Width > 1200)
            {
                ResponsiveButton(panelNuevoClienteBody, lblNuevoCliente, 25, LargeFont);
                ResponsiveButton(panelConsultarClientesBody, lblConsultarClientes, 25, LargeFont);
                ResponsiveButton(panelNuevoComprobanteBody, lblNuevoComprobante, 25, LargeFont);
                ResponsiveButton(panelConsultarComprobantesBody, lblConsultarComprobantes, 25, LargeFont);
            }
            else if(Width <= 1200)
            {
                ResponsiveButton(panelNuevoClienteBody, lblNuevoCliente, 15, MediumFont);
                ResponsiveButton(panelConsultarClientesBody, lblConsultarClientes, 15, MediumFont);
                ResponsiveButton(panelNuevoComprobanteBody, lblNuevoComprobante, 15, MediumFont);
                ResponsiveButton(panelConsultarComprobantesBody, lblConsultarComprobantes, 15, MediumFont);
            }
            else if(Width <= 992)
            {
                ResponsiveButton(panelNuevoClienteBody, lblNuevoCliente, 5, SmallFont);
                ResponsiveButton(panelConsultarClientesBody, lblConsultarClientes, 5, SmallFont);
                ResponsiveButton(panelNuevoComprobanteBody, lblNuevoComprobante, 5, SmallFont);
                ResponsiveButton(panelConsultarComprobantesBody, lblConsultarComprobantes, 5, SmallFont);
            }
        }


        //Botones Menu Strip
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizarCliente cliente = new FrmActualizarCliente();
            cliente.ShowDialog();
        }
        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmGeneracionComprobantes frmGeneracionComprobantes = new FrmGeneracionComprobantes();
            frmGeneracionComprobantes.ShowDialog();
        }
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaComprobantes frmConsultaComprobantes = new FrmConsultaComprobantes();
            frmConsultaComprobantes.ShowDialog();
        }

        //Botones
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente nuevoCliente = new FrmNuevoCliente();
            nuevoCliente.ShowDialog();
        }
        private void btnNuevoComprobante_Click(object sender, EventArgs e)
        {
            FrmGeneracionComprobantes frmGeneracionComprobantes = new FrmGeneracionComprobantes();
            frmGeneracionComprobantes.ShowDialog();
        }
        private void btnConsultarComprobantes_Click(object sender, EventArgs e)
        {
            FrmConsultaComprobantes frmConsultaComprobantes = new FrmConsultaComprobantes();
            frmConsultaComprobantes.ShowDialog();
        }

        //Eventos
        private void FrmAutomotriz_ResizeEnd(object sender, EventArgs e)
        {
            EndResponsive();
        }
    }
}
