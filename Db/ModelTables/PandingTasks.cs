using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    public record PandingTasks(int Id, int ServiceCallId, string ServiceCallTitle, string Description)
    {
    

        public MirrorParameters UpdateTime {  get; set; } 
     
        public Employees Employees { get; set; }

    }
}
