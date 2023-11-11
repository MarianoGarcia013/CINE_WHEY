using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Models
{
    public class Provincia
    {
        public int id { get; set; }
        public Pais pais { get; set; }

        public Provincia(int id, Pais pais)
        {
            this.id = id;
            this.pais = pais;
        }
    }
}
