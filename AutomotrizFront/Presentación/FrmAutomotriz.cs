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
        }

        //Funciones
        private void CentrarTitulo(Panel panel, Label lbl)
        {
            int x = (panel.Width - lbl.Width) / 2;

            lbl.Location = new Point(x, 15);
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
    }
}
