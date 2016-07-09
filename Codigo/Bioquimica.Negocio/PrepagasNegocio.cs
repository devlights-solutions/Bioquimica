using System;
using System.Collections.Generic;
using Bioquimica.Entidades;
using Bioquimica.Datos.Repositorio;

namespace Bioquimica.Negocio
{
    public class PrepagasNegocio:NegocioBase<PrepagaRepository>
    {
        public static List<Prepaga> Listado(string descripcion)
        {
            try
            {
                return RepositoryInstancia.Listado(descripcion);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<Prepaga> ListadoParaCombo()
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

        public static Prepaga Obtener(int prepagaId)
        {
            try
            {
                return RepositoryInstancia.Obtener(prepagaId);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Guardar(Prepaga prepaga)
        {
            try
            {
                if (RepositoryInstancia.Guardar(prepaga))
                {
                    return true;
                }
                else {return false; }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool Eliminar(int prepagaId)
        {
            try
            {
                if (RepositoryInstancia.Eliminar(prepagaId))
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
