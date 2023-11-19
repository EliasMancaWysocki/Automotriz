using Automotriz.Presentación.Consultas.Consultar_Comprobantes;
using Automotriz.Servicio;
using Automotriz.Servicio.Implementación;
using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront.Presentación.Soporte.Clientes
{
    public partial class ClientesConsulta1 : Form
    {
        IServicioDAO Servicio;
        List<Parametro> resultadosClientes;
        public ClientesConsulta1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (chkCompro.Checked)
                this.fillTable1();
            else
                this.fillTable2();
        }

        public void fillTable1()
        {
            var desde = dtpFechaDesde.Value.ToString("yyyy-MM-dd");
            var hasta = dtpFechaHasta.Value.ToString("yyyy-MM-dd");

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
    }
}
