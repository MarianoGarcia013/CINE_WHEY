using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Models
{
    public class Idioma
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        public Idioma(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public Idioma()
        {
        }
    }
}
