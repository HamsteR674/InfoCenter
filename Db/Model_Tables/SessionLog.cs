
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Model_Tables
{
    public record SessionLog
    {
        public int Id { get; set; }
        public int EmployeesId { get; set; }
        public Employees Employees { get; set; }
        public string ErrorList { get; set; }


    }
    public record SessionLogMap
    {
        public SessionLogMap(EntityTypeBuilder<SessionLog> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(e => e.Id);
            entityTypeBuilder.Property(e => e.ErrorList).IsRequired();

        }
    }
}
