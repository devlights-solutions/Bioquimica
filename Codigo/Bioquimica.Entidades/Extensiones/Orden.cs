using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioquimica.Entidades
{
    public partial class Orden
    {
        public string PrepagaNombre
        {
            get { return Prepagas.Nombre; }
        }
    }
}
