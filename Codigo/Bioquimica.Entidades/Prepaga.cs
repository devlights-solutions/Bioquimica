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
    
    public partial class Prepaga
    {
        public Prepaga()
        {
            this.Ordens = new HashSet<Orden>();
        }
    
        public int PrepagaId { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public decimal NBU { get; set; }
        public bool DiscriminaIVA { get; set; }
        public Nullable<decimal> PorcentajeIVA { get; set; }
    
        public virtual ICollection<Orden> Ordens { get; set; }
    }
}
