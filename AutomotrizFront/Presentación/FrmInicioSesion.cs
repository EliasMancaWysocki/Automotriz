using AutomotrizBack.Entidades;
using AutomotrizFront.Servicio;
using AutomotrizFront.Servicio.Implementación;
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
        IServicioDAO Servicio;
        public FrmInicioSesion()
        {
            InitializeComponent();
            Servicio = new ServicioDAO();
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
            bool permiso = false;
            foreach (Items i in Servicio.ObtenerInicioSesion())
            {
                if(i.Nombre == txtUser.Text)
                {
                    if(i.Extra.ToString() == txtPass.Text)
                    {
                        permiso = true;
                    }
                }
            }
            if(permiso)
            {
                FrmAutomotriz frmAutomotriz = new FrmAutomotriz();
                frmAutomotriz.ShowDialog();
                Dispose();
            } else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }
    }
}
