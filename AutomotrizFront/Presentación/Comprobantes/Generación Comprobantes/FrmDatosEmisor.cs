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

namespace Automotriz.Presentación
{
    public partial class FrmDatosEmisor : Form
    {
        IServicioDAO Servicio;
        Items item;

        public FrmDatosEmisor()
        {
            InitializeComponent();
            Servicio = new ServicioDAO();
            CentrarBotones();
            dtpFecha.Value = DateTime.Now;
        }

        private void FrmComprobante_Load(object sender, EventArgs e)
        {
            CargarCombo(cboComprobantes, Servicio.ObtenerComprobantes());
            CargarCombo(cboConceptos, Servicio.ObtenerConceptos());
            CargarCombo(cboAct1, Servicio.ObtenerActividades());
            CargarCombo(cboAct2, Servicio.ObtenerActividades());
            CargarCombo(cboAct3, Servicio.ObtenerActividades());
            CargarCombo(cboAct4, Servicio.ObtenerActividades());
            CargarCombo(cboAct5, Servicio.ObtenerActividades());

            dtpDesde.Visible = false;
            lblDesde.Visible = false;
            lblHasta.Visible = false;
            dtpHasta.Visible = false;
        }

        //Funciones
        private void CargarCombo(ComboBox cbo, List<Items> lst)
        {
            cbo.DataSource = lst;
            cbo.ValueMember = "Id";
            cbo.DisplayMember = "Nombre";
            cbo.SelectedIndex = -1;
        }
        private void CentrarBotones()
        {
            int x = (Width - 15 - 195) / 2;
            btnVolver.Location = new Point(x, 360);
            btnSiguiente.Location = new Point(x + 120, 360);
        }

        //Botones
        private void btnMasAct_Click(object sender, EventArgs e)
        {
            if (cboAct2.Visible == false)
            {
                cboAct2.Visible = true;
                lblAct2.Visible = true;
                btnActMenos.Enabled = true;
                btnActMas.Location = new Point(407, btnActMas.Location.Y + 27);
                btnActMenos.Location = new Point(435, btnActMenos.Location.Y + 27);
                return;
            }
            if (cboAct3.Visible == false)
            {
                cboAct3.Visible = true;
                lblAct3.Visible = true;
                btnActMas.Location = new Point(407, btnActMas.Location.Y + 27);
                btnActMenos.Location = new Point(435, btnActMenos.Location.Y + 27);
                return;
            }
            if (cboAct4.Visible == false)
            {
                cboAct4.Visible = true;
                lblAct4.Visible = true;
                btnActMas.Location = new Point(407, btnActMas.Location.Y + 27);
                btnActMenos.Location = new Point(435, btnActMenos.Location.Y + 27);
                return;
            }
            if (cboAct5.Visible == false)
            {
                cboAct5.Visible = true;
                lblAct5.Visible = true;
                btnActMas.Enabled = false;
                btnActMas.Location = new Point(407, btnActMas.Location.Y + 27);
                btnActMenos.Location = new Point(435, btnActMenos.Location.Y + 27);
                return;
            }
        }
        private void btnActMenos_Click(object sender, EventArgs e)
        {
            if (cboAct5.Visible == true)
            {
                cboAct5.Visible = false;
                lblAct5.Visible = false;
                btnActMas.Enabled = true;
                btnActMas.Location = new Point(407, btnActMas.Location.Y - 27);
                btnActMenos.Location = new Point(435, btnActMenos.Location.Y - 27);
                return;
            }
            if (cboAct4.Visible == true)
            {
                cboAct4.Visible = false;
                lblAct4.Visible = false;
                btnActMas.Location = new Point(407, btnActMas.Location.Y - 27);
                btnActMenos.Location = new Point(435, btnActMenos.Location.Y - 27);
                return;
            }
            if (cboAct3.Visible == true)
            {
                cboAct3.Visible = false;
                lblAct3.Visible = false;
                btnActMas.Location = new Point(407, btnActMas.Location.Y - 27);
                btnActMenos.Location = new Point(435, btnActMenos.Location.Y - 27);
                return;
            }
            if (cboAct2.Visible == true)
            {
                cboAct2.Visible = false;
                lblAct2.Visible = false;
                btnActMenos.Enabled = false;
                btnActMas.Location = new Point(407, btnActMas.Location.Y - 27);
                btnActMenos.Location = new Point(435, btnActMenos.Location.Y - 27);
                return;
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha debe ser igual o menor a la fecha acutal.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFecha.Focus();
                return;
            }
            if (cboConceptos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un concepto a incluír.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboConceptos.Focus();
                return;
            }
            if (cboAct2.Visible == true && cboAct2.Text == cboAct1.Text)
            {
                MessageBox.Show("No es posible asociar la misma actividad mas de una vez a un comprobante.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboAct2.Focus();
                return;
            }
            if (cboAct3.Visible == true &&
                (cboAct3.Text == cboAct1.Text ||
                    cboAct3.Text == cboAct2.Text))
            {
                MessageBox.Show("No es posible asociar la misma actividad mas de una vez a un comprobante.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboAct2.Focus();
                return;
            }
            if (cboAct4.Visible == true &&
                (cboAct4.Text == cboAct1.Text ||
                    cboAct4.Text == cboAct2.Text ||
                        cboAct4.Text == cboAct3.Text))
            {
                MessageBox.Show("No es posible asociar la misma actividad mas de una vez a un comprobante.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboAct2.Focus();
                return;
            }
            if (cboAct5.Visible == true &&
                (cboAct5.Text == cboAct1.Text ||
                    cboAct5.Text == cboAct2.Text ||
                        cboAct5.Text == cboAct3.Text ||
                            cboAct5.Text == cboAct4.Text))
            {
                MessageBox.Show("No es posible asociar la misma actividad mas de una vez a un comprobante.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboAct2.Focus();
                return;
            }



            Comprobante comprobante = new Comprobante();
            comprobante.Fecha = dtpFecha.Value;

            FrmDatosReceptor frmDatosRecepcion = new FrmDatosReceptor(item, comprobante);
            frmDatosRecepcion.ShowDialog();

        }

        //ComboBox SelectedIndexChanged
        private void cboConceptos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboConceptos.SelectedIndex == 2 || cboConceptos.SelectedIndex == 1)
            {
                dtpDesde.Visible = true;
                lblDesde.Visible = true;
                dtpHasta.Visible = true;
                lblHasta.Visible = true;
            } else
            {
                dtpDesde.Visible = false;
                lblDesde.Visible = false;
                lblHasta.Visible = false;
                dtpHasta.Visible = false;
            }
        }
    }
}
