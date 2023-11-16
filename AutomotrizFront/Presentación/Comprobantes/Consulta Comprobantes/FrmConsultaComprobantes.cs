
using Automotriz.Servicio;
using Automotriz.Servicio.Implementación;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automotriz.Presentación.Consultas.Consultar_Comprobantes;
using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;

namespace Automotriz.Presentación.Consultas.Consultar_Comprobantes
{
    public partial class FrmConsultaComprobantes : Form
    {
        IServicioDAO Servicio;

        public FrmConsultaComprobantes()
        {
            InitializeComponent();
            Servicio = new ServicioDAO();
        }

        private void FrmConsultaComprobantes_Load(object sender, EventArgs e)
        {
            CargarCombo(cboTipoDoc, Servicio.ObtenerTipoDoc());
            CentrarBotones();
            dtpDesde.Value = DateTime.Now.AddMonths(-1);
            dtpDesde.MaxDate = DateTime.Now;
            dtpHasta.Value = DateTime.Now;
            dtpHasta.MinDate = DateTime.Now;
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
            btnVolver.Location = new Point(x, 570);
            btnBuscar.Location = new Point(x + 120, 570);
        }

        //Botones
        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la búsqueda?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            string numComprobante = string.Empty;
            if(!Regex.IsMatch(txtNumComprobante.Text, @"^\d+$"))
            {
                if(string.IsNullOrEmpty(txtNumComprobante.Text))
                {
                } else
                {
                    MessageBox.Show("Número de comprobante inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumComprobante.Focus();
                    return;
                }
            } else
            {
                numComprobante = txtNumComprobante.Text;
            }
            string cliente = string.Empty;
            int tipoDoc = cboTipoDoc.SelectedIndex + 1;
            string doc = string.Empty;
            if (!Regex.IsMatch(txtNumDoc.Text, @"^\d+$"))
            {
                if (string.IsNullOrEmpty(txtNumDoc.Text))
                {
                } else
                {
                    MessageBox.Show("Número de documento inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumDoc.Focus();
                    return;
                }
            }else
            {
                doc = txtNumDoc.Text;
            }
            string empleado = txtEmpleado.Text;
            string legajo = string.Empty;
            if (!Regex.IsMatch(txtLegajoEmpleado.Text, @"^\d+$"))
            {
                if(string.IsNullOrEmpty(txtLegajoEmpleado.Text))
                {
                } else
                {
                    MessageBox.Show("Número de legajo inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLegajoEmpleado.Focus();
                    return;
                }
            }else
            {
                legajo = txtLegajoEmpleado.Text;
            }

            List<Parametro> p = new List<Parametro>()
            {
                new Parametro("@fechaDesde", desde),
                new Parametro("@fechaHasta", hasta),
                new Parametro("@numComprobante", numComprobante.ToString()),
                new Parametro("@cliente", cliente.ToString()),
                new Parametro("@tipoDoc", tipoDoc.ToString()),
                new Parametro("@documento", doc.ToString()),
                new Parametro("@empleado", empleado.ToString()),
                new Parametro("@legajoEmpleado", legajo.ToString())
            };

            Dispose();
            FrmResultadoConsultaComprobantes frmResultadoConsultaComprobantes = new FrmResultadoConsultaComprobantes(p);
            frmResultadoConsultaComprobantes.ShowDialog();
        }
        private void btnReiniciarTipoDoc_Click(object sender, EventArgs e)
        {
            cboTipoDoc.SelectedIndex = -1;
        }
    }
}
