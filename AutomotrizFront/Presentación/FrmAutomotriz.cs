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
            CentrarTitulo();
        }

        //Funciones
        private void CentrarTitulo()
        {
            int x = (Width - 35 - lblAutomotrix.Width) / 2;

            lblAutomotrix.Location = new Point(x, 45);
        }


        //Botones
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente nuevoCliente = new FrmNuevoCliente();
            nuevoCliente.ShowDialog();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaComprobantes frmConsultaComprobantes = new FrmConsultaComprobantes();
            frmConsultaComprobantes.ShowDialog();
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
    }
}
