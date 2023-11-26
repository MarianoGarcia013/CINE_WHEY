using CineWheyBackend.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Data.Interfaz
{
    internal interface ICineDAO
    {
        List<Cliente> GetClientes();
        List<Pelicula> GetPeliculas();
        List<Funcion> GetFunciones();
        List<Reserva> GetReservas();
        List<Reserva> GetReservaxfecha(DateTime desde, DateTime hasta);
        
        List<Cliente> GetClientePorId(int id);

       
        bool PostCliente(Cliente cliente);
        bool PostRserva(Reserva reserva);
        bool PostFactura(Factura factura);
        bool PostFuncion(Funcion funcion);
        bool PostPelicula(Pelicula pelicula);
        bool UpdateCliente(Cliente cliente);

        bool UpdatePeliculas(Pelicula pelicula);
        bool UpdateFunciones(Funcion funcion);

        bool DeletePelicula(int id);

        List<Pelicula> GetPeliculaPorGenero(int genero);

        bool PostUsuario(Usuario usuario);
    }
}
