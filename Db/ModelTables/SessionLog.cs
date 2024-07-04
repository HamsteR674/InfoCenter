
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InteractionDb.ModelTables
{
    public record SessionLog
    {
        public int Id { get; set; }
        public int EmployeesId { get; set; }
        public Employees Employees { get; set; }
        public string ErrorList { get; set; }


    }
   
}
