using System;
using System.Collections.Generic;
using Bioquimica.Entidades;
using Bioquimica.Datos.Repositorio;

namespace Bioquimica.Negocio
{
    public class ProfesionalesNegocio : NegocioBase<ProfesionalesRepository>
    {
        public static List<Profesional> Listado()
        {
            try
            {
                return RepositoryInstancia.Listado();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Profesional Obtener()
        {
            try
            {
                return RepositoryInstancia.Obtener();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Guardar(Profesional profesional)
        {
            try
            {
                if (RepositoryInstancia.Guardar(profesional))
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Eliminar(int profesionalId)
        {
            try
            {
                if (RepositoryInstancia.Eliminar(profesionalId))
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
