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

        }


        private void nuevoComprobanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGeneracionComprobantes frmGeneracionComprobantes = new FrmGeneracionComprobantes();
            frmGeneracionComprobantes.ShowDialog();
        }
        private void comprobantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente nuevoCliente = new FrmNuevoCliente();
            nuevoCliente.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaComprobantes frmConsultaComprobantes = new FrmConsultaComprobantes();
            frmConsultaComprobantes.ShowDialog();
        }
    }
}
