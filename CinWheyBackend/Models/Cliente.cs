using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Models
{
    public class Cliente
    {
        private int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public DateTime fec_nac { get; set; }
        public string direccion { get; set; }
        public int ciudad { get; set; }

        public Cliente(int id_cliente, string nombre, string apellido, string email, string telefono, DateTime fec_nac, string direccion, int ciudad)
        {
            this.idCliente = id_cliente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.telefono = telefono;
            this.fec_nac = fec_nac;
            this.direccion = direccion;
            this.ciudad = ciudad;
        }

        public Cliente()
        {
            idCliente = 0;
        }

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public override string ToString()
        {
            return nombre + ", " + apellido;
        }
    }
}
