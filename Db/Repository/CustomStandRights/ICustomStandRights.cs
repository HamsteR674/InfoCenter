using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.CustomStandRights
{
    internal interface ICustomStandRights
    {
        Task<InteractionDb.ModelTables.CustomStandRights> GetbyId(int id);
        Task<List<InteractionDb.ModelTables.CustomStandRights>> GetAll();
        void Update(InteractionDb.ModelTables.CustomStandRights customStand);
        void Insert(InteractionDb.ModelTables.CustomStandRights customStand);
        void Delete(int id);
    }
}
