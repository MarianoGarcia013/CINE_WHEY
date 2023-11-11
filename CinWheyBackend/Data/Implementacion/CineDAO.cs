using CineWheyBackend.Data.Interfaz;
using CineWheyBackend.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Data.Implementacion
{
    public class CineDAO : ICineDAO
    {      

        public List<Cliente> GetClientes()
        {
            List<Cliente> lClient = new List<Cliente>();
            DataTable dt = HelperSingleton.getInstance().ConsultarDB("SP_Clientes");
            foreach (DataRow dr in dt.Rows)
            {
                Cliente c = new Cliente();                

                c.id_cliente = (int)dr[0];
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
                Pelicula p = new Pelicula();
                p.titulo = (string)dr[1];

                Sala s = new Sala();
                s.numero_sala = (int)dr[3];

                fn.id_funcion = (int)dr[0];
                fn.pelicula = p;
                fn.fecha = (DateTime)dr[2];
                fn.precio = (double)dr[3];
                fn.hora_inicio = (DateTime)dr[4];
                lFunciones.Add(fn);
            }
            return lFunciones;
        }

        public DataTable Getgenero()
        {
            throw new NotImplementedException();
        }

        public DataTable Getidioma()
        {
            throw new NotImplementedException();
        }

        public List<Pelicula> GetPeliculas()
        {
            List<Pelicula> lPelicula = new List<Pelicula>();
            DataTable dt = HelperSingleton.getInstance().ConsultarDB("SP_Peliculas");
            foreach (DataRow dr in dt.Rows)
            {
                Pelicula p = new Pelicula();

                Genero g = new Genero();
                g.descripcion = (string)dr[4];

                Idioma i = new Idioma();
                i.descripcion = (string)dr[5];               


                p.id_pelicula = (int)dr[0];
                p.titulo = (string)dr[1];
                p.fecha_estreno = (DateTime)dr[2];
                p.director = (string)dr[3];
                p.genero = g;
                p.idioma = i;
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
            throw new NotImplementedException();
        }

        public bool PostPelicula(Pelicula pelicula)
        {
            throw new NotImplementedException();
        }

        public bool PostRserva(Reserva reserva)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
