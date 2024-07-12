using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.Divisions
{
    public interface IDivisions
    {
        Task<InteractionDb.ModelTables.Divisions> GetbyId(long id);
        Task<List<InteractionDb.ModelTables.Divisions>> GetAll();
        void Update(InteractionDb.ModelTables.Divisions divisions);
        void Insert(InteractionDb.ModelTables.Divisions divisions);
        void Delete(long id);
    }
}
