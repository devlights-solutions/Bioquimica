using System;
using System.Collections.Generic;
using System.Linq;

using Bioquimica.Entidades;

namespace Bioquimica.Datos.Repositorio
{
    public class OrdenesRepository:RepositoryBase
    {
        public List<Orden> Listado(int nroOrden, int prepagaId, string paciente, DateTime fechaAtencion, bool? discriminaIVA)
        {
            return Contexto.Ordenes.Where(o => (nroOrden == 0 || nroOrden == o.NroOrden) &&
                                               (prepagaId == 0 || prepagaId == o.PrepagaId) &&
                                               (discriminaIVA == null || (discriminaIVA == true && o.DiscriminaIVA) || (discriminaIVA == false && !o.DiscriminaIVA)) &&
                                               (string.IsNullOrEmpty(paciente) || o.PacienteNombre.Contains(paciente) || o.PacienteDNI.ToString().Equals(paciente)) &&
                                               (fechaAtencion >= o.FechaAtencion)).OrderByDescending(o=>o.FechaAtencion).ToList();
        }

        public List<Practica> ListadoPracticasOrden(int ordenId)
        {
            return Contexto.PracticasOrden(ordenId).ToList();
        }

        public List<Paciente> ListadoPacientes()
        {
            return Contexto.Ordenes.GroupBy(p => p.PacienteDNI).Select(o => new Paciente{Nombre = o.First().PacienteNombre,
            DNI = o.First().PacienteDNI.Value,FechaNacimiento = o.First().PacienteFechaNacimiento.Value}).Take(30).ToList();
        }

        public Orden Obtener(int ordenId)
        {
            return Contexto.Ordenes.Include("PracticasOrdenes")
                            .Include("PracticasOrdenes.Practica")
                            .Include("Prepagas")
                            .FirstOrDefault(o => o.OrdenId == ordenId);
        }

        public bool Guardar(Orden orden)
        {
            if (orden.OrdenId == 0)
            {
                //CREAR
                Contexto.Ordenes.Add(orden);
            }
            else
            {
                var practicas = Contexto.PracticasOrdenes.Where(p => p.OrdenId == orden.OrdenId).ToList();
                foreach (var practica in practicas)
                {
                    Contexto.PracticasOrdenes.Remove(practica);
                }
                var original = Contexto.Ordenes.FirstOrDefault(t => t.OrdenId == orden.OrdenId);
                Contexto.Entry(original).CurrentValues.SetValues(orden);
            }

            Contexto.SaveChanges();
            return true;
        }

        public bool Eliminar(int ordenId)
        {
            try
            {
                var practicas = Contexto.PracticasOrdenes.Where(o => o.OrdenId == ordenId).ToList();
                foreach (var practica in practicas)
                {
                    Contexto.PracticasOrdenes.Remove(practica);
                }

                var orden = Contexto.Ordenes.FirstOrDefault(o => o.OrdenId == ordenId);
                Contexto.Ordenes.Remove(orden);

                Contexto.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }


        public Orden ObtenerPorDni(int dni)
        {
            return Contexto.Ordenes.FirstOrDefault(x => x.PacienteDNI == dni);
        }

        public void DiscriminarIVA(int dni, int prepagaId)
        {
            var ordenes = Contexto.Ordenes.Where(x => x.PacienteDNI == dni && x.PrepagaId == prepagaId && !x.DiscriminaIVA).ToList();
            foreach (var orden in ordenes)
            {
                orden.DiscriminaIVA = true;
            }
            Contexto.SaveChanges();
        }

        public bool ExisteSinDiscriminarIVA(int dni, int prepagaId)
        {
            return Contexto.Ordenes.Any(x => x.PacienteDNI == dni && x.PrepagaId == prepagaId && !x.DiscriminaIVA);
        }
    }
}
