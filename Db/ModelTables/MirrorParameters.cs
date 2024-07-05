using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    public record MirrorParameters(int Id, DateTimeOffset InfoCenterUpdateTime, DateTimeOffset UpdateTimestam)
    { 
     

        public List<TakenTasks>? TakenTasks { get; set; }
        public List<PandingTasks>? PandingTasks { get; set;}

    }
}
