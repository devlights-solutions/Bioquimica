using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioquimica.Entidades
{
   public partial class Orden
    {
       public string PrepagaString
       {
           get { return this.Prepagas.Nombre; }
       }
    }
}
