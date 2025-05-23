using Microsoft.EntityFrameworkCore;
using MitarbeiterVerwaltung1.Models;

namespace MitarbeiterVerwaltung1.Data
{
    public class MitarbeiterVerwaltung1DbContext : DbContext
    {
        public MitarbeiterVerwaltung1DbContext(DbContextOptions<MitarbeiterVerwaltung1DbContext> options)
            : base(options)
        {
        }

        public DbSet<Mitarbeiter> Mitarbeiter { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Hier kannst du weitere Konfigurationen machen, z.B. Indizes, Beziehungen usw.
        }
    }
}