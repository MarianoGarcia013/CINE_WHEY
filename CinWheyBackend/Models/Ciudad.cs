using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Models
{
    public class Ciudad
    {
        public int id { get; set; }
        public string name { get; set; }
        public Provincia provincia { get; set; }

        public Ciudad(int id, string name, Provincia provincia)
        {
            this.id = id;
            this.name = name;
            this.provincia = provincia;
        }

        public Ciudad()
        {
        }
    }
}

