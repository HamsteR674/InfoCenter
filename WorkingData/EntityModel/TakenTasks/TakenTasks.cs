using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingData.EntityModel.TakenTasks
{
    public record  TakenTasks(int id, int ServiceCallId, string Title, string Description, bool IsProjectTask , string ServiceComponent);
    
}
