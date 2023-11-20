using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotriz.Servicio
{
    internal interface IServicioDAO
    {
        List<Items> ObtenerComprobantes();
        List<Items> ObtenerConceptos();
        List<Items> ObtenerActividades();
        List<Items> ObtenerCondicionIVA();
        List<Items> ObtenerTipoDoc();
        List<Items> ObtenerFormasPago();
        Cliente ExtraerCliente(string doc);
        List<Items> ObtenerTipoCliente();
        List<Items> ObtenerBarrios();
        int ProximoIdCliente();
        int ConfirmarCliente(Cliente cliente);
        List<ResultadoComprobante> FiltrarComprobantes(List<Parametro> parametros);
        List<Cliente> ListaCliente();
        int ModificarCliente(Cliente cliente);

        int BajaCliente(int nroCl);
        Cliente ExtraerClienteID(int id);
        List<Cliente> Consulta_ClNyP(List<Parametro> lstparam);


    }
}
