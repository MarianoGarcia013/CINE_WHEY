using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Models
{
    public class Genero
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public Genero(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public Genero()
        {
        }
    }
}
