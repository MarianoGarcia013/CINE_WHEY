using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Models
{
    public class DetalleReserva
    {
        public int id_dr { get; set; }
        public Funcion funcion { get; set; }

        public int cantidad { get; set; }


        public DetalleReserva(int id_dr, Funcion funcion, int catidad)
        {
            this.id_dr = id_dr;
            this.funcion = funcion;
            this.cantidad = catidad;
        }
    }
}
