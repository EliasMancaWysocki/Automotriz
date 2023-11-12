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
    public partial class FrmNuevoCliente : Form
    {
        IServicioDAO Servicio;
        Items item;

        public FrmNuevoCliente()
        {
            InitializeComponent();
            Servicio = new ServicioDAO();
        }

        private void FrmNuevoCliente_Load(object sender, EventArgs e)
        {
            CargarCombo(cboTCliente, Servicio.ObtenerTipoCliente()) ;
            CargarCombo(cboTipoDoc, Servicio.ObtenerTipoDoc());
            CargarCombo(cboCIva, Servicio.ObtenerCondicionIVA());
            CargarCombo(cboBarrios, Servicio.ObtenerBarrios() );

            lblidcliente.Text = lblidcliente.Text + " :  " + Servicio.ProximoIdCliente();


        }


        private void CargarCombo(ComboBox Cbo, List<Items> lst)
        {
            Cbo.DataSource = lst;
            Cbo.ValueMember = "Id";
            Cbo.DisplayMember = "Nombre";
            Cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar la carga del cliente ?", "Cancelar  ", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente();

            ValidarCampos();

            nuevo.Nombre = txtNombre.Text;
            nuevo.Apellido = txtApellido.Text;
            nuevo.Calle = txtCalle.Text;
            nuevo.Altura = txtAltura.Text;
            nuevo.Barrio = Convert.ToInt32(cboBarrios.SelectedValue) ;
            nuevo.Documento = txtDocumento.Text;
            nuevo.TipoDoc = Convert.ToInt32(cboTCliente.SelectedValue);
            nuevo.CondicionIVA = Convert.ToInt32(cboCIva.SelectedValue);
            nuevo.TipoCliente = Convert.ToInt32(cboTCliente.SelectedValue);

            if (Servicio.ConfirmarCliente(nuevo)==1)
            {
                MessageBox.Show("Se registró con éxito el Cliente...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarCampos();
                this.Dispose();

            }
            else
            {
                MessageBox.Show("NO se pudo registrar el Cliente...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            }
        }

        private void LimpiarCampos()
        {
            cboTCliente.SelectedIndex = -1;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCalle.Text = string.Empty;
            txtAltura.Text = string.Empty;
            cboBarrios.SelectedIndex = -1;
            txtDocumento.Text = string.Empty;
            cboTipoDoc.SelectedIndex = -1;
            cboCIva.SelectedIndex = -1;

        }

        private void ValidarCampos()
        {
            if(cboTCliente.SelectedIndex==-1)
            {
                MessageBox.Show("Seleccione un producto" ,"CONTROL DE CAMPO");
                return;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un Nombre", "CONTROL DE CAMPO");
                return;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Ingrese un apellido", "CONTROL DE CAMPO");
                return;
            }
            if (string.IsNullOrEmpty(txtCalle.Text))
            {
                MessageBox.Show("Ingrese la calle ", "CONTROL DE CAMPO");
                return;
            }
            if (string.IsNullOrEmpty(txtAltura.Text))
            {
                MessageBox.Show("Ingrese la Altura ", "CONTROL DE CAMPO");
                return;
            }

            if (cboBarrios.SelectedIndex==-1)
            {
                MessageBox.Show("Seleccione un barrio ", "CONTROL DE CAMPO");
                return;
            }
            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                MessageBox.Show("Ingrese el Nro documento  ", "CONTROL DE CAMPO");
                return;
            }

            if (cboTipoDoc.SelectedIndex==-1)
            {
                MessageBox.Show("Seleccion el tipo de documento  ", "CONTROL DE CAMPO");
                return;
            }
            if (cboCIva.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccion la condicion de iva  ", "CONTROL DE CAMPO");
                return;
            }

        }
    }
}
