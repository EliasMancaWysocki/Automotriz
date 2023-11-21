﻿using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizFront.Servicio.Implementación
{
    internal class ServicioDAO : IServicioDAO
    {
        private IComprobantesDAO DAO;

        public ServicioDAO()
        {
            DAO = new ComprobantesDAO();
        }

        public List<Items> ObtenerComprobantes()
        {
            return DAO.ObtenerComprobantes();
        }
        public List<Items> ObtenerConceptos()
        {
            return DAO.ObtenerConceptos();
        }
        public List<Items> ObtenerActividades()
        {
            return DAO.ObtenerActividades();
        }
        public List<Items> ObtenerCondicionIVA()
        {
            return DAO.ObtenerCondicionIVA();
        }
        public List<Items> ObtenerTipoDoc()
        {
            return DAO.ObtenerTipoDoc();
        }
        public List<Items> ObtenerFormasPago()
        {
            return DAO.ObtenerFormasPago();
        }
        public Cliente ExtraerCliente(string doc)
        {
            return DAO.ExtraerCliente(doc);
        }
        public List<Items> ObtenerTipoCliente()
        {
            return DAO.ObtenerTipoCliente();
        }
        public List<Items> ObtenerBarrios()
        {
            return DAO.ObtenerBarrios();
        }
        public int ProximoIdCliente()
        {
            return DAO.ProximoIdCliente();
        }
        public int ConfirmarCliente(Cliente cliente)
        {
            return DAO.ConfirmarCliente(cliente);
        }
        public List<ResultadoComprobante> FiltrarComprobantes(List<Parametro> parametros)
        {
            return DAO.FiltrarComprobantes(parametros);
        }
        public List<Items> ObtenerProductos(int tipoProd)
        {
            return DAO.ObtenerProductos(tipoProd);
        }
        public List<Cliente> ListaCliente()
        {
            return DAO.ListaCliente();
        }
        public int ModificarCliente(Cliente cliente)
        {
            return DAO.ModificarCliente(cliente);
        }
        public List<Items> ObtenerUnidadesMedidas()
        {
            return DAO.ObtenerUnidadesMedidas();
        }
        public int BajaCliente(int nroCl)
        {
            return DAO.BajaCliente(nroCl);
        }
        public Cliente ExtraerClienteID(int id)
        {
            return DAO.ExtraerClienteID(id);
        }
        public Producto ExtraerProducto(int codigo)
        {
            return DAO.ExtraerProducto(codigo);
        }
        public List<Items> ObtenerDescuentos()
        {
            return DAO.ObtenerDescuentos();
        }
        public List<Items> ObtenerAutoplanes()
        {
            return DAO.ObtenerAutoplanes();
        }
        public List<Items> ObtenerTiposProductos()
        {
            return DAO.ObtenerTiposProductos();
        }
    }
}
