using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automotriz.Presentación.Soporte;
using AutomotrizFront.Presentación.Soporte;
using Automotriz.Presentación.Consultas.Consultar_Comprobantes;
using AutomotrizFront.Presentación.Soporte.Vendedores;
using Automotriz.Presentación.Soporte.Vendedores;

namespace Automotriz.Presentación
{
    public partial class FrmAutomotriz : Form
    {
        public FrmAutomotriz()
        {
            InitializeComponent();
        }

        private void FrmAutomotriz_Load(object sender, EventArgs e)
        {
            CentrarTitulo(panelTitulo, lblAutomotrix);
            CentrarTitulo(panelNuevoClienteTitle, lblNuevoCliente);
            CentrarTitulo(panelConsultarClientesTitle, lblConsultarClientes);
            EndResponsive();
        }

        //Funciones
        private void CentrarTitulo(Panel panel, Label lbl)
        {
            int x = (panel.Width - lbl.Width) / 2;

            lbl.Location = new Point(x, 15);
        }
        private void ResponsiveButton(Panel panel, Label lbl, int padding, Font font)
        {
            panel.Padding = new Padding(padding);
            lbl.Font = font;
            CentrarTitulo(panel, lbl);
        }
        private void EndResponsive()
        {
            Font SmallFont = new Font("Times New Roman", 9, FontStyle.Bold);
            Font MediumFont = new Font("Times New Roman", 12, FontStyle.Bold);
            Font LargeFont = new Font("Times New Roman", 18, FontStyle.Bold);

            if (Width > 1200)
            {
                //Botones Clientes
                ResponsiveButton(panelNuevoClienteBody, lblNuevoCliente, 25, LargeFont);
                ResponsiveButton(panelConsultarClientesBody, lblConsultarClientes, 25, LargeFont);
                //Botones Comprobantes
                ResponsiveButton(panelNuevoComprobanteBody, lblNuevoComprobante, 25, LargeFont);
                ResponsiveButton(panelConsultarComprobantesBody, lblConsultarComprobantes, 25, LargeFont);
                //Botones Productos
                ResponsiveButton(panelNuevoProductoBody, lblNuevoProducto, 25, LargeFont);
                ResponsiveButton(panelConsultarProductosBody, lblConsultarProductos, 25, LargeFont);
                //Botones Empleados
                ResponsiveButton(panelNuevoEmpleadoBody, lblNuevoEmpleado, 25, LargeFont);
                ResponsiveButton(panelConsultarEmpleadosBody, lblConsultarEmpleados, 25, LargeFont);
                //Boton Cerrar Sesion
                ResponsiveButton(panelCerrarSesionBody, lblCerrarSesion, 25, LargeFont);

            }
            else if (Width <= 1200)
            {
                //Botones Clientes
                ResponsiveButton(panelNuevoClienteBody, lblNuevoCliente, 15, MediumFont);
                ResponsiveButton(panelConsultarClientesBody, lblConsultarClientes, 15, MediumFont);
                //Botones Comprobantes
                ResponsiveButton(panelNuevoComprobanteBody, lblNuevoComprobante, 15, MediumFont);
                ResponsiveButton(panelConsultarComprobantesBody, lblConsultarComprobantes, 15, MediumFont);
                //Botones Productos
                ResponsiveButton(panelNuevoProductoBody, lblNuevoProducto, 15, MediumFont);
                ResponsiveButton(panelConsultarProductosBody, lblConsultarProductos, 15, MediumFont);
                //Botones Empleados
                ResponsiveButton(panelNuevoEmpleadoBody, lblNuevoEmpleado, 15, MediumFont);
                ResponsiveButton(panelConsultarEmpleadosBody, lblConsultarEmpleados, 15, MediumFont);
                //Boton Cerrar Sesion
                ResponsiveButton(panelCerrarSesionBody, lblCerrarSesion, 15, MediumFont);
            }
            else if (Width <= 992)
            {
                //Botones Clientes
                ResponsiveButton(panelNuevoClienteBody, lblNuevoCliente, 5, SmallFont);
                ResponsiveButton(panelConsultarClientesBody, lblConsultarClientes, 5, SmallFont);
                //Botones Productos
                ResponsiveButton(panelNuevoComprobanteBody, lblNuevoComprobante, 5, SmallFont);
                ResponsiveButton(panelConsultarComprobantesBody, lblConsultarComprobantes, 5, SmallFont);
                //Botones Productos
                ResponsiveButton(panelNuevoProductoBody, lblNuevoProducto, 5, SmallFont);
                ResponsiveButton(panelConsultarProductosBody, lblConsultarProductos, 5, SmallFont);
                //Botones Empleados
                ResponsiveButton(panelNuevoEmpleadoBody, lblNuevoEmpleado, 5, SmallFont);
                ResponsiveButton(panelConsultarEmpleadosBody, lblConsultarEmpleados, 5, SmallFont);
                //Boton Cerrar Sesion
                ResponsiveButton(panelCerrarSesionBody, lblCerrarSesion, 5, SmallFont);
            }
        }


        //Botones Menu Strip
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizarCliente cliente = new FrmActualizarCliente();
            cliente.ShowDialog();
        }
        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDatosEmisor frmDatosEmisor = new FrmDatosEmisor();
            frmDatosEmisor.ShowDialog();
        }
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaComprobantes frmConsultaComprobantes = new FrmConsultaComprobantes();
            frmConsultaComprobantes.ShowDialog();
        }
        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente frmConsultaCliente = new FrmConsultaCliente();
            frmConsultaCliente.ShowDialog();
        }
        private void btnConsultarProductos_Click(object sender, EventArgs e)
        {
            FrmConsultaProducto frmConsultaProducto = new FrmConsultaProducto();
            frmConsultaProducto.ShowDialog();
        }
        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaProducto frmConsultaProductos = new FrmConsultaProducto();
            frmConsultaProductos.ShowDialog();
        }
        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInformacion frmInformacion = new FrmInformacion();
            frmInformacion.ShowDialog();
        }
        private void nuevoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmDatosEmisor frmDatosEmisor = new FrmDatosEmisor();
            frmDatosEmisor.ShowDialog();
        }
        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmDatosEmisor frmDatosEmisor = new FrmDatosEmisor();
            frmDatosEmisor.ShowDialog();
        }
        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConsultaComprobantes frmConsultaComprobantes = new FrmConsultaComprobantes();
            frmConsultaComprobantes.ShowDialog();
        }

        //Botones
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente nuevoCliente = new FrmNuevoCliente();
            nuevoCliente.ShowDialog();
        }
        private void btnNuevoComprobante_Click(object sender, EventArgs e)
        {
            FrmDatosEmisor frmDatosEmisor = new FrmDatosEmisor();
            frmDatosEmisor.ShowDialog();
        }
        private void btnConsultarComprobantes_Click(object sender, EventArgs e)
        {
            FrmConsultaComprobantes frmConsultaComprobantes = new FrmConsultaComprobantes();
            frmConsultaComprobantes.ShowDialog();
        }
        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente frmConsultaCliente = new FrmConsultaCliente();
            frmConsultaCliente.ShowDialog();
        }
        private void btnConsultarEmpleados_Click(object sender, EventArgs e)
        {
            FrmConsultaEmpleado frmConsultaEmpleado = new FrmConsultaEmpleado();
            frmConsultaEmpleado.ShowDialog();
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "CERRAR SESIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void panelLogo_Click(object sender, EventArgs e)
        {
            FrmInformacion frmInformacion = new FrmInformacion();
            frmInformacion.ShowDialog();
        }

        //Eventos
        private void FrmAutomotriz_ResizeEnd(object sender, EventArgs e)
        {
            EndResponsive();
        }

    }
}
