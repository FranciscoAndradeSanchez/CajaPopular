//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CajaPopular
{
    using System;
    using System.Collections.Generic;
    
    public partial class solicitante
    {
        public solicitante()
        {
            this.balances = new HashSet<balance>();
            this.cotizacions = new HashSet<cotizacion>();
            this.rel_solicitante_aval = new HashSet<rel_solicitante_aval>();
            this.solicituds = new HashSet<solicitud>();
        }
    
        public int uid { get; set; }
        public string num_solicitante { get; set; }
        public Nullable<int> id_persona { get; set; }
        public string numero_socio { get; set; }
        public Nullable<int> dependientes { get; set; }
        public Nullable<decimal> sueldo { get; set; }
        public decimal sueldo_diario { get; set; }
        public string departamento { get; set; }
    
        public virtual ICollection<balance> balances { get; set; }
        public virtual ICollection<cotizacion> cotizacions { get; set; }
        public virtual persona persona { get; set; }
        public virtual ICollection<rel_solicitante_aval> rel_solicitante_aval { get; set; }
        public virtual ICollection<solicitud> solicituds { get; set; }
    }
}
