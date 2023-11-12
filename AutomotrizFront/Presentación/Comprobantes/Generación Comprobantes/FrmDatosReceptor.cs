using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
using Automotriz.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automotriz.Servicio.Implementación;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Automotriz.Presentación
{
    public partial class FrmDatosReceptor : Form
    {
        IServicioDAO Servicio;
        Comprobante comprobante;
        Items item;
        Cliente cliente;
        Dictionary<System.Windows.Forms.CheckBox, Items> chkFormasPagos;

        public FrmDatosReceptor(Items item, Comprobante comprobante)
        {
            InitializeComponent();
            Servicio = new ServicioDAO();
            this.comprobante = comprobante;
            this.item = item;
            lblTitulo.Text = item.Nombre;
            chkFormasPagos = new Dictionary<System.Windows.Forms.CheckBox, Items>();
        }

        private void FrmDatosRecepcion_Load(object sender, EventArgs e)
        {
            CargarCombo(cboCondicionIVA, Servicio.ObtenerCondicionIVA());
            CargarCombo(cboTipoDoc, Servicio.ObtenerTipoDoc());
            CentrarTitulo();
            CentrarCdV();
            CentrarBotones();
            CargarCheckBox();
        }

        //Funciones
        private void CargarCombo(ComboBox Cbo, List<Items> lst)
        {
            Cbo.DataSource = lst;
            Cbo.ValueMember = "Id";
            Cbo.DisplayMember = "Nombre";
            Cbo.DropDownStyle = ComboBoxStyle.DropDownList;
            Cbo.SelectedIndex = -1;
        }
        private void CentrarTitulo()
        {
            int x = (Width - 15 - lblTitulo.Width) / 2;
            lblTitulo.Location = new Point(x, 25);
        }
        private void CentrarCdV()
        {
            int x = (Width - 15 - groupBoxCondicionVenta.Width) / 2;
            groupBoxCondicionVenta.Location = new Point(x, 230);
        }
        private void CentrarBotones()
        {
            int x = (Width - 15 - 155) / 2;
            btnVolver.Location = new Point(x, 480);
            btnSiguiente.Location = new Point(x + 80, 480);
        }
        private void CargarCheckBox()
        {
            List<Items> lst = Servicio.ObtenerFormasPago();
            int y = 0;
            foreach (Items item in lst)
            {
                
                System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox()
                {
                    Name = "chk" + item.Nombre.ToString().Trim(),
                    Text = item.Nombre.ToString(),
                    Location = new Point(6, y + 30)
                };
                chkFormasPagos.Add(checkBox, item);
                groupBoxCondicionVenta.Controls.Add(checkBox);
                y += 30;
            }
        }

        //Botones
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string camposObligatorios = "Los siguientes campos son obligatorios:\n";
            bool permiso = true;

            if (!Regex.IsMatch(txtDocumento.Text, @"^\d+$"))
            {
                MessageBox.Show("Número de Documento inválido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDocumento.Focus();
                return;
            }

            if (cboCondicionIVA.SelectedIndex == -1)
            {
                camposObligatorios += "\n*Condición frente al IVA del receptor";
                permiso = false;
            }
            if(cboTipoDoc.SelectedIndex == -1)
            {
                camposObligatorios += "\n*Tipo de Documento del Receptor";
                permiso = false;
            }
            if(txtDocumento.Text == string.Empty)
            {
                camposObligatorios += "\n*Número de Documento del Receptor";
                permiso = false;
            }
            if (txtRazonSocial.Text == string.Empty)
            {
                camposObligatorios += "\n*Razón Social del Receptor";
                permiso = false;
            }
            if (txtDomicilio.Text == string.Empty)
            {
                camposObligatorios += "\n*Domicilio Comercial del Receptor";
                permiso = false;
            }
            foreach (System.Windows.Forms.CheckBox chk in groupBoxCondicionVenta.Controls.OfType<System.Windows.Forms.CheckBox>())
            {
                bool ningunoMarcado = true;

                if(chk.Checked)
                {
                    ningunoMarcado = false;

                    //Esta puta mierda no anda. Arreglar
                }

                if(ningunoMarcado)
                {
                    MessageBox.Show("Debe ingresar al menos una condición de venta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //if(chkEfectivo.Checked == false && 
            //    chkCheque.Checked == false &&
            //    chkCredito.Checked == false &&
            //    chkDebito.Checked == false &&
            //    chkCuentaCorriente.Checked ==  false &&
            //    chkTransferencia.Checked ==  false)
            //{
            //    MessageBox.Show("Debe ingresar al menos una condición de venta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            if(!permiso)
            {
                MessageBox.Show(camposObligatorios, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else
            {
                //if(chkEfectivo.Checked == true)
                //{
                //    Items formaPago = new Items(1, "Efectivo");
                //    comprobante.AgregarFormasPago(formaPago);
                //}
                //if (chkEfectivo.Checked == true)
                //{
                //    Items formaPago = new Items(2, "Cheque");
                //    comprobante.AgregarFormasPago(formaPago);
                //}
                //if (chkEfectivo.Checked == true)
                //{
                //    Items formaPago = new Items(3, "Crédito");
                //    comprobante.AgregarFormasPago(formaPago);
                //}
                //if (chkEfectivo.Checked == true)
                //{
                //    Items formaPago = new Items(4, "Débito");
                //    comprobante.AgregarFormasPago(formaPago);
                //}
                //if (chkEfectivo.Checked == true)
                //{
                //    Items formaPago = new Items(5, "Cuenta Corriente");
                //    comprobante.AgregarFormasPago(formaPago);
                //}
                //if (chkEfectivo.Checked == true)
                //{
                //    Items formaPago = new Items(6, "Transferencia");
                //    comprobante.AgregarFormasPago(formaPago);
                //}
                comprobante.IdCliente = cliente.Id;

                //FrmDatosOperacion frmDatosOperacion = new FrmDatosOperacion(item, comprobante);
                //frmDatosOperacion.ShowDialog();

                MessageBox.Show(cliente.Apellido);
            }
        }


        //Eventos
        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cliente = Servicio.ExtraerCliente(txtDocumento.Text.Trim());
                groupBoxAdvertenciaDoc.Visible = false;
                txtRazonSocial.Text = cliente.Nombre + " " + cliente.Apellido;
                txtDomicilio.Text = cliente.Calle + " " + cliente.Altura;
                MessageBox.Show(cliente.Apellido);

            } 
            catch (Exception)
            {
                //groupBoxAdvertenciaDoc.Text = "Número de documento inválido";
                //groupBoxAdvertenciaDoc.Visible = true;
                //txtRazonSocial.Text = string.Empty;
                //txtDomicilio.Text = string.Empty;
                return;
            }

            //if (cliente is null)
            //{
            //    return;
            //}
            //else
            //{
            //    groupBoxAdvertenciaDoc.Visible = false;
            //    txtRazonSocial.Text = cliente.Nombre + " " + cliente.Apellido;
            //    txtDomicilio.Text = cliente.Calle + " " + cliente.Altura;
            //}
        }
        private void cboCondicionIVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCondicionIVA.SelectedIndex > -1)
            {
                switch (cboCondicionIVA.SelectedIndex)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 5:
                    case 9:
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                        cboTipoDoc.SelectedIndex = 4;
                        cboTipoDoc.Enabled = false;
                        txtDocumento.Enabled = true;
                        txtDocumento.Text = string.Empty;
                        break;
                    case 6:
                        cboTipoDoc.SelectedIndex = 4;
                        cboTipoDoc.Enabled = false;
                        txtDocumento.Text = "23000000000";
                        txtDocumento.Enabled = false;
                        break;
                    default:
                        CargarCombo(cboTipoDoc, Servicio.ObtenerTipoDoc());
                        cboTipoDoc.Enabled = true;
                        txtDocumento.Enabled = true;
                        txtDocumento.Text = string.Empty;
                        break;
                }
            }

            if (cboCondicionIVA.SelectedIndex == 0)
            {
                cboTipoDoc.SelectedIndex = 4;
                cboTipoDoc.Enabled = false;
                txtDocumento.Enabled = true;
                txtDocumento.Text = string.Empty;
            }
        }
    }
}
