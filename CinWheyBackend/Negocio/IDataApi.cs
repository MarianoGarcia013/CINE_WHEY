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
        bool InsertarPelicula(Pelicula pelicula);
        bool InsertarFunciones(Funcion funcion);
        bool InsertarReserva(Reserva reserva);
    }
}
