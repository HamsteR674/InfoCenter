using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.TakenTasks
{
    public interface ITakenTasks
    {
        InteractionDb.ModelTables.TakenTasks GetbyId(int id);
        Task<List<InteractionDb.ModelTables.TakenTasks>> GetAll();
        void Update(InteractionDb.ModelTables.TakenTasks takenTasks);
        void Insert(InteractionDb.ModelTables.TakenTasks takenTasks);
        List<InteractionDb.ModelTables.TakenTasks> GetbyIdCustomStand(int Id);
        List<InteractionDb.ModelTables.TakenTasks> GetbyIdDivision(long Id);
        void Delete(int id);
    }
}
