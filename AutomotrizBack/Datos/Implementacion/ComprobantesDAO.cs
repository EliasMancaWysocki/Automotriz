using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace AutomotrizBack.Datos
{
    public class ComprobantesDAO : IComprobantesDAO
    {
        //Obtener
        public List<Items> ObtenerComprobantes()
        {
            List<Items> comprobantes = new List<Items>()
            {
                new Items(1, "Factura A"),
                new Items(2, "Factura B"),
                new Items(3, "Nota de Débito A"),
                new Items(4, "Nota de Débito B"),
                new Items(5, "Nota de Crédito A"),
                new Items(6, "Nota de Crédito B"),
            };

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
        public List<Items> ObtenerBarrios()
        {
            List<Items> lst = new List<Items>();

            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_BARRIOS");

            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_barrio"]);
                string nom = dr["nombre_barrio"].ToString();
                int loc = Convert.ToInt32(dr["id_localidad"].ToString());

                Items item = new Items(id, nom, loc);
                lst.Add(item);
            }
            return lst;


        }
        public List<Items> ObtenerTipoCliente()
        {
            List<Items> lst = new List<Items>();

            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_TIPOSCLIENTES");

            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_tipo_cliente"]);
                string nom = dr["descripcion"].ToString();


                Items item = new Items(id, nom);
                lst.Add(item);
            }
            return lst;
        }
        public List<Items> ObtenerProductos()
        {
            List<Items> lst = new List<Items>();

            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_PORDUCTOS");

            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["cod_producto"]);
                string nom = dr["descripcion"].ToString();

                Items item = new Items(id, nom);
                lst.Add(item);
            }
            return lst;
        }
        public List<Items> ObtenerUnidadesMedidas() 
        {
            List<Items> lst = new List<Items>();

            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_UnMEDIDA");

            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_un_med"]);
                string nom = dr["descripcion"].ToString();

                Items item = new Items(id, nom);
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
                c.Documento = dr["id_barrio"].ToString();
                c.TipoDoc = Convert.ToInt32(dr["id_tipo_documento"]);
                c.TipoCliente = Convert.ToInt32(dr["id_tipo_de_cliente"]);
                c.CondicionIVA = Convert.ToInt32(dr["id_condicionIVA"]);
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
        public List<Cliente> ListaCliente()
        {
           
            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_CLIENTES");

            List<Cliente> lst = new List<Cliente>();

            foreach (DataRow dr in dt.Rows)
            {
                Cliente c = new Cliente();
                c.Id = Convert.ToInt32(dr["id_cliente"]);
                c.Nombre = dr["nombre"].ToString();
                c.Apellido = dr["apellido"].ToString();
                c.Calle = dr["calle"].ToString();
                c.Altura = dr["altura"].ToString();
                c.Barrio = Convert.ToInt32(dr["id_Barrio"].ToString());
                c.Documento = dr["documento"].ToString();
                c.TipoDoc = Convert.ToInt32(dr["id_tipo_documento"].ToString());
                c.TipoCliente = Convert.ToInt32(dr["id_tipo_de_cliente"].ToString());
                c.CondicionIVA = Convert.ToInt32(dr["id_condicionIVA"].ToString());

                lst.Add(c);

            }

            return lst;
        }
        public int ModificarCliente(Cliente nuevo)
        {
            int aux = 0;

            List<Parametro> lstParametros = new List<Parametro>(){
                new Parametro("@id_cliente", nuevo.Id),
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

            aux = DBHelper.ObtenerInstancia().ActualizarBD("SP_MODIFICAR_CLIENTE", lstParametros);

            return aux;
        }
        public int BajaCliente(int nroCl)
        {
            int aux = 0;

            List<Parametro> lstParametros = new List<Parametro>(){
                new Parametro("@id_cliente", nroCl)
              
            };

            aux = DBHelper.ObtenerInstancia().ActualizarBD("SP_BAJA_CLIENTE", lstParametros);

            return aux;
        }
        public Cliente ExtraerClienteID(int id)
        {
            List<Parametro> lst = new List<Parametro>()
            {
                new Parametro("@id_cli", id)
            };
            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_FILTROS_CLIENTES_ID", lst);

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
                c.TipoDoc = Convert.ToInt32(dr["id_tipo_documento"]);
                c.TipoCliente = Convert.ToInt32(dr["id_tipo_de_cliente"]);
                c.CondicionIVA = Convert.ToInt32(dr["id_condicionIVA"]);
            }

            return c;
        }
        //revisar el de abajo
        public List<Cliente> ExtraerClienteNombre(List<Parametro> lstparam)
        {
            DataTable dt ;
            List<Cliente> lst = new List<Cliente>();
          

            dt = DBHelper.ObtenerInstancia().Consultar("SP_FILTROS_CLIENTES_Nombre", lstparam);

            foreach (DataRow dr in dt.Rows)
            {
                Cliente c = new Cliente();
                c.Id = Convert.ToInt32(dr["id_cliente"]);
                c.Nombre = dr["nombre"].ToString();
                c.Apellido = dr["apellido"].ToString();
                c.Calle = dr["calle"].ToString();
                c.Altura = dr["altura"].ToString();
                c.Barrio = Convert.ToInt32(dr["id_Barrio"].ToString());
                c.Documento = dr["documento"].ToString();
                c.TipoDoc = Convert.ToInt32(dr["id_tipo_documento"].ToString());
                c.TipoCliente = Convert.ToInt32(dr["id_tipo_de_cliente"].ToString());
                c.CondicionIVA = Convert.ToInt32(dr["id_condicionIVA"].ToString());

                lst.Add(c);

            }

           return lst;
        }

        //public string InicioSesion(string usuario, string contraseña)
        //{
        //    List<Items> lst = new List<Items>();

        //    DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_FORMASPAGO");
        //    return lst
        //}

    }
}

