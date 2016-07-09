using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioquimica.Entidades
{
    public partial class Practica
    {
        public string NombreCompleto
        {
            get { return String.Format("{0} - {1}", Codigo, Descripcion); }
        }

        public string CodigoParaDropdown
        {
            get
            {
                if (this.Codigo == 0)
                    return string.Empty;
                return this.Codigo.ToString();
            }
        }
    }
}
