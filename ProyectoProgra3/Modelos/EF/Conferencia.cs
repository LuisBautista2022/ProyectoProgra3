//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelos.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Conferencia
    {
        public int idConferencia { get; set; }
        public string nombreConferencia { get; set; }
        public string informacion { get; set; }
        public string nombreDisertante { get; set; }
        public string informacionDisertante { get; set; }
        public string correo { get; set; }
        public string celular { get; set; }
        public string hora { get; set; }
        public System.DateTime fechaInicio { get; set; }
        public string ubicacion { get; set; }
        public decimal precio { get; set; }
        public System.DateTime fechaFin { get; set; }
    }
}
