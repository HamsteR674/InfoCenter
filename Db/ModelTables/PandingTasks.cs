using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    public class PandingTasks()
    {

        public int Id {  get; set; }
        public int ServiceCallId { get; set; }
        public string ServiceCallTitle { get; set; }
        public string Description { get; set; }
        public MirrorParameters UpdateTime {  get; set; } 
     
        public Employees Employees { get; set; }

    }
}
