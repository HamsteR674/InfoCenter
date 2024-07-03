using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Model_Tables
{
    public record CustomStandEmployees
    {
        public int Id { get; set; }
        public int InfoCentreId { get; set; }
        public CustomStandInfo  CustomStandInfo { get; set; }

        public Employees Employees { get; set; }
        public int EmployeesId { get; set; }
    }
    public record CustomStandEmployeesMap
    {
        public CustomStandEmployeesMap(EntityTypeBuilder<CustomStandEmployees> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(e => e.Id);
            entityTypeBuilder.
                HasOne(e => e.Employees)
                .WithMany(e => e.CustomStandEmployees)
                .HasForeignKey(e => e.EmployeesId);
            entityTypeBuilder.
                HasOne(e => e.CustomStandInfo)
                .WithMany(e => e.CustomStandEmployees)
                .HasForeignKey(e => e.InfoCentreId);
        }
    }
}
