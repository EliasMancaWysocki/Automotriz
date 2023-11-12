using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
using Automotriz.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotriz.Presentación
{
    public partial class FrmDatosOperacion : Form
    {
        IServicioDAO Servicio;
        Comprobante comprobante;
        Items item;
        
        public FrmDatosOperacion(Items item, Comprobante comprobante)
        {
            InitializeComponent();
            this.item = item;
            this.comprobante = comprobante;
        }

        private void FrmDatosOperacion_Load(object sender, EventArgs e)
        {

        }
    }
}
