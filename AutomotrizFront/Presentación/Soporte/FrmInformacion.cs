using System;
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
    public partial class FrmInformacion : Form
    {
        public FrmInformacion()
        {
            InitializeComponent();
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s1 = label4.Text;
            string s2 = s1.Substring(0, 1);
            string s3 = s1.Substring(1, s1.Length -1);
            string s4 = s3 + s2;

            label4.Text = s4;

            string s5 = label5.Text;
            string s6 = s1.Substring(0, 1);
            string s7 = s1.Substring(1, s5.Length - 1);
            string s8 = s7 + s6;

            label5.Text = s8;
        }
    }
}
