using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace AutomotrizBack.Datos
{
    public class ComprobantesDAO : IComprobantesDAO
    {
        public List<Items> ObtenerComprobantes()
        {
            List<Items> comprobantes = new List<Items>();

            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_TIPOS_FACTURAS");

            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_tipo_factura"]);
                string nom = dr["descripcion"].ToString();

                Items item = new Items(id, nom);
                comprobantes.Add(item);
            }

            comprobantes.Add(new Items(3, "Nota de Débito A"));
            comprobantes.Add(new Items(4, "Nota de Débito B"));
            comprobantes.Add(new Items(5, "Nota de Crédito A"));
            comprobantes.Add(new Items(6, "Nota de Crédito B"));

            return comprobantes;
        }
        public List<Items> ObtenerConceptos() 
        {
            List<Items> comprobantes = new List<Items>()
            {
                new Items(1, "Productos"),
                new Items(2, "Servicios"),
                new Items(3, "Productos y Servicios"),
            };

            return comprobantes;
        }
        public List<Items> ObtenerActividades()
        {
            List<Items> actividades = new List<Items>()
            {
                new Items(1, "453100 - Venta al por mayor de partes, piezas y accesorios de vehículos automotores"),
                new Items(2, "453210 - Venta al por menor de cámaras y cubiertas"),
                new Items(3, "453220 - Venta al por menor de baterías"),
                new Items(4, "453291 - Venta al por menor de partes, piezas y accesorios nuevos n.c.p.")
            };

            return actividades;
        }
        public List<Items> ObtenerCondicionIVA()
        {
            List<Items> lst = new List<Items>();

            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_CONDICIONIVA ");

            foreach(DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_condicionIVA"]);
                string nom = dr["descripcion"].ToString();

                Items item = new Items(id, nom);
                lst.Add(item);
            }
            return lst;
        }
        public List<Items> ObtenerTipoDoc()
        {
            List <Items> lst = new List<Items>();

            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_TIPOSDOC");

            foreach(DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_tipo_documento"]);
                string nom = dr["descripcion"].ToString();

                Items item = new Items(id, nom);
                lst.Add(item);
            }

            return lst;
        }
        public List<Items> ObtenerFormasPago()
        {
            List<Items> lst = new List<Items>();

            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_FORMASPAGO");

            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_forma_pago"]);
                string nom = dr["forma_pago"].ToString();
                double recargo = Convert.ToDouble(dr["recargo"]);

                Items item = new Items(id, nom, recargo);
                lst.Add(item);
            }

            return lst;
        }
        public Cliente ExtraerCliente(string doc)
        {
            List<Parametro> lst = new List<Parametro>()
            {
                new Parametro("@documento", doc)
            };
            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_EXTRAER_CLIENTE", lst);

            Cliente c = new Cliente();

            foreach (DataRow dr in dt.Rows)
            {
                c.Id = Convert.ToInt32(dr["id_cliente"]);
                c.Nombre = dr["nombre"].ToString();
                c.Apellido = dr["apellido"].ToString();
                c.Calle = dr["calle"].ToString();
                c.Altura = dr["altura"].ToString();
                c.Barrio = Convert.ToInt32(dr["id_barrio"]);
                c.Documento = dr["documento"].ToString();
                c.TipoDoc = Convert.ToInt32(dr["tipo_documento"]);
                c.TipoCliente = Convert.ToInt32(dr["tipo_cliente"]);
                c.CondicionIVA = Convert.ToInt32(dr["condicion_IVA"]);
            }

            return c;
        }
        public int ProximoIdCliente()
        {
            int proximo = DBHelper.ObtenerInstancia().ConsultarEscalar ("SP_PROXIMO_ID_CLIENTE", "@next");

            return proximo;
        }
        public int ConfirmarCliente(Cliente nuevo)
        {
            int aux = 0;

            List<Parametro> lstParametros = new List<Parametro>(){
                new Parametro("@nombre", nuevo.Nombre),
                new Parametro("@apellido", nuevo.Apellido),
                new Parametro("@altura", nuevo.Altura),
                new Parametro("@id_Barrio", nuevo.Barrio),
                new Parametro("@calle", nuevo.Calle),
                new Parametro("@documento", nuevo.Documento),
                new Parametro("@id_tipo_documento", nuevo.TipoDoc),
                new Parametro("@id_tipo_de_cliente", nuevo.TipoCliente),
                new Parametro("@id_condicionIVA", nuevo.CondicionIVA)
            };

            aux = DBHelper.ObtenerInstancia().ActualizarBD("SP_INSERTAR_CLIENTE", lstParametros);

            return aux;
        }
        public List<Items> ObtenerTipoCliente()
        {
            List < Items > lst = new List<Items> ();
            return lst;
        }
        public List<Items> ObtenerBarrios()
        {
            List<Items> lst = new List<Items>();
            return lst;
        }
        public List<ResultadoComprobante> FiltrarComprobantes(List<Parametro> parametros)
        {
            List<ResultadoComprobante> lst = new List<ResultadoComprobante> ();

            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_FILTRAR_COMPROBANTE", parametros);

            foreach (DataRow dr in dt.Rows)
            {
                ResultadoComprobante rc = new ResultadoComprobante();

                rc.NumComprobante = Convert.ToInt32(dr["num_factura"]);
                rc.FechaEmision = Convert.ToDateTime(dr["fecha"]);
                rc.Documento = dr["documento"].ToString();
                rc.TipoDoc = dr["tipoDoc"].ToString();
                rc.Importe = Convert.ToInt32(dr["importeTotal"]);

                lst.Add(rc);
            }
            return lst;
        }
    }
}

