//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using CajaPopular.Models;

namespace CajaPopular
{
    using System;
    using System.Collections.Generic;
    
    public partial class cotizacion
    {
        public cotizacion()
        {
            this.CotizacionResult = new HashSet<CotizacionResult>();
        }

        public int uid { get; set; }
        public Nullable<int> num_solicitante { get; set; }
        public Nullable<decimal> monto_solicitado { get; set; }
        public Nullable<int> plazo { get; set; }
        public Nullable<System.DateTime> fecha_captura { get; set; }
        public Nullable<System.DateTime> fecha_entrega { get; set; }
        public Nullable<decimal> monto_asignado { get; set; }
        public Nullable<double> tasa { get; set; }


    
        public virtual solicitante solicitante { get; set; }
        public  ICollection<CotizacionResult> CotizacionResult { get; set; }
        public List<CotizacionResult> CotizacionResultssList { get; set; }
    }


    }
