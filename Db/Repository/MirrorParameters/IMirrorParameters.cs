using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.MirrorParameters
{
    public interface IMirrorParameters
    {
        Task<InteractionDb.ModelTables.MirrorParameters> GetbyId(int id);
        Task<List<InteractionDb.ModelTables.MirrorParameters>> GetAll();
        void Update(InteractionDb.ModelTables.MirrorParameters mirrorParameterss);
        void Insert(InteractionDb.ModelTables.MirrorParameters mirrorParameters);
       
        void Delete(int id);
    }
}
