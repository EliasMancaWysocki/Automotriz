using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos
{
    public interface IComprobantesDAO
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
        
        List<Items> ObtenerProductos();
        List<Items> ObtenerUnidadesMedidas();
        List<Cliente> ExtraerClienteNombre(string nom, string apell);
        Cliente ExtraerClienteDocumento(int tipdoc, string doc);
        List<Cliente> ExtraerClienteNoCompro(string desde, string hasta);
        List<Cliente> ExtraerClienteCompro(string desde, string hasta);



    }
}
