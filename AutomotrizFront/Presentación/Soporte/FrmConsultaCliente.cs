using System;
using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
using Automotriz.Servicio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automotriz.Servicio.Implementación;

namespace Automotriz.Presentación.Soporte
{
    public partial class FrmConsultaCliente : Form
    {
        IServicioDAO Servicio;
        Items item;

        public FrmConsultaCliente()
        {
            InitializeComponent();
            Servicio = new ServicioDAO();
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {

        }

        //Funciones
        private void CargarCombo(ComboBox Cbo, List<Items> lst)
        {
            Cbo.DataSource = lst;
            Cbo.ValueMember = "Id";
            Cbo.DisplayMember = "Nombre";
            Cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }
        private void CentrarBotones()
        {
            int x = (Width - 15 - 195) / 2;
            btnCancelar.Location = new Point(x, 280);
            btnConsultar.Location = new Point(x + 120, 280);
        }
        private void LimpiarCampos()
        {

        }
        private void ValidarCampos()
        {

        }

        //Botones
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la carga del cliente ?", "Cancelar  ", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {

        }

    }
}
