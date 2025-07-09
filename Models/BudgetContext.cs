using Microsoft.EntityFrameworkCore;

namespace BudgetManagement.Models
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions<BudgetContext> options) : base(options) { }

        public DbSet<SurseFin> SurseFin { get; set; }
        public DbSet<ArtBug> ArtBug { get; set; }
        public DbSet<Beneficiari> Beneficiari { get; set; }
        public DbSet<Persoane> Persoane { get; set; }
        public DbSet<BugetAnt> BugetAnt { get; set; }
        public DbSet<BugetPoz> BugetPoz { get; set; }
        public DbSet<PacAntet> PacAntet { get; set; }
        public DbSet<PacLinii> PacLinii { get; set; }
        public DbSet<ColectiiAlop> ColectiiAlop { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure composite keys
            modelBuilder.Entity<BugetPoz>()
                .HasKey(bp => new { bp.BugetId, bp.ArtBugId });

            // Configure relationships
            modelBuilder.Entity<BugetPoz>()
                .HasOne(bp => bp.BugetAnt)
                .WithMany(ba => ba.BugetPozitii)
                .HasForeignKey(bp => bp.BugetId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PacLinii>()
                .HasOne(pl => pl.PacAntet)
                .WithMany(pa => pa.PacLinii)
                .HasForeignKey(pl => pl.PacAntId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}