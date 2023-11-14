using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automotriz.Servicio;
using Automotriz.Servicio.Implementación;
using AutomotrizBack.Datos;
using Automotriz.Presentación.Soporte;
using Automotriz.Presentación;
using AutomotrizBack.Entidades;

namespace AutomotrizFront.Presentación.Soporte
{
    public partial class FrmActualizarCliente : Form
    {


        IServicioDAO Servicio;
        List<Cliente> lClientes;
        int nrocl;
        public FrmActualizarCliente()
        {
            InitializeComponent();
            Servicio = new ServicioDAO();
            lClientes = new List<Cliente>();


        }

        private void FrmActualizarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'automotrizDataSet2.Mostrar_Cliente' Puede moverla o quitarla según sea necesario.
            this.mostrar_ClienteTableAdapter.Fill(this.automotrizDataSet2.Mostrar_Cliente);
           

            lblidcliente.Text = lblidcliente.Text + " :  " + nrocl;

            gbboxCampos.Enabled = false;
            LimpiarCampos();

        }

        private void CargarCamposClientes()
        {

            lClientes.Clear();
            lClientes = Servicio.ListaCliente();


            foreach (Cliente item in lClientes)
            {
                

              if(item.Id == nrocl)
                {   
                    
                    txtNombre.Text = item.Nombre;
                    txtApellido.Text = item.Apellido;
                    txtCalle.Text = item.Calle;
                    txtAltura.Text = item.Altura;
                    //cboBarrios.SelectedIndex = item.Barrio;
                    txtDocumento.Text = item.Documento;
                    //cboTipoDoc.SelectedIndex = item.TipoDoc;
                   // cboCIva.SelectedIndex = item.CondicionIVA;
                    //cboTCliente.SelectedIndex = item.TipoCliente;

                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente nuevoCliente = new FrmNuevoCliente();
            nuevoCliente.ShowDialog();
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente();

            ValidarCampos();

            if (MessageBox.Show("Esta seguro que desea actualizar los campos del cliente") == DialogResult.Yes)

            nuevo.Id = nrocl;
            nuevo.Nombre = txtNombre.Text;
            nuevo.Apellido = txtApellido.Text;
            nuevo.Calle = txtCalle.Text;
            nuevo.Altura = txtAltura.Text;
            nuevo.Barrio = Convert.ToInt32(cboBarrios.SelectedValue);
            nuevo.Documento = txtDocumento.Text;
            nuevo.TipoDoc = Convert.ToInt32(cboTCliente.SelectedValue);
            nuevo.CondicionIVA = Convert.ToInt32(cboCIva.SelectedValue);
            nuevo.TipoCliente = Convert.ToInt32(cboTCliente.SelectedValue);

            if (Servicio.ModificarCliente(nuevo) == 1)// cambiar por 
            {
                MessageBox.Show("Se registró modificacion con éxito el Cliente...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarCampos();
                this.Dispose();

            }
            else
            {
                MessageBox.Show("NO se pudo actualizar el Cliente...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gbClientes_Enter(object sender, EventArgs e)
        {


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
            if (cboTCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto", "CONTROL DE CAMPO");
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

            if (cboBarrios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un barrio ", "CONTROL DE CAMPO");
                return;
            }
            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                MessageBox.Show("Ingrese el Nro documento  ", "CONTROL DE CAMPO");
                return;
            }

            if (cboTipoDoc.SelectedIndex == -1)
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

        private void dgvListacl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListacl.MultiSelect = false;//solo permite seleccionar una selda
            

            

            if (dgvListacl.CurrentCell.ColumnIndex == 10)
            {
                nrocl = Convert.ToInt32(dgvListacl.CurrentRow.Cells["Nro_Cliente"].Value);
                CargarCamposClientes();
                lblidcliente.Text = " :  " + nrocl;
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
