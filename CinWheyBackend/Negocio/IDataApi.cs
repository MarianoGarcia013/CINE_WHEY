using CineWheyBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Negocio
{
    public interface IDataApi
    {
        public bool InsertarCliente(Cliente c);
        public List<Cliente> ConsultarClientes();

        public List<Pelicula> ConsultarPeliculas();    
        bool InsertarPelicula(Pelicula pelicula);
        bool InsertarFunciones(Funcion funcion);
        bool InsertarReserva(Reserva reserva);
        List<Cliente> GetClientePorId(int id);
        bool UpdatePelcicula(Pelicula pelicula);

        bool DeletePeliucla(int id);

        List<Pelicula> GetPeliculaPorGenero(int genero);
    }
}
