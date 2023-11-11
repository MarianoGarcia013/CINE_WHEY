using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Models
{
    public class Tipo_sala
    {
        public int id_ts { get; set; }
        public string descripcion { get; set; }

        public Tipo_sala(int id_ts, string descripcion)
        {
            this.id_ts = id_ts;
            this.descripcion = descripcion;
        }
    }
}
