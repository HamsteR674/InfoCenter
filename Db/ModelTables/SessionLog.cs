
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InteractionDb.ModelTables
{
    public class SessionLog()
    {
        public int Id {  get; set; }
        public string ErrorList { get; set; }
        public int EmployeesId { get; set; }
        public Employees Employees { get; set; }
     

    }
   
}
