
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InteractionDb.ModelTables
{
    public record SessionLog(int Id, string ErrorList )
    {
      
        public int EmployeesId { get; set; }
        public Employees Employees { get; set; }
     

    }
   
}
