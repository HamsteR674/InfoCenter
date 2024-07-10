using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.TakenTasks
{
    internal interface ITakenTasks
    {
        Task<InteractionDb.ModelTables.TakenTasks> GetbyId(int id);
        Task<List<InteractionDb.ModelTables.TakenTasks>> GetAll();
        void Update(InteractionDb.ModelTables.TakenTasks takenTasks);
        void Insert(InteractionDb.ModelTables.TakenTasks takenTasks);
        void Delete(int id);
    }
}
