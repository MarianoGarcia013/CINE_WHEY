using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Data
{
    public class HelperSingleton
    {
        SqlConnection cnn; 
        static HelperSingleton instancia;
        SqlCommand cmd = new SqlCommand();

        public HelperSingleton()
        {
           cnn = new SqlConnection(@"Data Source=DESKTOP-SFDA7AL\MSSQLSERVER2;Initial Catalog=db_cine_whey;Integrated Security=True");
        }

        public static HelperSingleton getInstance()
        {
            if (instancia == null)
                instancia = new HelperSingleton();
            return instancia;
        }
        private void Conectar()
        {
            cnn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
        }

        public DataTable ConsultarDB(string SP)
        {
            DataTable dt = new DataTable();
            Conectar();
            cmd.CommandType = CommandType.StoredProcedure;
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }

        public DataTable ConsultarDBCombo(string consultaSQL)
        {
            DataTable dt = new DataTable();
            Conectar();
            cmd.CommandText = consultaSQL;
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }

        public DataTable ConsultarDBP(string SP, List<Parametros> lst)
        {
            DataTable dt = new DataTable();
            Conectar();
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (Parametros p in lst)
            {
                cmd.Parameters.AddWithValue(p.key, p.value);
            }
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }

        public bool EjecutarSQLParam(string strSql, List<SqlParameter> values)
        {
            bool ok = true;
            SqlTransaction t = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = strSql;
                cmd.Transaction = t;

                if (values != null)
                {
                    foreach (SqlParameter param in values)
                    {
                        cmd.Parameters.AddWithValue(param.ParameterName, param.Value);
                    }
                }

                cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null)
                {
                    t.Rollback();
                    ok = false;
                }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }

            return ok;
        }
    }
}
