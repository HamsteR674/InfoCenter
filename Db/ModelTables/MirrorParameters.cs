using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    public class MirrorParameters()
    {

        public int Id { get; set; }
        public DateTimeOffset InfoCenterUpdateTime { get; set; }
        public DateTimeOffset UpdateTimestam { get; set; }
        public List<TakenTasks>? TakenTasks { get; set; }
        public List<PendingTasks>? PandingTasks { get; set;}

    }
}
