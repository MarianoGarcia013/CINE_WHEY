using CineWheyBackend.Data.Implementacion;
using CineWheyBackend.Data.Interfaz;
using CineWheyBackend.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Negocio
{
    public class DataApi: IDataApi
    {
        private ICineDAO DAO;

        public DataApi()
        {
            DAO = new CineDAO();
        }

        public List<Cliente> ConsultarClientes()
        {
            return DAO.GetClientes();
        }       

        public bool InsertarCliente(Cliente c)
        {
            return DAO.PostCliente(c);
        }

        public bool InsertarFunciones(Funcion funcion)
        {
            return DAO.PostFuncion(funcion);
        }

        public bool InsertarPelicula(Pelicula pelicula)
        {
            return DAO.PostPelicula(pelicula);
        }

        public bool InsertarReserva(Reserva reserva)
        {
            return DAO.PostRserva(reserva);
        }
        public List<Cliente> GetClientePorId(int id)
        {
            return DAO.GetClientePorId(id);
        }

        public List<Pelicula> ConsultarPeliculas()
        {
           return DAO.GetPeliculas();
        }       

        public bool UpdatePelcicula(Pelicula pelicula)
        {
            return DAO.UpdatePeliculas(pelicula);
        }

        public bool DeletePeliucla(int id)
        {
           return DAO.DeletePelicula(id);
        }

        public List<Pelicula> GetPeliculaPorGenero(int genero)
        {
           return DAO.GetPeliculaPorGenero(genero);
        }
    }
}
