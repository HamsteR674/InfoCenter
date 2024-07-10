using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.CustomStandInfo
{
    internal interface ICustomStandInfo
    {
        Task<InteractionDb.ModelTables.CustomStandInfo> GetbyId(int id);
        Task<List<InteractionDb.ModelTables.CustomStandInfo>> GetAll();
        void Update(InteractionDb.ModelTables.CustomStandInfo customStandEmployees);
        void Insert(InteractionDb.ModelTables.CustomStandInfo customStandEmployees);
        void Delete(int id);
    }
}
