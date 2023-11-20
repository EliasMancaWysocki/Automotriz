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
        int IdAModificar;

        public FrmActualizarCliente()
        {
            InitializeComponent();
            Servicio = new ServicioDAO();
            lClientes = new List<Cliente>();

        }

        private void FrmActualizarCliente_Load(object sender, EventArgs e)
        {
            CargarCombo(cboTCliente, Servicio.ObtenerTipoCliente());
            CargarCombo(cboTipoDoc, Servicio.ObtenerTipoDoc());
            CargarCombo(cboCIva, Servicio.ObtenerCondicionIVA());
            CargarCombo(cboBarrios, Servicio.ObtenerBarrios());

            CargarListado();//datagridview

            gbboxCampos.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;

            LimpiarCampos();

        }

        private void CargarListado()
        {
            // TODO: esta línea de código carga datos en la tabla 'automotrizDataSet2.Mostrar_Cliente' Puede moverla o quitarla según sea necesario.
            this.mostrar_ClienteTableAdapter.Fill(this.automotrizDataSet2.Mostrar_Cliente);
        }

        //Funciones
        private void CargarCamposClientes(int nroCliente)
        {
            lClientes.Clear();
            lClientes = Servicio.ListaCliente();

            foreach (Cliente item in lClientes)
            {
                if (item.Id == nroCliente)
                {
                    lblIdCliente.Text = "Nro : " + nroCliente.ToString();
                    txtNombre.Text = item.Nombre;
                    txtApellido.Text = item.Apellido;
                    txtCalle.Text = item.Calle;
                    txtAltura.Text = item.Altura;
                    cboBarrios.SelectedIndex = item.Barrio - 1;
                    txtDocumento.Text = item.Documento;
                    cboTipoDoc.SelectedIndex = item.TipoDoc - 1;
                    cboCIva.SelectedIndex = item.CondicionIVA - 1;
                    cboTCliente.SelectedIndex = item.TipoCliente - 1;

                    IdAModificar = nroCliente;

                }

            }
        }
        private void LimpiarCampos()
        {
            lblIdCliente.Text = string.Empty;
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
        private bool ValidarCampos()
        {
            bool aux = true;

            if (cboTCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto", "CONTROL DE CAMPO");
                aux = false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un Nombre", "CONTROL DE CAMPO");
                aux = false;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Ingrese un apellido", "CONTROL DE CAMPO");
                aux = false;
            }
            if (string.IsNullOrEmpty(txtCalle.Text))
            {
                MessageBox.Show("Ingrese la calle ", "CONTROL DE CAMPO");
                aux = false;
            }
            if (string.IsNullOrEmpty(txtAltura.Text))
            {
                MessageBox.Show("Ingrese la Altura ", "CONTROL DE CAMPO");
                aux = false;
            }

            if (cboBarrios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un barrio ", "CONTROL DE CAMPO");
                aux = false;
            }
            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                MessageBox.Show("Ingrese el Nro documento  ", "CONTROL DE CAMPO");
                aux = false;
            }

            if (cboTipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccion el tipo de documento  ", "CONTROL DE CAMPO");
                aux = false;
            }
            if (cboCIva.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccion la condicion de iva  ", "CONTROL DE CAMPO");
                aux = false;
            }


            return aux;
        }
        private void CargarCombo(ComboBox Cbo, List<Items> lst)
        {
            Cbo.DataSource = lst;
            Cbo.ValueMember = "Id";
            Cbo.DisplayMember = "Nombre";
            Cbo.DropDownStyle = ComboBoxStyle.DropDownList;

        }


        //Botones
        private void dgvListacl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListacl.CurrentCell.ColumnIndex == 10)
            {
                int nroCliente = Convert.ToInt32(dgvListacl.CurrentRow.Cells["NroCliente"].Value);

                CargarCamposClientes(nroCliente);
                gbboxCampos.Enabled = true;
                btnModificar.Enabled = true;
                btnNuevo.Enabled = false;
                btnCancelar.Enabled = true;
                btnSalir.Enabled = false;
                btnEliminar.Enabled = true;

            }

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir ?", "Confirmacion  ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            { this.Dispose(); }

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente nuevoCliente = new FrmNuevoCliente();
            nuevoCliente.ShowDialog();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente();


            if (ValidarCampos())
            {
                if (MessageBox.Show("Esta seguro que desea actualizar los campos del cliente", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    nuevo.Id = IdAModificar;
                    nuevo.Nombre = txtNombre.Text;
                    nuevo.Apellido = txtApellido.Text;
                    nuevo.Calle = txtCalle.Text;
                    nuevo.Altura = txtAltura.Text;
                    nuevo.Barrio = Convert.ToInt32(cboBarrios.SelectedValue);
                    nuevo.Documento = txtDocumento.Text;
                    nuevo.TipoDoc = Convert.ToInt32(cboTipoDoc.SelectedValue);
                    nuevo.CondicionIVA = Convert.ToInt32(cboCIva.SelectedValue);
                    nuevo.TipoCliente = Convert.ToInt32(cboTCliente.SelectedValue);

                    int control = Servicio.ModificarCliente(nuevo);
                    if (control == 1)
                    {
                        MessageBox.Show("Se registró modificacion con éxito el Cliente...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LimpiarCampos();

                        gbboxCampos.Enabled = false;
                        CargarListado();
                        btnNuevo.Enabled = true;
                        btnModificar.Enabled = false;
                        btnCancelar.Enabled = Enabled;

                    }
                    else
                    {
                        MessageBox.Show("NO se pudo actualizar el Cliente...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnNuevo.Enabled = true;
            btnModificar.Enabled = false;
            gbboxCampos.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalir.Enabled = true;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea dar de baja el cliente ?", "Confirmacion  ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                if (ValidarCampos())
                {

                    if (Servicio.BajaCliente(IdAModificar) == 1)
                    {
                        MessageBox.Show("Se Dio de baja con éxito el Cliente...", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        LimpiarCampos();
                        this.Dispose();

                        LimpiarCampos();
                        btnNuevo.Enabled = true;
                        btnModificar.Enabled = false;
                        gbboxCampos.Enabled = false;
                        btnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("NO se pudo dar de baja el Cliente...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }

        }
    }
}
