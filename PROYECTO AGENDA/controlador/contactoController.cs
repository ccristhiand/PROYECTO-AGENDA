using PROYECTO_AGENDA.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_AGENDA.controlador
{
    public class contactoController
    {
        List<contacto> contactos = new List<contacto>();

        public List<contacto> Addcontacto(contacto contacto)
        {
            contactos.Add(contacto);
            return contactos;
        }

        public List<contacto> Liscontacto()
        {
            return contactos;
        }
    }
}
