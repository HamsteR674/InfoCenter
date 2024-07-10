using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InteractionDb.ModelTables;

namespace InteractionDb.Repository.CustomStandEmployees
{
    public interface ICustomStandEmployees
    {
        Task<InteractionDb.ModelTables.CustomStandEmployees> GetbyId(int id);
        Task<List<InteractionDb.ModelTables.CustomStandEmployees>> GetAll();
        void Update(InteractionDb.ModelTables.CustomStandEmployees customStandEmployees);
        void Insert(InteractionDb.ModelTables.CustomStandEmployees customStandEmployees);
        void Delete(int id);

    }
}
