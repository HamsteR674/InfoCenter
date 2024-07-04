using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    public record MirrorParameters
    { 
        public int Id { get; set; }
        public DateTimeOffset InfoCenterUpdateTime { get; set; }
        public DateTimeOffset UpdateTimestamp { get; set; }

        public List<TakenTasks>? TakenTasks { get; set; }
        public List<PandingTasks>? PandingTasks { get; set;}

    }
}
