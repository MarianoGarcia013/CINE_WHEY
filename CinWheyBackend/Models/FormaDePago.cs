using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Models
{
    public class FormaDePago
    {
        public int id_fm { get; set; }
        public string descripcion { get; set; }

        public FormaDePago(int id_fm, string descripcion)
        {
            this.id_fm = id_fm;
            this.descripcion = descripcion;
        }
    }
}
