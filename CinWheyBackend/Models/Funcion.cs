using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Models
{
    public class Funcion
    {
        public int id_funcion { get; set; }
        public Pelicula pelicula { get; set; }
        public Sala sala { get; set; }
        public double precio { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora_inicio { get; set; }


        public Funcion(int id_funcion, Pelicula pelicula, Sala sala, double precio, DateTime fecha, DateTime hora_inicio)
        {
            this.id_funcion = id_funcion;
            this.pelicula = pelicula;
            this.sala = sala;
            this.precio = precio;
            this.fecha = fecha;
            this.hora_inicio = hora_inicio;
        }

        public Funcion()
        {
        }
    }
}
