﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bioquimica.Entidades
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BioquimicaEntities : DbContext
    {
        public BioquimicaEntities()
            : base("name=BioquimicaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Profesional> Profesionales { get; set; }
        public virtual DbSet<Practica> Practicas { get; set; }
        public virtual DbSet<Prepaga> Prepagas { get; set; }
        public virtual DbSet<PracticasOrdenes> PracticasOrdenes { get; set; }
        public virtual DbSet<Orden> Ordenes { get; set; }
    
        public virtual ObjectResult<Practica> PracticasOrden(Nullable<int> ordenId)
        {
            var ordenIdParameter = ordenId.HasValue ?
                new ObjectParameter("OrdenId", ordenId) :
                new ObjectParameter("OrdenId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Practica>("PracticasOrden", ordenIdParameter);
        }
    
        public virtual ObjectResult<Practica> PracticasOrden(Nullable<int> ordenId, MergeOption mergeOption)
        {
            var ordenIdParameter = ordenId.HasValue ?
                new ObjectParameter("OrdenId", ordenId) :
                new ObjectParameter("OrdenId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Practica>("PracticasOrden", mergeOption, ordenIdParameter);
        }
    
        public virtual ObjectResult<Practica> PracticasCombo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Practica>("PracticasCombo");
        }
    
        public virtual ObjectResult<Practica> PracticasCombo(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Practica>("PracticasCombo", mergeOption);
        }
    
        public virtual ObjectResult<Configuracion> Encabezado()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Configuracion>("Encabezado");
        }
    
        public virtual ObjectResult<Facturacion> Detalle(Nullable<System.DateTime> fechaDesde, Nullable<System.DateTime> fechaHasta, Nullable<int> prepagaId)
        {
            var fechaDesdeParameter = fechaDesde.HasValue ?
                new ObjectParameter("FechaDesde", fechaDesde) :
                new ObjectParameter("FechaDesde", typeof(System.DateTime));
    
            var fechaHastaParameter = fechaHasta.HasValue ?
                new ObjectParameter("FechaHasta", fechaHasta) :
                new ObjectParameter("FechaHasta", typeof(System.DateTime));
    
            var prepagaIdParameter = prepagaId.HasValue ?
                new ObjectParameter("PrepagaId", prepagaId) :
                new ObjectParameter("PrepagaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Facturacion>("Detalle", fechaDesdeParameter, fechaHastaParameter, prepagaIdParameter);
        }
    
        public virtual ObjectResult<Pie> Pie(Nullable<System.DateTime> fechaDesde, Nullable<System.DateTime> fechaHasta, Nullable<int> prepagaId)
        {
            var fechaDesdeParameter = fechaDesde.HasValue ?
                new ObjectParameter("FechaDesde", fechaDesde) :
                new ObjectParameter("FechaDesde", typeof(System.DateTime));
    
            var fechaHastaParameter = fechaHasta.HasValue ?
                new ObjectParameter("FechaHasta", fechaHasta) :
                new ObjectParameter("FechaHasta", typeof(System.DateTime));
    
            var prepagaIdParameter = prepagaId.HasValue ?
                new ObjectParameter("PrepagaId", prepagaId) :
                new ObjectParameter("PrepagaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Pie>("Pie", fechaDesdeParameter, fechaHastaParameter, prepagaIdParameter);
        }
    
        public virtual int PrepagaEliminar(Nullable<int> prepagaId)
        {
            var prepagaIdParameter = prepagaId.HasValue ?
                new ObjectParameter("PrepagaId", prepagaId) :
                new ObjectParameter("PrepagaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PrepagaEliminar", prepagaIdParameter);
        }
    
        public virtual ObjectResult<FacturacionConIVARow> FacturacionConIVA(Nullable<System.DateTime> fechaDesde, Nullable<System.DateTime> fechaHasta, Nullable<int> prepagaId)
        {
            var fechaDesdeParameter = fechaDesde.HasValue ?
                new ObjectParameter("FechaDesde", fechaDesde) :
                new ObjectParameter("FechaDesde", typeof(System.DateTime));
    
            var fechaHastaParameter = fechaHasta.HasValue ?
                new ObjectParameter("FechaHasta", fechaHasta) :
                new ObjectParameter("FechaHasta", typeof(System.DateTime));
    
            var prepagaIdParameter = prepagaId.HasValue ?
                new ObjectParameter("PrepagaId", prepagaId) :
                new ObjectParameter("PrepagaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FacturacionConIVARow>("FacturacionConIVA", fechaDesdeParameter, fechaHastaParameter, prepagaIdParameter);
        }
    }
}