using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingData.Repository.DivisionsBus
{
    public interface IDivisionRep
    {
        public List<InteractionDb.ModelTables.PendingTasks> GetbyIdDivisionPendingTasks(long Id);
        public List<InteractionDb.ModelTables.PendingTasks> GetbyIdDivisionTakenTasks(long Id);
    }
}
