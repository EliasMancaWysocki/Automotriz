using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Datos
{
    public class DBHelper
    {
        private static DBHelper Instance;
        private SqlConnection Cnn;
        private DBHelper()
        {
            Cnn = new SqlConnection(Properties.Resources.Server);
        }
        public static DBHelper ObtenerInstancia()
        {
            if (Instance == null)
            {
                Instance = new DBHelper();
            }
            return Instance;
        }
        public int ConsultarEscalar(string nombreSP, string nombreParamOut)
        {
            Cnn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = Cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombreParamOut;
            parametro.SqlDbType = SqlDbType.Int;
            parametro.Direction = ParameterDirection.Output;

            comando.Parameters.Add(parametro);
            comando.ExecuteNonQuery();

            Cnn.Close();

            return (int)parametro.Value;
        }
        public DataTable Consultar(string nombreSP)
        {
            Cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            Cnn.Close();
            return tabla;
        }
        public DataTable Consultar(string nombreSP, List<Parametro> lstParametros)
        {
            Cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Clear();
            foreach (Parametro p in lstParametros)
            {
                cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            Cnn.Close();
            return tabla;
        }
        public int ActualizarBD(string nombreSP, List<Parametro> lstParametros)
        {
            int resultado = 0;

            Cnn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = Cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.Clear();

            foreach (Parametro p in lstParametros)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
           
            resultado = comando.ExecuteNonQuery();
            Cnn.Close();

            return resultado;
        }

        public SqlConnection ObtenerConexion()
        {
            return Cnn;
        }
    }
}
