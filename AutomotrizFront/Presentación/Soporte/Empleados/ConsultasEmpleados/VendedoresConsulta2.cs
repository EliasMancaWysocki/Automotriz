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

namespace AutomotrizFront.Presentación.Soporte.Vendedores
{
    public partial class VendedoresConsulta2 : Form
    {
        public VendedoresConsulta2()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.fillTable1();
        }

        public void fillTable1()
        {
            dgvVendedores.DataSource = null;
            dgvVendedores.Rows.Clear();

            DataTable dataTable = new DataTable();
            SqlConnection myConn = new SqlConnection("Data Source=34.176.166.122;Initial Catalog=Automotriz;User ID=sqlserver;Password=sqlserver");
            myConn.Open();
            SqlCommand myCmd = new SqlCommand("SP_VENDEDORES_2", myConn);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dataTable);
            dgvVendedores.DataSource = dataTable;
        }

        private void VendedoresConsulta2_Load(object sender, EventArgs e)
        {

        }
    }
}
