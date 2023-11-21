using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
using AutomotrizFront.Presentación.Comprobantes.Consulta_Comprobantes;
using AutomotrizFront.Servicio;
using AutomotrizFront.Servicio.Implementación;
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

namespace AutomotrizFront.Presentación
{
    public partial class FrmDatosOperacion : Form
    {
        IServicioDAO Servicio;
        Comprobante Comprobante;
        Items Item;
        static double subtotal;
        static double otrosImportes ;
        static double total;

        public FrmDatosOperacion(Items item, Comprobante comprobante)
        {
            InitializeComponent();
            Servicio = new ServicioDAO();
            this.Item = item;
            this.Comprobante = comprobante;
            lblTitulo.Text = item.Nombre;
            lblSubtotalImp.Text = subtotal.ToString("N");
            lblOtrosImp.Text = otrosImportes.ToString("N");
            lblTotalImp.Text = total.ToString("N");
            subtotal = 0.00;
            otrosImportes = 0.00;
            total = 0.00;
        }

        private void FrmDatosOperacion_Load(object sender, EventArgs e)
        {
            CargarCombo(cboTipoProd, Servicio.ObtenerTiposProductos());
            CargarCombo(cboUnidadMedida, Servicio.ObtenerUnidadesMedidas());
            CargarCombo(cboDescuentos, Servicio.ObtenerDescuentos());
            CargarCombo(cboAutoplan, Servicio.ObtenerAutoplanes());

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
        private void CentrarBotones()
        {
            int x = (Width - 15 - 195) / 2;
            btnVolver.Location = new Point(x, 480);
            btnImprimir.Location = new Point(x + 120, 480);
        }

        //Botones
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar un producto", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigo.Focus();
                return;
            }
            if (cboProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un producto", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboProducto.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Debe ingresar la cantidad del producto", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCantidad.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Debe ingresar el precio del producto", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrecio.Focus();
                return;
            }

            if (cboAutoplan.Visible && (cboAutoplan.SelectedIndex == 0 || cboAutoplan.SelectedIndex == -1))
            {
                MessageBox.Show("Debe seleccionar el autoplan", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboAutoplan.Focus();
                return;
            } 

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells["colCodigo"].Value.ToString().Equals(txtCodigo.Text))
                {
                    MessageBox.Show("PRODUCTO: " + cboProducto.Text + " ya se encuentra como detalle!", "CONTROL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            Producto producto = Servicio.ExtraerProducto(Convert.ToInt32(txtCodigo.Text));

            Items descuento = (Items)cboDescuentos.SelectedItem;
            Items autoplan = (Items)cboAutoplan.SelectedItem;

            DetalleComprobante detalleComprobante = new DetalleComprobante();
            detalleComprobante.CodProducto = producto.Codigo;
            detalleComprobante.Cantidad = Convert.ToInt32(txtCantidad.Text);
            detalleComprobante.Precio = Convert.ToDouble(txtPrecio.Text);
            detalleComprobante.IdBonif = descuento.Id;
            detalleComprobante.IdAutoplan = autoplan.Id;

            if (!cboAutoplan.Visible)
            {
                detalleComprobante.IdAutoplan = 1;
            }

            Comprobante.AgregarDetalleComprobante(detalleComprobante);
            dgvDetalles.Rows.Add(new object[]
            {
                txtCodigo.Text,
                cboProducto.Text,
                txtCantidad.Text,
                cboUnidadMedida.Text,
                txtPrecio.Text,
                cboDescuentos.Text,
                txtImporteBonif.Text,
                txtSubtotal.Text
            });

            subtotal += detalleComprobante.CalcularSubtotal();
            otrosImportes += Comprobante.CalcularOtrosImportes() + detalleComprobante.CalcularOtrosImportes();
            total = subtotal + otrosImportes;

            lblSubtotalImp.Text = subtotal.ToString("N");
            lblOtrosImp.Text = otrosImportes.ToString("N");
            lblTotalImp.Text = total.ToString("N");
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (Servicio.InsertarFactura(Comprobante))
            {
                int nroFact = Servicio.NumFacturaActual();
                FrmReporteComprobante frmReporteComprobante = new FrmReporteComprobante(nroFact);
                frmReporteComprobante.ShowDialog();
                Close();
            } else
            {
                MessageBox.Show("Error al crear factura", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        //Eventos
        private void cboProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Items i = cboProducto.SelectedItem as Items;
            txtCodigo.Text = i.Id.ToString();
            Producto p = Servicio.ExtraerProducto(i.Id);
            foreach(Items j in cboUnidadMedida.Items)
            {
                if(j.Id == p.IdUMedida)
                {
                    cboUnidadMedida.SelectedItem = j;
                }
            }

        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtCantidad.Text, @"^[0-9]+$"))
            {
                if (Convert.ToInt32(txtCantidad.Text) >= 50 && Convert.ToInt32(txtCantidad.Text) < 100)
                {
                    cboDescuentos.SelectedIndex = 1;
                    if (!string.IsNullOrEmpty(txtPrecio.Text) && !string.IsNullOrEmpty(txtCantidad.Text))
                    {
                        txtImporteBonif.Text = ((Convert.ToDouble(txtPrecio.Text) * (Convert.ToInt32(txtCantidad.Text)) * Convert.ToDouble(cboDescuentos.Text) / 100).ToString());
                        txtSubtotal.Text = ((Convert.ToDouble(txtPrecio.Text) * Convert.ToDouble(txtCantidad.Text)) - Convert.ToDouble(txtImporteBonif.Text)).ToString();
                    }
                }
                else if (Convert.ToInt32(txtCantidad.Text) >= 100 && Convert.ToInt32(txtCantidad.Text) < 150)
                {
                    cboDescuentos.SelectedIndex = 2;
                    if (!string.IsNullOrEmpty(txtPrecio.Text) && !string.IsNullOrEmpty(txtCantidad.Text))
                    {
                        txtImporteBonif.Text = (Convert.ToDouble(txtPrecio.Text) * (Convert.ToInt32(txtCantidad.Text)) * Convert.ToDouble(cboDescuentos.Text) / 100).ToString();
                        txtSubtotal.Text = ((Convert.ToDouble(txtPrecio.Text) * Convert.ToDouble(txtCantidad.Text)) - Convert.ToDouble(txtImporteBonif.Text)).ToString();
                    }
                }
                else if (Convert.ToInt32(txtCantidad.Text) >= 150)
                {
                    cboDescuentos.SelectedIndex = 3;
                    if (!string.IsNullOrEmpty(txtPrecio.Text) && !string.IsNullOrEmpty(txtCantidad.Text))
                    {
                        txtImporteBonif.Text = (Convert.ToDouble(txtPrecio.Text) * (Convert.ToInt32(txtCantidad.Text)) * Convert.ToDouble(cboDescuentos.Text) / 100).ToString();
                        txtSubtotal.Text = ((Convert.ToDouble(txtPrecio.Text) * Convert.ToDouble(txtCantidad.Text)) - Convert.ToDouble(txtImporteBonif.Text)).ToString();
                    }
                }
                else
                {
                    cboDescuentos.SelectedIndex = 0;
                    if (!string.IsNullOrEmpty(txtPrecio.Text) && !string.IsNullOrEmpty(txtCantidad.Text))
                    {
                        txtImporteBonif.Text = (Convert.ToDouble(txtPrecio.Text) * (Convert.ToInt32(txtCantidad.Text)) * Convert.ToDouble(cboDescuentos.Text) / 100).ToString();
                        txtSubtotal.Text = ((Convert.ToDouble(txtPrecio.Text) * Convert.ToDouble(txtCantidad.Text)) - Convert.ToDouble(txtImporteBonif.Text)).ToString();
                    }
                }
            }
            else
            {
                txtCodigo.Text = string.Empty;
            }
        }
        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtCantidad.Text, @"^[0-9]+$"))
            {
                if (!string.IsNullOrEmpty(txtPrecio.Text) && !string.IsNullOrEmpty(txtCantidad.Text))
                {
                    txtImporteBonif.Text = ((Convert.ToDouble(txtPrecio.Text) * (Convert.ToInt32(txtCantidad.Text)) * Convert.ToDouble(cboDescuentos.Text) / 100).ToString());
                    txtSubtotal.Text = ((Convert.ToDouble(txtPrecio.Text) * Convert.ToDouble(txtCantidad.Text)) - Convert.ToDouble(txtImporteBonif.Text)).ToString();
                }
            }
            else
            {
                txtCodigo.Text = string.Empty;
            }
        }
        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 8)
            {
                DetalleComprobante detalleComprobante = new DetalleComprobante();

                foreach(DetalleComprobante dc in Comprobante.DetallesComprobante)
                {
                    if(dc.CodProducto == Convert.ToInt32(dgvDetalles.CurrentRow.Cells["ColCodigo"].Value.ToString()))
                    {
                        detalleComprobante = dc;
                    }
                }

                otrosImportes -= Comprobante.CalcularOtrosImportes() + detalleComprobante.CalcularOtrosImportes();
                subtotal -= detalleComprobante.CalcularSubtotal();
                total = subtotal + otrosImportes;

                lblSubtotalImp.Text = subtotal.ToString("N");
                lblOtrosImp.Text = otrosImportes.ToString("N");
                lblTotalImp.Text = total.ToString("N");

                Comprobante.EliminarDetalleComprobante(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);

            }
            else
            {
                return;
            }
        }
        private void cboTipoProd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
            Items i = (Items)cboTipoProd.SelectedItem;
            CargarCombo(cboProducto, Servicio.ObtenerProductos(i.Id));
            if(i.Id == 4)
            {
                cboAutoplan.Visible = true;
                lblAutoplan.Visible = true;
            } else
            {
                cboAutoplan.Visible = false;
                lblAutoplan.Visible = false;
                cboAutoplan.SelectedIndex = 0;
            }
        }

    }
}
