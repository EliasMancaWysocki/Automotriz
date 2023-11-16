﻿using System;
using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
using Automotriz.Servicio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automotriz.Servicio.Implementación;
using System.Data.SqlClient;

namespace Automotriz.Presentación.Soporte
{
    public partial class FrmConsultaProducto : Form
    {
        IServicioDAO Servicio;
        Items item;


        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        public FrmConsultaProducto()
        {
            InitializeComponent();
            Servicio = new ServicioDAO();
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
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
            btnConsultar.Location = new Point(x + 120, 280);
        }

        //Botones
        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        public void fillTable1()
        {

        }

        public void fillTable2()
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvProductos2.DataSource = null;
            dgvProductos2.Rows.Clear();

            DataTable dataTable = new DataTable();
            SqlConnection myConn = new SqlConnection("Data Source=34.176.166.122;Initial Catalog=Automotriz;User ID=sqlserver;Password=sqlserver");
            myConn.Open();
            SqlCommand myCmd = new SqlCommand("SP_PRODUCTOS_2", myConn);
            myCmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(myCmd);
            da.Fill(dataTable);
            dgvProductos2.DataSource = dataTable;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();

            dgvProductos2.DataSource = null;
            dgvProductos2.Rows.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea regresar a la pantalla anterior?", "VOLVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
