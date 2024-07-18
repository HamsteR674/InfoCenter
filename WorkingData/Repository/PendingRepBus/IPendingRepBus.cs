using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InteractionDb.ModelTables;
using WorkingData.EntityModel.Tasks;

namespace WorkingData.Repository.PendingRepBus
{
    public interface IPendingRepBus
    {
        List<PenTasks> GetAll();
        List<PendingTasks> GetbyIdDivisionPendingTasks(long id);
        List<PendingTasks> GetbyCustomStandTasks(int id);
        void Update(WorkingData.EntityModel.Tasks.NewTasks newTasks);
   

    }
}
