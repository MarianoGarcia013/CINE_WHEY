using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Models
{
    public class DetalleReserva
    {
       public Funcion funcion { get; set; }

        public int cantidad { get; set; }


        public DetalleReserva(Funcion funcion, int catidad, DateTime fecha_reservada, int cantidad)
        {
            
            this.funcion = funcion;
            this.cantidad = catidad;
        }
    }
}
