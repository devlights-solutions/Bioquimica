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
    
    public partial class PracticasOrden
    {
        public int PracticaOrdenId { get; set; }
        public int PracticaId { get; set; }
        public int OrdenId { get; set; }
    
        public virtual Orden Orden { get; set; }
        public virtual Practica Practica { get; set; }
    }
}