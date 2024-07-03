using Microsoft.EntityFrameworkCore;
using Db.Model_Tables;
namespace Db
{
    public class ApplicationContext : DbContext
    {
        DbSet<Employees> Employees { get; set; }
        DbSet<SessionLog> SessionLog { get; set; }
        DbSet<Divisions> Divisions { get; set; }
        DbSet<Settings> Settings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Divisions>()
                .HasOne(a => a.Chef)
                .WithMany(b => b.ChefDivisions)
                .HasForeignKey(b => b.ChiefId);

            modelBuilder.Entity<Employees>()
                .HasOne(a => a.Divisions)
                .WithMany(b => b.Employees)
                .HasForeignKey(b => b.DivisionId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Test;Username=postgres;Password=1710");
        }

    }
   
}
