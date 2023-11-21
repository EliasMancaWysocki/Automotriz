using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
using AutomotrizFront.Servicio;
using AutomotrizFront.Servicio.Implementación;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AutomotrizFront.Presentación.Soporte
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
            CargarCombo(cboTipoDoc, Servicio.ObtenerTipoDoc());
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



        private void tabPage1_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = null;
            dgvClientes.Rows.Clear();
        }

        //pestaña por nro cliente
        private void btnCCliente_Click(object sender, EventArgs e)
        {



            if (!string.IsNullOrEmpty(txtNroCliente.Text))
            {
                int id = Convert.ToInt32(txtNroCliente.Text);
                if (id != 0)
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

        //carga de combos a grillas
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

        private string ObtenerCondicionIva(int nro)
        {
            string aux = "";

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
            string barr = "";
            List<Items> barrios = Servicio.ObtenerBarrios();

            foreach (Items item in barrios)
            {
                if (item.Id.Equals(nro))
                {
                    barr = item.Nombre;
                }


            }

            return barr;
        }

        //pestaña por nombre
        private void btnCNombre_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtNombre.Text))
            {

                string nom = txtNroCliente.Text;

                if (!string.IsNullOrEmpty(txtApellido.Text))
                {
                    string apell = txtApellido.Text;

                    List<Cliente> lstc = Servicio.ExtraerClienteNombre(nom, apell);

                    if (lstc.Count == 0)
                    {
                        MessageBox.Show("Los datos cargados no generaron resultados ");
                    }
                    else
                    {
                        foreach (var c in lstc)
                        {
                            dgvClientes.Rows.Add(new object[]
                            {
                                c.Id, c.Nombre, c.Apellido, c.Calle,c.Altura,
                                ObtenerBarrio(c.Barrio), c.Documento,
                                ObtenerTipoDocumento(c.TipoDoc),
                                ObtenerTipoCliente(c.TipoCliente),
                                ObtenerCondicionIva(c.CondicionIVA)
                            });
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ingrese un apellido ");
                }
            }
            else
            {
                MessageBox.Show("ingrese un nombre");
            }
        }



        //pestaña por documento
        private void btnCDocumento_Click(object sender, EventArgs e)
        {

            if (cboTipoDoc.SelectedIndex != -1)
            {

                int tipdoc = Convert.ToInt32(cboTipoDoc.SelectedValue);

                if (!string.IsNullOrEmpty(txtDocumento.Text))
                {
                    string doc = txtDocumento.Text;

                    Cliente c = Servicio.ExtraerClienteDocumento(tipdoc, doc);

                    if (c.Id == 0)
                    {
                        MessageBox.Show("Los datos cargados no generaron resultados ");
                    }
                    else
                    {
                        dgvClientes.Rows.Add(new object[]
                        {
                            c.Id, c.Nombre, c.Apellido, c.Calle,c.Altura,
                            ObtenerBarrio(c.Barrio), c.Documento,
                            ObtenerTipoDocumento(c.TipoDoc),
                            ObtenerTipoCliente(c.TipoCliente),
                            ObtenerCondicionIva(c.CondicionIVA)
                        });
                    }

                }
                else
                {
                    MessageBox.Show("ingrese un nro de documento ");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de nro de documento");
            }



        }

        //boton limpiar
        private void cbnLimpiar_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = null;
            dgvClientes.Rows.Clear();
            txtApellido.Text = string.Empty;
            txtNroCliente.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDocumento.Text = string.Empty;
            cboTipoDoc.SelectedIndex = -1;
            dgvClientes.Columns["Precio_Total"].Visible = false;
            chCompro.Checked = false;

        }

      
        
        //pestaña por fecha
        private void btnCCompro_Click(object sender, EventArgs e)
        {
            if (chkCompro.Checked)
            {

                string desde = dtpFechaDesde.Value.ToString("yyyyMMdd");
                string hasta = dtpFechaHasta.Value.ToString(("yyyyMMdd"));

                List<Cliente> lstc = Servicio.ExtraerClienteCompro(desde, hasta);

                if (lstc.Count == 0)
                {
                    MessageBox.Show("Los datos cargados no generaron resultados ");
                }
                else
                {

                    foreach (Cliente c in lstc)
                    {

                        dgvClientes.Rows.Add(new object[]
                                                {
                            c.Id, c.Nombre, c.Apellido, c.Calle,c.Altura,
                            ObtenerBarrio(c.Barrio), c.Documento,
                            ObtenerTipoDocumento(c.TipoDoc),
                            ObtenerTipoCliente(c.TipoCliente),
                            ObtenerCondicionIva(c.CondicionIVA)
                                               });

                    }

                }

            }

            else//clientes que no pagaron
            {

                string desde = dtpFechaDesde.Value.ToString("yyyyMMdd");
                string hasta = dtpFechaHasta.Value.ToString(("yyyyMMdd"));

                List<Cliente> lstc = Servicio.ExtraerClienteNoCompro(desde, hasta);

                if (lstc.Count == 0)
                {
                    MessageBox.Show("Los datos cargados no generaron resultados ");
                }
                else
                {

                    foreach (Cliente c in lstc)
                    {

                        dgvClientes.Rows.Add(new object[]
                                                {
                            c.Id, c.Nombre, c.Apellido, c.Calle,c.Altura,
                            ObtenerBarrio(c.Barrio), c.Documento,
                            ObtenerTipoDocumento(c.TipoDoc),
                            ObtenerTipoCliente(c.TipoCliente),
                            ObtenerCondicionIva(c.CondicionIVA)
                                               });
                        
                    }

                }

            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Now.AddDays(-7);
            dtpFechaHasta.Value = DateTime.Now;
        }
    }
}

