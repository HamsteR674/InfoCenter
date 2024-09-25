using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingData.EntityModel.Tasks
{
    public record PenTasks(int id, int ServiceCallId, string Title, string Description);
    
}
