using System;
using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
using Automotriz.Servicio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automotriz.Servicio.Implementación;
using System.Data.SqlClient;

namespace Automotriz.Presentación.Soporte
{
    public partial class FrmConsultaCliente : Form
    {
        IServicioDAO Servicio;
        Items item;

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        public FrmConsultaCliente()
        {
            InitializeComponent();
            Servicio = new ServicioDAO();
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            btnCCliente.FlatStyle = FlatStyle.Flat;
            btnCCliente.FlatAppearance.BorderSize = 0;
            btnCDocumento.FlatStyle = FlatStyle.Flat;
            btnCDocumento.FlatAppearance.BorderSize = 0;
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
            btnVolver.Location = new Point(x, 280);
            btnCCliente.Location = new Point(x + 120, 280);
        }

        //Botones
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea regresar a la pantalla anterior?", "VOLVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        public void fillTable1()
        {
            var desde = dtpFechaDesde.Value.ToString("yyyy-MM-dd");
            var hasta = dtpFHasta.Value.ToString("yyyy-MM-dd");

            dgvClientes.DataSource = null;
            dgvClientes.Rows.Clear();

            DataTable dataTable = new DataTable();
            SqlConnection myConn = new SqlConnection("Data Source=34.176.166.122;Initial Catalog=Automotriz;User ID=sqlserver;Password=sqlserver");
            myConn.Open();
            SqlCommand myCmd = new SqlCommand("SP_CLIENTES_1", myConn);
            myCmd.CommandType = CommandType.StoredProcedure;
            myCmd.Parameters.AddWithValue("@fechaDesde", desde);
            myCmd.Parameters.AddWithValue("@fechaHasta", hasta);
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dataTable);
            dgvClientes.DataSource = dataTable;
        }

        public void fillTable2()
        {
            var desde = dtpFechaDesde.Value.ToString("yyyy-MM-dd");
            var hasta = dtpFechaHasta.Value.ToString("yyyy-MM-dd");

            dgvClientes.DataSource = null;
            dgvClientes.Rows.Clear();

            DataTable dataTable = new DataTable();
            SqlConnection myConn = new SqlConnection("Data Source=34.176.166.122;Initial Catalog=Automotriz;User ID=sqlserver;Password=sqlserver");
            myConn.Open();
            SqlCommand myCmd = new SqlCommand("SP_CLIENTES_2", myConn);
            myCmd.CommandType = CommandType.StoredProcedure;
            myCmd.Parameters.AddWithValue("@fechaDesde", desde);
            myCmd.Parameters.AddWithValue("@fechaHasta", hasta);
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dataTable);
            dgvClientes.DataSource = dataTable;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (chkCompro.Checked)
                this.fillTable1();
            else
                this.fillTable2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var desde = dtpFechaDesde.Value;
            var hasta = dtpFHasta.Value;

            dgvClientes.DataSource = null;
            dgvClientes.Rows.Clear();

            DataTable dataTable = new DataTable();
            SqlConnection myConn = new SqlConnection("Data Source=34.176.166.122;Initial Catalog=Automotriz;User ID=sqlserver;Password=sqlserver");
            myConn.Open();
            SqlCommand myCmd = new SqlCommand("SP_CLIENTES_3", myConn);
            myCmd.CommandType = CommandType.StoredProcedure;
            myCmd.Parameters.AddWithValue("@valorDesde", desde);
            myCmd.Parameters.AddWithValue("@valorHasta", hasta);
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dataTable);
            dgvClientes.DataSource = dataTable;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = null;
            dgvClientes.Rows.Clear();
        }

        private bool ValidarCampos()
        {
            bool aux = true;

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
          

            return aux;
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {

            dgvClientes.DataSource = null;
            dgvClientes.Rows.Clear();
            List<Parametro> lstparam = new List<Parametro>();
            List<Cliente> lstcliente = new List<Cliente>();

            if( ValidarCampos())
            {

                lstparam.Add(new Parametro("@nombre", txtNombre.Text));
                lstparam.Add(new Parametro("@apellido", txtApellido.Text ));

                lstcliente= Servicio.Consulta_ClNyP(lstparam);

            }


            dgvClientes.DataSource = lstcliente;



        }

        private void btnCCliente_Click(object sender, EventArgs e)
        {



            if (!string.IsNullOrEmpty(txtNroCliente.Text))
            {
                int id = Convert.ToInt32(txtNroCliente.Text);
                if(id!=0)
                {
                    Cliente c = Servicio.ExtraerClienteID(id);

                    dgvClientes.Rows.Add(new object[]
                    {

                    c.Id, c.Nombre, c.Apellido, c.Calle,c.Altura, 
                        ObtenerBarrio(c.Barrio), c.Documento, 
                        ObtenerTipoDocumento(c.TipoDoc),
                        ObtenerTipoCliente(c.TipoCliente),
                        ObtenerCondicionIva(c.CondicionIVA)
                    }
                    ) ;

                }
                else
                {
                    MessageBox.Show("ingrese un nro de id disinto de 0 ");
                }
            }
            else
            {
                MessageBox.Show("ingrese un nro de id");
            }
        }

        private string ObtenerTipoCliente(int nro)
        {
            string aux = "";

            List<Items> TipoCl = Servicio.ObtenerTipoCliente();

            foreach (Items item in TipoCl)
            {
                if (item.Id.Equals(nro))
                {
                    aux = item.Nombre;
                }
            }

            return aux;
        }

        private string ObtenerTipoDocumento(int nro)
        {
            string aux = "";

            List<Items> TipoDoc = Servicio.ObtenerTipoDoc();

            foreach (Items item in TipoDoc)
            {
                if (item.Id.Equals(nro))
                {
                    aux = item.Nombre;
                }
            }

            return aux;
        }

        private string  ObtenerCondicionIva(int nro)
        {
            string aux="";

            List<Items> CondIva = Servicio.ObtenerCondicionIVA();

            foreach (Items item in CondIva)
            {
                if (item.Id.Equals(nro))
                {
                    aux = item.Nombre;
                }


            }

            return aux;

        }

        private string ObtenerBarrio(int nro)
        {
            string barr="";
            List<Items> barrios= Servicio.ObtenerBarrios() ;

            foreach (Items item in barrios)
            {
                if(item.Id.Equals(nro))
                {
                    barr = item.Nombre;
                }


            }

            return barr;
        }

        private void btnCNombre_Click(object sender, EventArgs e)
        {



            if (!string.IsNullOrEmpty(txtNombre.Text)
            {


                string nom = txtNombre.Text;
                if (!string.IsNullOrEmpty(txtApellido.Text))
                {
                    Cliente c = Servicio.ExtraerClienteID(id);

                    dgvClientes.Rows.Add(new object[]
                    {

                    c.Id, c.Nombre, c.Apellido, c.Calle,c.Altura,
                        ObtenerBarrio(c.Barrio), c.Documento,
                        ObtenerTipoDocumento(c.TipoDoc),
                        ObtenerTipoCliente(c.TipoCliente),
                        ObtenerCondicionIva(c.CondicionIVA)
                    }
                    );

                }
                else
                {
                    MessageBox.Show("ingrese un nro de id disinto de 0 ");
                }
            }
            else
            {
                MessageBox.Show("ingrese un nro de id");
            }
        }







    }
}
}
