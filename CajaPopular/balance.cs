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
    
    public partial class balance
    {
        public int id_solicitante { get; set; }
        public int factura { get; set; }
        public int num_documento { get; set; }
        public string descripcion { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public Nullable<System.DateTime> fecha_captura { get; set; }
        public Nullable<System.DateTime> fecha_vencimiento { get; set; }
        public Nullable<System.DateTime> fecha_pago { get; set; }
        public Nullable<int> capturista { get; set; }
        public Nullable<bool> borrado { get; set; }
        public Nullable<bool> cubierto { get; set; }
    
        public virtual solicitante solicitante { get; set; }
        public virtual usuario usuario { get; set; }
    }
}