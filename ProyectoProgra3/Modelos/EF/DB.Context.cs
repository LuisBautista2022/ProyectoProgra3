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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ConferenciasEntities : DbContext
    {
        public ConferenciasEntities()
            : base("name=ConferenciasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Conferencia> Conferencia { get; set; }
        public virtual DbSet<ConferenciaPersona> ConferenciaPersona { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
