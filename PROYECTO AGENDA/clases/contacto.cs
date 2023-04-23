using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_AGENDA.clases
{
    public class contacto
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string apellido { get; set; }
        public string tel { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public DateTime fechaNac { get; set; }
        public string tipo { get; set; }
        public string relacion { get; set; }
    }
}
