using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Models
{
    public class Butaca
    {

        public int id_butaca { get; set; }
        public int numero { get; set; }
        public bool estado { get; set; }

        public Butaca(int id_butaca, int numero, bool estado)
        {
            this.id_butaca = id_butaca;
            this.numero = numero;
            this.estado = estado;
        }
    }
}
