using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingData.Repository.TakenRepBus
{
    public interface ITakenRep
    {
        public List<InteractionDb.ModelTables.TakenTasks> GetbyIdDivisionTakenTasks(long Id);
        public List<InteractionDb.ModelTables.TakenTasks> GetbyIdCustomStandTasks(int Id);
    }
}
