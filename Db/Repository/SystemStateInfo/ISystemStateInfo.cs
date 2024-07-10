using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.SystemStateInfo
{
    internal interface ISystemStateInfo
    {
        Task<InteractionDb.ModelTables.SystemStateInfo> GetbyId(int id);
        Task<List<InteractionDb.ModelTables.SystemStateInfo>> GetAll();
        void Update(InteractionDb.ModelTables.SystemStateInfo systemStateInfo);
        void Insert(InteractionDb.ModelTables.SystemStateInfo systemStateInfo);
        void Delete(int id);
    }
}
