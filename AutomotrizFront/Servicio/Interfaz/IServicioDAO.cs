using AutomotrizBack.Datos;
using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizFront.Servicio
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
        List<Items> ObtenerProductos(int tipoProd);
        List<Items> ObtenerUnidadesMedidas();
        int BajaCliente(int nroCl);
        Cliente ExtraerClienteID(int id);
        Producto ExtraerProducto(int codigo);
        List<Items> ObtenerDescuentos();
        List<Items> ObtenerAutoplanes();
        List<Items> ObtenerTiposProductos();
    }
}
