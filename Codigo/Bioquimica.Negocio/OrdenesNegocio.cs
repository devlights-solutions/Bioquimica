using System;
using System.Collections.Generic;
using Bioquimica.Entidades;
using Bioquimica.Datos.Repositorio;

namespace Bioquimica.Negocio
{
    public class OrdenesNegocio:NegocioBase<OrdenesRepository>
    {
        public static List<Orden> Listado(int nroOrden, int prepagaId,string paciente, DateTime fechaAtencion, bool? discriminaIVA)
        {
            try
            {
                return RepositoryInstancia.Listado(nroOrden, prepagaId,paciente, fechaAtencion, discriminaIVA);
            }
            catch (Exception)
            {
               
                return null;
            }
        }

        public static List<Practica> ListadoPracticasPorOrden(int ordenId)
        {
            try
            {
                return RepositoryInstancia.ListadoPracticasOrden(ordenId);
            }
            catch (Exception)
            {
               
                return null;
            }
        }

        public static List<Paciente> ListadoPacientes()
        {
            try
            {
                return RepositoryInstancia.ListadoPacientes();
            }
            catch (Exception)
            {
                
                return null;
            }
        }

        public static Orden Obtener(int ordenId)
        {
            try
            {
                return RepositoryInstancia.Obtener(ordenId);
            }
            catch (Exception ex)
            {
               
                return null;
            }
        }

        public static bool Guardar(Orden orden)
        {
           try
            {
                if (RepositoryInstancia.Guardar(orden))
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

        public static bool Eliminar(int ordenId)
        {
            var eliminar = RepositoryInstancia.Eliminar(ordenId);
            return eliminar;
        }


        public static Orden ObtenerPorDni(int dni)
        {
            return RepositoryInstancia.ObtenerPorDni(dni);
        }

        public static void DiscriminarIVA(int dni, int prepagaId)
        {
            RepositoryInstancia.DiscriminarIVA(dni, prepagaId);
        }

        public static bool ExisteSinDiscriminarIVA(int dni, int prepagaId)
        {
            return RepositoryInstancia.ExisteSinDiscriminarIVA(dni, prepagaId);
        }
    }
}
