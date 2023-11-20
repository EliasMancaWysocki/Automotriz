using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
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
        Comprobante comprobante;
        Items item;

        public FrmDatosOperacion(Items item, Comprobante comprobante)
        {
            InitializeComponent();
            Servicio = new ServicioDAO();
            this.item = item;
            this.comprobante = comprobante;
            lblTitulo.Text = item.Nombre;
        }

        private void FrmDatosOperacion_Load(object sender, EventArgs e)
        {
            CargarCombo(cboProducto, Servicio.ObtenerProductos());
            CargarCombo(cboUnidadMedida, Servicio.ObtenerUnidadesMedidas());
        }

        //Funciones
        private void CargarCombo(ComboBox cbo, List<Items> lst)
        {
            cbo.DataSource = lst;
            cbo.ValueMember = "Id";
            cbo.DisplayMember = "Nombre";
            cbo.SelectedIndex = -1;
        }

        //Eventos
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtCodigo.Text, @"^[0-9]+$"))
            {

                if (Convert.ToInt32(txtCodigo.Text) > 0 && Convert.ToInt32(txtCodigo.Text) < cboProducto.Items.Count)
                {
                    cboProducto.SelectedIndex = Convert.ToInt32(txtCodigo.Text);
                } else
                {
                    cboProducto.SelectedIndex = -1;
                }
            } else
            {
                txtCodigo.Text = string.Empty;
            }
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            //if (Regex.IsMatch(txtCodigo.Text, @"^[0-9]+$"))
            //{

            //    if (Convert.ToInt32(txtCodigo.Text) > 0 && Convert.ToInt32(txtCodigo.Text) < cboProducto.Items.Count)
            //    {
            //        cboProducto.SelectedIndex = Convert.ToInt32(txtCodigo.Text);
            //    }
            //    else
            //    {
            //        cboProducto.SelectedIndex = -1;
            //    }
            //}
            //else
            //{
            //    txtCodigo.Text = string.Empty;
            //}
        }
        private void cboProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Items i = cboProducto.SelectedItem as Items;
            txtCodigo.Text = i.Id.ToString();
            if(cboProducto.SelectedIndex == -1)
            {
                cboProducto.SelectedIndex = cboProducto.Items.Count - 1;
            } else
            {
                cboProducto.SelectedIndex = cboProducto.SelectedIndex - 1;
            }
        }
    }
}
