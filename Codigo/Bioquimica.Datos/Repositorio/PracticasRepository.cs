using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core;
using System.Linq;
using Bioquimica.Entidades;

namespace Bioquimica.Datos.Repositorio
{
    public class PracticasRepository:RepositoryBase
    {
        public List<Practica> Listado(string descripcion)
        {
            
            var list= Contexto.Practicas.Where(p => (string.IsNullOrEmpty(descripcion) || p.Descripcion.Contains(descripcion) ||
                                            p.Codigo.ToString().Equals(descripcion)) ).ToList();
            this.ObjectContext.Refresh(RefreshMode.StoreWins, list);
            return list;
        }

        public List<Practica> Listado()
        {
            return Contexto.Practicas.ToList();
        }

        public Practica Obtener(int practicaId)
        {
            return Contexto.Practicas.FirstOrDefault(p => p.PracticaId == practicaId);
        }

        public bool Guardar(Practica practica)
        {
            if (practica.PracticaId == 0)
            {
                //CREAR
                Contexto.Practicas.Add(practica);
            }
            else
            {
                //EDITAR
                var original = Contexto.Practicas.FirstOrDefault(p => p.PracticaId == practica.PracticaId);
                Contexto.Entry(original).CurrentValues.SetValues(practica);
            }

            Contexto.SaveChanges();
            return true;
        }

        public bool Eliminar(int practicaId)
        {
            var practica = Contexto.Practicas.FirstOrDefault(p => p.PracticaId == practicaId);
            Contexto.Practicas.Remove(practica);

            Contexto.SaveChanges();
            return true;
        }
    }
}
