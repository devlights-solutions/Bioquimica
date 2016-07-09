using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bioquimica.Negocio
{
    public class NegocioBase<T> where T : class , new()
    {
        private static T repositoryInstancia;

        public static T RepositoryInstancia
        {
            get { return repositoryInstancia ?? (repositoryInstancia = new T()); }
            set { repositoryInstancia = value; }
        }
    }
}
