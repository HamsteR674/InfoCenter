using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.PendingTasks
{
    internal interface IPendingTasks
    {
        Task<InteractionDb.ModelTables.PendingTasks> GetbyId(int id);
        Task<List<InteractionDb.ModelTables.PendingTasks>> GetAll();
        void Update(InteractionDb.ModelTables.PendingTasks pandingTasks);
        void Insert(InteractionDb.ModelTables.PendingTasks pandingTasks);
        void Delete(int id);
    }
}
