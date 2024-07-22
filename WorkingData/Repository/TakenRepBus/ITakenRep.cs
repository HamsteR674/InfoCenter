using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingData.EntityModel.Tasks;

namespace WorkingData.Repository.TakenRepBus
{
    public interface ITakenRep
    {
        List<TakTasks> GetbyIdDivisionTakenTasks(long Id);
        public List<InteractionDb.ModelTables.TakenTasks> GetbyIdCustomStandTasks(int Id);
        List<TakTasks> GetAll();

    }
}
