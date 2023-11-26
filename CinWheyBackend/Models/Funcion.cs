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
        public int pelicula { get; set; }
        public int sala { get; set; }
        public double precio { get; set; }
        public DateTime fecha { get; set; }
        public string hora_inicio { get; set; }
        public string descripcion { get; set; }


        public Funcion(int id_funcion,int pelicula, int sala, double precio, DateTime fecha, string hora_inicio)
        {
            this.id_funcion = id_funcion;
            this.pelicula = pelicula;
            this.sala = sala;
            this.precio = precio;
            this.fecha = fecha;
            this.hora_inicio = hora_inicio;
            //this.descripcion = descripcion;
        }

        public Funcion(int id_funcion)
        {
            id_funcion= 0;
            pelicula= 0;
            sala= 0;
            precio= 0;
            fecha= DateTime.MinValue;
            hora_inicio = string.Empty;
            descripcion = string.Empty;
        }

        public override string ToString()
        {
            return descripcion + ',' + precio;
        }

        public Funcion()
        {
        }
       
    }
}
