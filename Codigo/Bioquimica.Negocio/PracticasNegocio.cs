using System;
using System.Collections.Generic;
using System.Linq;
using Bioquimica.Entidades;
using Bioquimica.Datos.Repositorio;

namespace Bioquimica.Negocio
{
    public class PracticasNegocio:NegocioBase<PracticasRepository>
    {
        private static List<Practica> _listado; 
        private static List<Practica> Lista
        {
            get { return _listado ?? (_listado = RepositoryInstancia.Listado()); }
        }

        public static List<Practica> Listado(string palabraClave)
        {
            try
            {
                RepositoryInstancia = new PracticasRepository();
                var list = Lista.Where(p => (string.IsNullOrEmpty(palabraClave) || p.Descripcion.Contains(palabraClave) ||
                                            p.Codigo.ToString().Equals(palabraClave))).ToList();
                return list;
            }
            catch (Exception)
            {
              
                return null;
            }
        }

        public static List<Practica> Listado()
        {
            return Listado(null);
        }

        public static Practica Obtener(int practicaId)
        {
            try
            {
                return Lista.FirstOrDefault(p => p.PracticaId == practicaId);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
