using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Models
{
    public class Sala
    {
        public int id_sala { get; set; }
        public int numero_sala { get; set; }
        public int capacidad { get; set; }
        public Tipo_sala tipo_sala { get; set; }
        public Butaca butaca { get; set; }

        public Sala(int id_sala, int numero_sala, int capacidad, Tipo_sala tipo_sala, Butaca butaca)
        {
            this.id_sala = id_sala;
            this.numero_sala = numero_sala;
            this.capacidad = capacidad;
            this.tipo_sala = tipo_sala;
            this.butaca = butaca;
        }

        public Sala()
        {
        }
    }
}
