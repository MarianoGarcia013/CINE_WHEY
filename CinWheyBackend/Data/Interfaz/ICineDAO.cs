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

        DataTable Getidioma();
        DataTable Getgenero();       

        bool PostCliente(Cliente cliente);
        bool PostRserva(Reserva reserva);
        bool PostFactura(Factura factura);
        bool PostFuncion(Funcion funcion);
        bool PostPelicula(Pelicula pelicula);
        bool UpdateCliente(Cliente cliente);

        // Delete pelicula
    }
}
