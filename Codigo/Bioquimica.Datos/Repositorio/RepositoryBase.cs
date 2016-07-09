using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Web;
using Bioquimica.Entidades;

namespace Bioquimica.Datos.Repositorio
{
    public class RepositoryBase : IDisposable
    {
        /// <summary>
        /// Contexto se entidades del dominio
        /// </summary>
        private static BioquimicaEntities ContextoEstatico;

        public BioquimicaEntities Contexto
        {
            get
            {
               
                HttpContext httpContext = HttpContext.Current;

                if (httpContext == null)
                {
                    if (ContextoEstatico == null)
                    {
                        ContextoEstatico = new BioquimicaEntities();
                      ContextoEstatico.Configuration.ValidateOnSaveEnabled = false;
                    }
                    return ContextoEstatico;
                    
                }

                if (httpContext.Items["BioquimicaContexto"] == null)
                {
                    var contexto = new BioquimicaEntities();
                    contexto.Configuration.ValidateOnSaveEnabled = false;
                    httpContext.Items["BioquimicaContexto"] = contexto;
                }
                return (BioquimicaEntities)httpContext.Items["BioquimicaContexto"];
            }
            private set
            {
                HttpContext httpContext = HttpContext.Current;

                if (httpContext == null)
                {
                    ContextoEstatico = value;
                }
                else
                {
                    httpContext.Items["BioquimicaContexto"] = value;
                }

            }
        }

        public RepositoryBase()
        {
            
        }

        public void Limpiar()
        {
            ContextoEstatico = null;
        }

        public void DetachEntity(object entity)
        {
            Contexto.Entry(entity).State = System.Data.Entity.EntityState.Detached;
        }

        public void GuardarCambios()
        {
            Contexto.SaveChanges();
        }

        public void GuardarCambiosConTransaccion()
        {
            //Desde EF 4.1
            ((IObjectContextAdapter)Contexto).ObjectContext.SaveChanges(System.Data.Entity.Core.Objects.SaveOptions.DetectChangesBeforeSave);
        }

        public void AceptarTodosLosCambios()
        {
            ((IObjectContextAdapter)Contexto).ObjectContext.AcceptAllChanges();
        }

        public System.Data.Entity.Core.Objects.ObjectContextOptions Opciones()
        {
            return ((IObjectContextAdapter)Contexto).ObjectContext.ContextOptions;
        }

        public System.Data.Entity.Core.Objects.ObjectContext ObjectContext
        {
            get
            {
                return ((IObjectContextAdapter)Contexto).ObjectContext;
            }
        }

        public void AbrirConexion()
        {
            if (ObjectContext.Connection.State != ConnectionState.Open)
            {
                ObjectContext.Connection.Open();
            }

        }

        public void CerrarConexion()
        {
            if (ObjectContext.Connection.State == ConnectionState.Open)
            {
                ObjectContext.Connection.Close();
            }
        }

        public DbTransaction Transaction
        {
            get
            {
                return ObjectContext.Connection.BeginTransaction();
            }
        }
       
        private bool ExisteContexto
        {
            get
            {
                HttpContext httpContext = HttpContext.Current;

                if (httpContext == null)
                {
                    return (ContextoEstatico != null);
                }
                return (httpContext.Items["BioquimicaContexto"] != null);
            }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (ExisteContexto)
                    {
                        Contexto.Dispose();    
                    }
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
