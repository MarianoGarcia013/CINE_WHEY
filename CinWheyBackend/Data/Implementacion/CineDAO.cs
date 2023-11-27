using CineWheyBackend.Data.Interfaz;
using CineWheyBackend.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Data.Implementacion
{
    public class CineDAO : ICineDAO
    {
        public bool DeletePelicula(int id)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@id_pelicula", id));
            return HelperSingleton.getInstance().EjecutarSQLParam("SP_DeletePelicula", list);
        }

        public List<Cliente> GetClientePorId(int id)
        {
            DataTable dt = HelperSingleton.getInstance().querySQL($"SELECT id_cliente FROM Clientes where id_cliente = {id}", null);
            List<Cliente> resultado = new List<Cliente>();
            foreach (DataRow fila in dt.Rows)
            {
                Cliente c = new Cliente();

                c.IdCliente = (int)fila[0];
                //c.nombre = (string)fila[1];
                //c.apellido = (string)fila[2];
                //c.email = (string)fila[3];
                //c.telefono = (string)fila[4];
                //c.fec_nac = (DateTime)fila[5];
                //c.direccion = (string)fila[6];
                //c.ciudad = (int)fila[7];
                resultado.Add(c);
            }
            return resultado;
        }
  
        public List<Cliente> GetClientes()
        {
            List<Cliente> lClient = new List<Cliente>();
            DataTable dt = HelperSingleton.getInstance().ConsultarDB("SP_Clientes");
            foreach (DataRow dr in dt.Rows)
            {
                Cliente c = new Cliente();                

                c.IdCliente = (int)dr[0];
                c.nombre = (string)dr[1];
                c.apellido = (string)dr[2];
                c.email = (string)dr[3];
                c.telefono = (string)dr[4];
                c.fec_nac = (DateTime)dr[5];
                c.direccion = (string)dr[6];
                c.ciudad = (int)dr[7];
                lClient.Add(c);
            }
            return lClient;
        }

        public List<Funcion> GetFunciones()
        {
            List<Funcion> lFunciones = new List<Funcion>();
            DataTable dt = HelperSingleton.getInstance().ConsultarDB("SP_Funciones");
            foreach (DataRow dr in dt.Rows)
            {
                Funcion fn = new Funcion();              

                fn.id_funcion = (int)dr[0];
                fn.pelicula = (int)dr[1];
                fn.sala= (int)dr[2];
                fn.fecha = (DateTime)dr[3];
                fn.precio = (double)dr[4];
                fn.hora_inicio = (string)dr[5];
                lFunciones.Add(fn);
            }
            return lFunciones;
        }
        
        public List<Pelicula> GetPeliculaPorGenero(int genero)
        {
            DataTable dt = HelperSingleton.getInstance().querySQL($"SELECT * FROM Pelicula WHERE id_genero = {genero}", null);
            List<Pelicula> resultado = new List<Pelicula>();

            foreach (DataRow dr in dt.Rows) 
            {
                Pelicula p = new Pelicula();
                p.id_pelicula= (int)dr[0];
                p.titulo = (string)dr[1];
                p.fecha_estreno = Convert.ToDateTime(dr[2]);
                p.director = (string)dr[3];
                p.genero = (int)dr[4];
                p.idioma = (int)dr[5];
                p.apta_todo_publico = (bool)dr[6];
                resultado.Add(p);
            }
            return resultado;

        }

        public List<Pelicula> GetPeliculas()
        {
            List<Pelicula> lPelicula = new List<Pelicula>();
            DataTable dt = HelperSingleton.getInstance().ConsultarDB("select * from Pelicula");
            foreach (DataRow dr in dt.Rows)
            {
                Pelicula p = new Pelicula();                             


                p.id_pelicula = (int)dr[0];
                p.titulo = (string)dr[1];
                p.fecha_estreno = (DateTime)dr[2];
                p.director = (string)dr[3];
                p.genero = (int)dr[4];
                p.idioma = (int)dr[5];
                p.apta_todo_publico = (bool)dr[6];
                p.duracion = (int)dr[7];               
                lPelicula.Add(p);
            }
            return lPelicula;

        }

        public List<Reserva> GetReservas()
        {
            throw new NotImplementedException();
        }

        public List<Reserva> GetReservaxfecha(DateTime desde, DateTime hasta)
        {
            throw new NotImplementedException();
        }

        public bool PostCliente(Cliente cliente)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@nombre", cliente.nombre));
            list.Add(new SqlParameter("@apellido", cliente.apellido));
            list.Add(new SqlParameter("@email", cliente.email));
            list.Add(new SqlParameter("@telefono", cliente.telefono));
            list.Add(new SqlParameter("@fec_nac", cliente.fec_nac));
            list.Add(new SqlParameter("@direccion", cliente.direccion));
            list.Add(new SqlParameter("@id_ciudad", cliente.ciudad));

            return HelperSingleton.getInstance().EjecutarSQLParam("SP_CrearCliente", list);
        }

        public bool PostFactura(Factura factura)
        {
            throw new NotImplementedException();
        }

        public bool PostFuncion(Funcion funcion)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@id_pelicula", funcion.pelicula));
            list.Add(new SqlParameter("@id_sala", funcion.sala));
            list.Add(new SqlParameter("@fecha", funcion.fecha));
            list.Add(new SqlParameter("@precio", funcion.precio));
            list.Add(new SqlParameter("@hora_inicio", funcion.hora_inicio));            

            return HelperSingleton.getInstance().EjecutarSQLParam("SP_CrearFunciones", list);
        }

        public bool PostPelicula(Pelicula pelicula)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@titulo", pelicula.titulo));
            list.Add(new SqlParameter("@duracion", pelicula.duracion));
            list.Add(new SqlParameter("@fecha_estreno", pelicula.fecha_estreno));
            list.Add(new SqlParameter("@director", pelicula.director));
            list.Add(new SqlParameter("@id_genero", pelicula.genero));
            list.Add(new SqlParameter("@id_idioma", pelicula.idioma));
            list.Add(new SqlParameter("@apta_todo_publico", pelicula.apta_todo_publico));

            return HelperSingleton.getInstance().EjecutarSQLParam("SP_CrearPelicula", list);
        }

        public bool PostRserva(Reserva reserva)
        {
            return HelperSingleton.getInstance().InsertarReserva(reserva);
        }

        public bool UpdateCliente(Cliente cliente)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@id_cliente", cliente.IdCliente));
            list.Add(new SqlParameter("@nombre", cliente.nombre));
            list.Add(new SqlParameter("@apellido", cliente.apellido));
            list.Add(new SqlParameter("@email", cliente.email));
            list.Add(new SqlParameter("@telefono", cliente.telefono));
            list.Add(new SqlParameter("@direccion", cliente.direccion));
            list.Add(new SqlParameter("@ciudad", cliente.ciudad));

            return HelperSingleton.getInstance().EjecutarSQLParam("SP_UpdateCliente", list);

        }

        public bool UpdatePeliculas(Pelicula pelicula)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@id_pelicula", pelicula.id_pelicula));
            list.Add(new SqlParameter("@titulo", pelicula.titulo));
            //list.Add(new SqlParameter("@fecha_estreno", pelicula.fecha_estreno));
            list.Add(new SqlParameter("@director", pelicula.director));
            list.Add(new SqlParameter("@id_genero", pelicula.genero));
            list.Add(new SqlParameter("@id_idioma", pelicula.idioma));
            list.Add(new SqlParameter("@apta_todos", pelicula.apta_todo_publico));
            list.Add(new SqlParameter("@duracion", pelicula.duracion));

            return HelperSingleton.getInstance().EjecutarSQLParam("SP_UpdatePelicula", list);
        }

        public bool PostUsuario(Usuario usuario) 
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@nombre", usuario.nombre_usuario));
            list.Add(new SqlParameter("@contraseña", usuario.contrasñea_usuario));

            return HelperSingleton.getInstance().EjecutarSQLParam("SP_CrearUsuario", list);
        }

        public bool UpdateFunciones(Funcion funcion)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@id_funcion", funcion.id_funcion));
            list.Add(new SqlParameter("@id_pelicula", funcion.pelicula));
            list.Add(new SqlParameter("@id_sala", funcion.sala));            
            list.Add(new SqlParameter("@precio", funcion.precio));           
            list.Add(new SqlParameter("@hora_inicio", funcion.hora_inicio));
            list.Add(new SqlParameter("@descripcion", funcion.descripcion));

            return HelperSingleton.getInstance().EjecutarSQLParam("SP_UpdateFunciones", list);
        }

        public bool DeleteFuncion(int id)
        {
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@id_funcion", id));
            return HelperSingleton.getInstance().EjecutarSQLParam("SP_DeleteFuncion", list);
        }
    }
}
