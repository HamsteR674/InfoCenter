using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InteractionDb.ModelTables
{
    public record TakenTasks(int Id, string Tittle, DateTimeOffset ExpirationData, string Description, string Service, string ServiceComponent, bool IsProjectTask, int ServiceCallId)
    {
    

     
        public Employees Employees { get; set; }

    }
}
