using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.SystemInfo
{
    public interface ISystemInfo
    {
        Task<InteractionDb.ModelTables.SystemInfo> GetbyId(int id);
        Task<List<InteractionDb.ModelTables.SystemInfo>> GetAll();
        void Update(InteractionDb.ModelTables.SystemInfo systemInfo);
        void Insert(InteractionDb.ModelTables.SystemInfo systemInfo);
        void Delete(int id);
    }
}
