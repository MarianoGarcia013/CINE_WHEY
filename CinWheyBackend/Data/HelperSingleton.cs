using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using CineWheyBackend.Models;

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

        //public DataTable ConsultarDB(string SP)
        //{
        //    DataTable dt = new DataTable();
        //    Conectar();
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    dt.Load(cmd.ExecuteReader());
        //    cnn.Close();
        //    return dt;
        //}

        public DataTable ConsultarDB(string consultaSQL)
        {
            DataTable dt = new DataTable();
            Conectar();
            cmd.CommandText = consultaSQL;
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }
        public DataTable querySQL(string SQL, List<Parametros> value)
        {
            DataTable dt = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            cmd.CommandType = CommandType.Text;
            if (value != null)
            {
                foreach (Parametros param in value)
                {
                    cmd.Parameters.AddWithValue(param.key, param.value);
                }
            }

            dt.Load(cmd.ExecuteReader());

            cnn.Close();

            return dt;
        }

        public bool ValidarCredenciales(string usuario, string contrasena)
        {
            cnn.Open();

            string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre_usuario = @Usuario AND Contraseña_usuario = @Contraseña";

            using (SqlCommand command = new SqlCommand(query, cnn))
            {
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contrasena);

                int resultado = (int)command.ExecuteScalar();

                cnn.Close();
                return resultado > 0;
            }
            
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
        public DataTable Consultar(string nombreSP, List<Parametros> lstParametros)
        {
            cnn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            comando.Parameters.Clear();
            foreach (Parametros p in lstParametros)
            {
                comando.Parameters.AddWithValue(p.key, p.value);
            }
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
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

        public List<Reserva> ObtenerReservasPorFecha(DateTime fechaDesde, DateTime fechaHasta) // Falta terminar
        {
            List<Reserva> reservas = new List<Reserva>();
            string sp = "SP_ReservasPorFecha";
            List<Parametros> list = new List<Parametros>();
            list.Add(new Parametros("@fecha_desde", fechaDesde));
            list.Add(new Parametros("@fecha_hasta", fechaHasta));
            DataTable dt = ConsultarDBP(sp, list);

            foreach (DataRow row in dt.Rows)
            {
                Reserva reserva = new Reserva();

            }
            return reservas;
        }

        public bool InsertarReserva(Reserva reserva) 
        {
            bool resultado = true;
            SqlTransaction t = null;

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INSERTAR_RESERVA";
                cmd.Parameters.AddWithValue("@fec_reserva", reserva.fec_reserva);
                cmd.Parameters.AddWithValue("@id_cliente", reserva.cliente.IdCliente);

                SqlParameter parametro = new SqlParameter("@reserva", DbType.Int32);             
                parametro.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(parametro);

                cmd.ExecuteNonQuery();

                int nroReserva = (int)parametro.Value;                
                SqlCommand cmdDetalle;
                int detReseva = 1;


                foreach (DetalleReserva d in reserva.LstDetallesR)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLRESERVA", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_dtl_reserva", detReseva);// Esto funciona con el conador? xq no es identity el id_detalleReserva
                    cmdDetalle.Parameters.AddWithValue("@id_reserva", nroReserva);
                    cmdDetalle.Parameters.AddWithValue("@id_funcion",d.funcion.id_funcion);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", d.cantidad);
                    cmdDetalle.ExecuteNonQuery();  
                    detReseva ++;
                }
                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback();
                resultado = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return resultado;
        }
    }
}

