using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.Settings
{
    public interface ISettings
    {
        Task<InteractionDb.ModelTables.Settings> GetbyId(int id);
        Task<List<InteractionDb.ModelTables.Settings>> GetAll();
        void Update(InteractionDb.ModelTables.Settings settings);
        void Insert(InteractionDb.ModelTables.Settings settings);
        void Delete(int id);
    }
}
