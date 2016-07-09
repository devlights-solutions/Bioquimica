using System;
using System.Collections.Generic;
using System.Linq;
using Bioquimica.Entidades;

namespace Bioquimica.Datos.Repositorio
{
    public class ProfesionalesRepository:RepositoryBase
    {
        public List<Profesional> Listado()
        {
            List<Profesional> list = new List<Profesional>();
            try
            {
                list = Contexto.Profesionales.ToList();
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Profesional Obtener()
        {
            try
            {
                return Contexto.Profesionales.FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Guardar(Profesional profesional)
        {
            if (profesional.ProfesionalId == 0)
            {
                //CREAR
                Contexto.Profesionales.Add(profesional);
            }
            else
            {
                //EDITAR
                var original = Contexto.Profesionales.FirstOrDefault(p => p.ProfesionalId== profesional.ProfesionalId);
                Contexto.Entry(original).CurrentValues.SetValues(profesional);
            }
            try
            {
                Contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Eliminar(int profesionalId)
        {
            var profesional = Contexto.Profesionales.FirstOrDefault(p => p.ProfesionalId == profesionalId);
            Contexto.Profesionales.Remove(profesional);
            try
            {
                Contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
