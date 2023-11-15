using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Models
{
    public class Reserva
    {
        public int id { get; set; }
        public DateTime fec_reserva { get; set; }
        public int cliente { get; set; }

        public List<DetalleReserva> LstDetallesR;
        //public Reserva(int id, DateTime fec_reserva, int cliente)
        //{
        //    this.id = id;
        //    this.fec_reserva = fec_reserva;
        //    this.cliente = cliente;
        //}

        public Reserva()
        {
            LstDetallesR = new List<DetalleReserva>();
        }

        public void AddDtlleReserva(DetalleReserva dtllReserva)
        {
            LstDetallesR.Add(dtllReserva);
        }

        public void RemoveDtlleReserva(int indice)
        {
           
            LstDetallesR.Remove(indice);
        }
    }
}
