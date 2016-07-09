using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioquimica.Entidades
{
    public class Paciente
    {
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public string Domicilio { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
