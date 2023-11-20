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
    public partial class ClientesConsulta2 : Form
    {
        public ClientesConsulta2()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.fillTable1();
        }

        public void fillTable1()
        {
            var desde = nudDesde.Value;
            var hasta = nudHasta.Value;

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

        private void ClientesConsulta2_Load(object sender, EventArgs e)
        {

        }
    }
}
