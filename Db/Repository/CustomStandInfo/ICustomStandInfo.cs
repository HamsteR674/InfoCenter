using InteractionDb.ModelTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InteractionDb.ModelTables;

namespace InteractionDb.Repository.CustomStandInfo
{
    public interface ICustomStandInfo
    {
        Task<InteractionDb.ModelTables.CustomStandInfo> GetbyId(int id);
        Task<List<InteractionDb.ModelTables.CustomStandInfo>> GetAll();
        void Update(InteractionDb.ModelTables.CustomStandInfo customStandEmployees);
        void Insert(InteractionDb.ModelTables.CustomStandInfo customStandEmployees);
        //List<PendingTasks.PendingTasks> GetTasksbyId(int id);
        void Delete(int id);
    }
}
