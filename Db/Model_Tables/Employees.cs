
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Model_Tables
{
    public record Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsFired { get; set; }
        public string Code { get; set; }

        public long DivisionId { get; set; }
        public Divisions Divisions { get; set; }

        public List<Divisions>? ChefDivisions { get; set; }

        public List<SessionLog> Logs { get; set; }
        
        public List<Settings> Settings { get; set; }

        
        public List<CustomStandEmployees> CustomStandEmployees { get; set; }
       
        }
    public record EmployeesMap
    {
        public EmployeesMap(EntityTypeBuilder<Employees> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(e => e.Id);
            entityTypeBuilder.Property(e => e.Name).IsRequired();
            entityTypeBuilder.Property(e => e.Email).IsRequired();
            entityTypeBuilder.Property(e => e.IsFired).IsRequired();
            entityTypeBuilder.Property(e => e.Code).IsRequired();
            entityTypeBuilder
                .HasMany(e => e.Logs)
                .WithOne(e => e.Employees)
                .HasForeignKey(e => e.EmployeesId).IsRequired();
            entityTypeBuilder
                .HasMany(e => e.Settings)
                .WithOne(e => e.Employees)
                .HasForeignKey(e => e.EmployeesId).IsRequired();
            //entityTypeBuilder.
            //    HasMany(e => e.ChefDivisions)
            //    .WithOne(e => e.Chef)
            //    .HasForeignKey(e => e.ChiefId).IsRequired();
            //entityTypeBuilder
            //    .HasOne(e => e.Divisions)
            //    .WithMany(e => e.Employees)
            //    .HasForeignKey(e => e.DivisionId).IsRequired();
        }
    }
}
