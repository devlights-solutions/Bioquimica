//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Practica
    {
        public Practica()
        {
            this.PracticasOrdenes = new HashSet<PracticasOrdenes>();
        }
    
        public int PracticaId { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Nomenclador { get; set; }
        public decimal UB { get; set; }
    
        public virtual ICollection<PracticasOrdenes> PracticasOrdenes { get; set; }
    }
}
