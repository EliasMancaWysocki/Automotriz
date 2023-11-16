using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront.Presentación
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
            CentrarTitulo();
            CentrarBotones();
        }

        //Funciones
        private void CentrarTitulo()
        {
            int x = (Width - 15 - lblIniciarSesion.Width) / 2;
            lblIniciarSesion.Location = new Point(x, 25);
        }
        private void CentrarBotones()
        {
            int x = (Width - 15 - 225) / 2;
            btnSalir.Location = new Point(x, 210);
            btnIniciarSesion.Location = new Point(x + 120, 210);
        }

        //Botones
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

        }
    }
}
