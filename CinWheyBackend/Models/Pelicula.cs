using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Models
{
    public class Pelicula
    {
        public int id_pelicula { get; set; }
        public string titulo { get; set; }
        public int duracion { get; set; }
        public DateTime fecha_estreno { get; set; }
        public string director { get; set; }
        public int genero { get; set; }
        public int idioma { get; set; }
        public bool apta_todo_publico { get; set; }      

        public Pelicula(int id_pelicula, string titulo, int duracion, DateTime fecha_estreno, string director, int genero, int idioma, bool apta_todo_publico)
        {
            this.id_pelicula = id_pelicula;
            this.titulo = titulo;
            this.duracion = duracion;
            this.fecha_estreno = fecha_estreno;
            this.director = director;
            this.genero = genero;
            this.idioma = idioma;
            this.apta_todo_publico = apta_todo_publico;            
        }

        public Pelicula()
        {
        }

        public override string ToString()
        {
            return titulo + ", " + director;
        }
    }
}
