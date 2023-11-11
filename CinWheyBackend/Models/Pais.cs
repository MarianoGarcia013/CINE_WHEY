using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Models
{
    public class Pais
    {
        public int id { get; set; }
        public string name { get; set; }

        public Pais(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
