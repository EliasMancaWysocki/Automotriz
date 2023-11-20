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

namespace AutomotrizFront.Presentación.Soporte.ProductosStock
{
    public partial class ProductosStockConsulta1 : Form
    {
        public ProductosStockConsulta1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.fillTable1();
        }

        public void fillTable1()
        {
            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();

            DataTable dataTable = new DataTable();
            SqlConnection myConn = new SqlConnection("Data Source=34.176.166.122;Initial Catalog=Automotriz;User ID=sqlserver;Password=sqlserver");
            myConn.Open();
            SqlCommand myCmd = new SqlCommand("SP_PRODUCTOS_1", myConn);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dataTable);
            dgvProductos.DataSource = dataTable;
        }

        private void ProductosStockConsulta1_Load(object sender, EventArgs e)
        {

        }
    }
}
