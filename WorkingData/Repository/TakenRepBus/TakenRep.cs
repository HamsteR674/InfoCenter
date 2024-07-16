using InteractionDb.ModelTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingData.Repository.TakenRepBus
{
    public class TakenRep(InteractionDb.Repository.TakenTasks.ITakenTasks takenTasks) : ITakenRep
    {
        public List<TakenTasks> GetbyIdCustomStandTasks(int Id)
        {
            var tasks = takenTasks.GetbyIdCustomStand(Id);
            return tasks;
        }

        public List<InteractionDb.ModelTables.TakenTasks> GetbyIdDivisionTakenTasks(long Id)
        {
            var div = takenTasks.GetbyIdDivision(Id);

            return div;
        }
    }
}
