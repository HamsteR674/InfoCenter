using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.SessionLog
{
    internal interface ISessionLog
    {
        Task<InteractionDb.ModelTables.SessionLog> GetbyId(int id);
        Task<List<InteractionDb.ModelTables.SessionLog>> GetAll();
        void Update(InteractionDb.ModelTables.SessionLog sessionLog);
        void Insert(InteractionDb.ModelTables.SessionLog sessionLog);
        void Delete(int id);
    }
}
