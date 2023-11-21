using AutomotrizBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Security.Policy;

namespace AutomotrizBack.Datos
{
    public class ComprobantesDAO : IComprobantesDAO
    {
        //Obtener
        public List<Items> ObtenerComprobantes()
        {
            List<Items> comprobantes = new List<Items>();

            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_TIPOS_COMPROBANTES");

            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_tipo_factura"]);
                string nom = dr["descripcion"].ToString();

                Items item = new Items(id, nom);
                comprobantes.Add(item);
            }

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

            foreach (DataRow dr in dt.Rows)
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
            List<Items> lst = new List<Items>();

            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_TIPOSDOC");

            foreach (DataRow dr in dt.Rows)
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
        public List<Items> ObtenerProductos(int tipoProd)
        {
            List<Parametro> parametros = new List<Parametro>()
            {
                new Parametro("@id_tipo_producto", tipoProd)
            };

            List<Items> lst = new List<Items>();

            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_PRODUCTOS_X_TIPO", parametros);

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
        public List<Items> ObtenerDescuentos()
        {
            List<Items> lst = new List<Items>();

            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_DESCUENTOS");

            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_descuento"]);
                string nom = dr["monto"].ToString();

                Items item = new Items(id, nom);
                lst.Add(item);
            }
            return lst;
        }
        public List<Items> ObtenerAutoplanes()
        {
            List<Items> lst = new List<Items>();

            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_AUTOPLANES");

            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_autoplan"]);
                string nom = dr["autoplan"].ToString();
                double interes = Convert.ToDouble(dr["interes"]);

                Items item = new Items(id, nom, interes);
                lst.Add(item);
            }
            return lst;
        }
        public List<Items> ObtenerTiposProductos()
        {
            List<Items> lst = new List<Items>();

            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_TIPOS_PRODUCTOS");

            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_tipo"]);
                string nom = dr["descripcion"].ToString();

                Items item = new Items(id, nom);
                lst.Add(item);
            }
            return lst;
        }
        public List<Items> ObtenerProductos()
        {
            List<Items> lst = new List<Items>();

            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_PRODUCTOS_X_TIPO");

            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["cod_producto"]);
                string nom = dr["descripcion"].ToString();

                Items item = new Items(id, nom);
                lst.Add(item);
            }
            return lst;
        }
        public List<Items> ObtenerInicioSesion()
        {
            List<Items> lst = new List<Items>();

            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_INICIOSESION");

            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["id_inicioSesion"]);
                string nom = dr["usuario"].ToString();
                string pass = dr["contrasena"].ToString();
                Comprobante.LegajoEmpleado = Convert.ToInt32(dr["legajo_empleado"]);

                Items item = new Items(id, nom, pass);
                lst.Add(item);
            }
            return lst;
        }

        public Producto ExtraerProducto(int codigo)
        {
            DataTable dt = DBHelper.ObtenerInstancia().Consultar("SP_CONSULTAR_PRODUCTOS");

            Producto p = new Producto();

            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["cod_producto"]) == codigo)
                {
                    p.Codigo = Convert.ToInt32(dr["cod_producto"]);
                    p.Descripcion = dr["descripcion"].ToString();
                    p.Precio = Convert.ToInt32(dr["precio"]);
                    p.IdTipoProd = Convert.ToInt32(dr["id_tipo_prod"]);
                    p.IdMarca = Convert.ToInt32(dr["id_marca"]);
                    p.IdUMedida = Convert.ToInt32(dr["id_unidad_medida"]);
                    p.IdPresentacion = Convert.ToInt32(dr["id_presentacion"]);
                }
            }

            return p;
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
            int proximo = DBHelper.ObtenerInstancia().ConsultarEscalar("SP_PROXIMO_ID_CLIENTE", "@next");

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
            List<ResultadoComprobante> lst = new List<ResultadoComprobante>();

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
       
        public List<Cliente> ExtraerClienteNombre(string nom, string apell)
        {
            DataTable dt;
            List<Cliente> lstc = new List<Cliente>();

            List<Parametro> lstparam = new List<Parametro>()
            {
                new Parametro("@nombre", nom),
                new Parametro("@apellido", apell)
            };

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

                lstc.Add(c);

            }

            return lstc;
        }

        public Cliente ExtraerClienteDocumento(int tipdoc, string doc)
        {
            DataTable dt;

            Cliente c = new Cliente();
            List<Parametro> lstparam = new List<Parametro>()
            {
                new Parametro("@tipo_doc", tipdoc),
                new Parametro("@documento", doc)
            };

            dt = DBHelper.ObtenerInstancia().Consultar("SP_FILTROS_CLIENTES_Documento", lstparam);

            foreach (DataRow dr in dt.Rows)
            {

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



            }

            return c;
        }


        //por fecha que no compro
        public List<Cliente> ExtraerClienteNoCompro(string desde, string hasta)
        {
            DataTable dt;

            List<Cliente> lstc = new List<Cliente>();
            List<Parametro> lstparam = new List<Parametro>()
            {
                new Parametro("@fechaDesde", desde),
                new Parametro("@fechaHasta", hasta)
            };

            dt = DBHelper.ObtenerInstancia().Consultar("SP_CLIENTES_NOCOMPROPORFECHA", lstparam);

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

                lstc.Add(c);
            }



            return lstc;

        }

        //por fecha que compro
        public List<Cliente> ExtraerClienteCompro(string desde, string hasta)
        {
            DataTable dt;

            List<Cliente> lstc = new List<Cliente>();
            List<Parametro> lstparam = new List<Parametro>()
            {
                new Parametro("@fechaDesde", desde),
                new Parametro("@fechaHasta", hasta)
            };

            dt = DBHelper.ObtenerInstancia().Consultar("SP_CLIENTES_COMPROPORFECHA", lstparam);

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

                lstc.Add(c);
            }



            return lstc;

        }


        public bool InsertarFactura(Comprobante comprobante)
        {
            bool ok = true;
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();
            SqlConnection cnn = DBHelper.ObtenerInstancia().ObtenerConexion();
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "SP_INSERTAR_FACTURA";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = comprobante.Fecha.ToString("d");
                cmd.Parameters.AddWithValue("@legajo_empleado", Comprobante.LegajoEmpleado);
                cmd.Parameters.AddWithValue("@id_cliente", comprobante.Cliente.Id);
                cmd.Parameters.AddWithValue("@id_tipo_factura", comprobante.IdTipoFactura);

                //parámetro de salida:
                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@num_factura";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();
                int numFactura = (int)pOut.Value;
                SqlCommand cmdDetalle;
                foreach (DetalleComprobante item in comprobante.DetallesComprobante)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES_FACTURA", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@num_factura", numFactura);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", item.Cantidad);
                    cmdDetalle.Parameters.AddWithValue("@precio", (SqlMoney)item.Precio);
                    cmdDetalle.Parameters.AddWithValue("@observaciones", "");
                    cmdDetalle.Parameters.AddWithValue("@id_descuento", item.IdBonif);
                    cmdDetalle.Parameters.AddWithValue("@id_autoplan", item.IdAutoplan);
                    cmdDetalle.Parameters.AddWithValue("@cod_producto", item.CodProducto);
                    cmdDetalle.ExecuteNonQuery();

                }
                SqlCommand cmdFormaPago;
                foreach (Items item in comprobante.FormasPago)
                {
                    cmdFormaPago = new SqlCommand("SP_INSERTAR_FORMAS_PAGO", cnn, t);
                    cmdFormaPago.CommandType = CommandType.StoredProcedure;
                    cmdFormaPago.Parameters.AddWithValue("@num_factura", numFactura);
                    cmdFormaPago.Parameters.AddWithValue("@id_formaPago", item.Id);
                    cmdFormaPago.ExecuteNonQuery();
                }
                t.Commit();
            }

            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                ok = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return ok;
        }
        public int NumFacturaActual()
        {
            int nroFact = DBHelper.ObtenerInstancia().ConsultarEscalar("SP_ACTUAL_NUM_FACTURA", "@numFact");
            
            return nroFact;
        }
       
    }
}

