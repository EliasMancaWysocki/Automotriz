using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotriz.Servicio.Implementación
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

        public List<Cliente> ListaCliente()
        {
            return DAO.ListaCliente();
        }
        public int ModificarCliente(Cliente cliente)
        {
            return DAO.ModificarCliente(cliente);
        }
        public int BajaCliente(int nroCl)
        {
            return DAO.BajaCliente(nroCl);
        }
        

        public Cliente ExtraerClienteID(int id)
        {
            return DAO.ExtraerClienteID(id);
        }

        public List<Cliente> Consulta_ClNyP(List<Parametro> lstparam)
        {
            return DAO.Consulta_ClNyP(lstparam);
        }
    }
}
