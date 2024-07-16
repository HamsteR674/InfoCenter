using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.PendingTasks
{
   public interface IPendingTasks
    {
        InteractionDb.ModelTables.PendingTasks GetbyId(int id);
        List<InteractionDb.ModelTables.PendingTasks>GetAll();
        List<InteractionDb.ModelTables.PendingTasks> GetbyIdDivision(long Id);
        void Update(InteractionDb.ModelTables.PendingTasks pandingTasks);
        List<InteractionDb.ModelTables.PendingTasks> GetbyIdCustomStand(int Id);

        void Insert(InteractionDb.ModelTables.PendingTasks pandingTasks);
        void Delete(int id);
    }
}
