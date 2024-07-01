using Microsoft.EntityFrameworkCore;
using InfoCenter.Model_Tables;
namespace InfoCenter
{
    public class ApplicationContext : DbContext
    {
        DbSet<Employees> Employees { get; set; }
        DbSet<Session_log> SessionLog { get; set; }
        DbSet<Divisions> Divisions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=пароль_от_postgres");
        }

    }
   
}
