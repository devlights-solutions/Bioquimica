using System;
using System.Collections.Generic;
using System.Linq;
using Bioquimica.Entidades;

namespace Bioquimica.Datos.Repositorio
{
    public class PrepagaRepository: RepositoryBase
    {
        public List<Prepaga> Listado(string descripcion)
        {
            return Contexto.Prepagas.Where(p=>p.Nombre.Contains(descripcion)).ToList();
        }

        public List<Prepaga> Listado()
        {
            return Contexto.Prepagas.ToList();
        }

        public Prepaga Obtener(int prepagaId)
        {

            return Contexto.Prepagas.FirstOrDefault(p => p.PrepagaId == prepagaId);
        }

        public bool Guardar(Prepaga prepaga)
        {
            if (prepaga.PrepagaId == 0)
            {
                //CREAR
                Contexto.Prepagas.Add(prepaga);
            }
            else
            {
                //EDITAR
                var original = Contexto.Prepagas.FirstOrDefault(p => p.PrepagaId == prepaga.PrepagaId);
                Contexto.Entry(original).CurrentValues.SetValues(prepaga);
            }

            Contexto.SaveChanges();
            return true;
        }

        public bool Eliminar(int prepagaId)
        {
            try
            {
                Contexto.PrepagaEliminar(prepagaId);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
