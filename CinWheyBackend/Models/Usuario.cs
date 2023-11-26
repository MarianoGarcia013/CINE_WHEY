using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWheyBackend.Models
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public int contrasñea_usuario { get; set; }

        public Usuario() 
        {
            id_usuario= 0;
            nombre_usuario = string.Empty;
            contrasñea_usuario = 0;
        }       
    }
}
