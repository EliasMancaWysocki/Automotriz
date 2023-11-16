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
                ResponsiveButton(panelEliminarClienteBody, lblEliminarCliente, 25, LargeFont);
                //Botones Comprobantes
                ResponsiveButton(panelNuevoComprobanteBody, lblNuevoComprobante, 25, LargeFont);
                ResponsiveButton(panelConsultarComprobantesBody, lblConsultarComprobantes, 25, LargeFont);
                //Botones Productos
                ResponsiveButton(panelNuevoProductoBody, lblNuevoProducto, 25, LargeFont);
                ResponsiveButton(panelConsultarProductosBody, lblConsultarProductos, 25, LargeFont);
                ResponsiveButton(panelEliminarProductoBody, lblEliminarProducto, 25, LargeFont);
                //Botones Empleados
                ResponsiveButton(panelNuevoEmpleadoBody, lblNuevoEmpleado, 25, LargeFont);
                ResponsiveButton(panelConsultarEmpleadosBody, lblConsultarEmpleados, 25, LargeFont);
                ResponsiveButton(panelEliminarEmpleadoBody, lblEliminarEmpleado, 25, LargeFont);

            }
            else if (Width <= 1200)
            {
                //Botones Clientes
                ResponsiveButton(panelNuevoClienteBody, lblNuevoCliente, 15, MediumFont);
                ResponsiveButton(panelConsultarClientesBody, lblConsultarClientes, 15, MediumFont);
                ResponsiveButton(panelEliminarClienteBody, lblEliminarCliente, 15, MediumFont);
                //Botones Comprobantes
                ResponsiveButton(panelNuevoComprobanteBody, lblNuevoComprobante, 15, MediumFont);
                ResponsiveButton(panelConsultarComprobantesBody, lblConsultarComprobantes, 15, MediumFont);
                //Botones Productos
                ResponsiveButton(panelNuevoProductoBody, lblNuevoProducto, 15, MediumFont);
                ResponsiveButton(panelConsultarProductosBody, lblConsultarProductos, 15, MediumFont);
                ResponsiveButton(panelEliminarProductoBody, lblEliminarProducto, 15, MediumFont);
                //Botones Empleados
                ResponsiveButton(panelNuevoEmpleadoBody, lblNuevoEmpleado, 15, MediumFont);
                ResponsiveButton(panelConsultarEmpleadosBody, lblConsultarEmpleados, 15, MediumFont);
                ResponsiveButton(panelEliminarEmpleadoBody, lblEliminarEmpleado, 15, MediumFont);
            }
            else if (Width <= 992)
            {
                //Botones Clientes
                ResponsiveButton(panelNuevoClienteBody, lblNuevoCliente, 5, SmallFont);
                ResponsiveButton(panelConsultarClientesBody, lblConsultarClientes, 5, SmallFont);
                ResponsiveButton(panelEliminarClienteBody, lblEliminarCliente, 5, SmallFont);
                //Botones Productos
                ResponsiveButton(panelNuevoComprobanteBody, lblNuevoComprobante, 5, SmallFont);
                ResponsiveButton(panelConsultarComprobantesBody, lblConsultarComprobantes, 5, SmallFont);
                //Botones Productos
                ResponsiveButton(panelNuevoProductoBody, lblNuevoProducto, 5, SmallFont);
                ResponsiveButton(panelConsultarProductosBody, lblConsultarProductos, 5, SmallFont);
                ResponsiveButton(panelEliminarProductoBody, lblEliminarProducto, 5, SmallFont);
                //Botones Empleados
                ResponsiveButton(panelNuevoEmpleadoBody, lblNuevoEmpleado, 5, SmallFont);
                ResponsiveButton(panelConsultarEmpleadosBody, lblConsultarEmpleados, 5, SmallFont);
                ResponsiveButton(panelEliminarEmpleadoBody, lblEliminarEmpleado, 5, SmallFont);
            }
        }


        //Botones Menu Strip
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
            FrmGeneracionComprobantes frmGeneracionComprobantes = new FrmGeneracionComprobantes();
            frmGeneracionComprobantes.ShowDialog();
        }
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
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
            FrmGeneracionComprobantes frmGeneracionComprobantes = new FrmGeneracionComprobantes();
            frmGeneracionComprobantes.ShowDialog();
        }
        private void btnConsultarComprobantes_Click(object sender, EventArgs e)
        {
            FrmConsultaComprobantes frmConsultaComprobantes = new FrmConsultaComprobantes();
            frmConsultaComprobantes.ShowDialog();
        }
        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deja de joder con el botoncito", "DEJA DE JODER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Eventos
        private void FrmAutomotriz_ResizeEnd(object sender, EventArgs e)
        {
            EndResponsive();
        }
    }
}
