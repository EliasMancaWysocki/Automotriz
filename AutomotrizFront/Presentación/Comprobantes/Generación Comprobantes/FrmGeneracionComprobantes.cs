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
using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;

namespace Automotriz.Presentación
{
    public partial class FrmGeneracionComprobantes : Form
    {
        IServicioDAO Servicio;

        public FrmGeneracionComprobantes()
        {
            InitializeComponent();
            Servicio = new ServicioDAO();
            CargarCombo(cboComprobantes, Servicio.ObtenerComprobantes());
            CentrarTitulo();
        }

        private void FrmGeneracionComprobantes_Load(object sender, EventArgs e)
        {
            CargarCombo(cboComprobantes, Servicio.ObtenerComprobantes());
            CentrarTitulo();
            CentrarBotones();
        }

        //Funciones
        private void CargarCombo(ComboBox cbo, List<Items> lst)
        {
            cbo.DataSource = lst;
            cbo.ValueMember = "Id";
            cbo.DisplayMember = "Nombre";
            cbo.SelectedIndex = -1;
        }
        private void CentrarTitulo()
        {
            int x = 0;
            x = (Width - 15 - lblTitulo.Width) / 2;

            lblTitulo.Location = new Point(x, 25);
        }
        private void CentrarBotones()
        {
            int x = (Width - 15 - 155) / 2;
            btnVolver.Location = new Point(x, 115);
            btnSiguiente.Location = new Point(x + 80, 115);
        }


        //Botones
        private void btnVolver_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea cancelar la generación del comprobante?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(cboComprobantes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de comprobante", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboComprobantes.Focus();
                return;
            }

            Items item = (Items)cboComprobantes.SelectedItem;

            FrmDatosEmisor frmDatosEmision = new FrmDatosEmisor(item);
            frmDatosEmision.ShowDialog();
        }
    }
}
