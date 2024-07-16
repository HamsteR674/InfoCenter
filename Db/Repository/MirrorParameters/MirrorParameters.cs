using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.MirrorParameters
{
    public class MirrorParameters(ApplicationContext context) : IMirrorParameters
    {
        private readonly ApplicationContext _context = context;
        private DbSet<ModelTables.MirrorParameters> _mirrorParameters = context.Set<ModelTables.MirrorParameters>();


        public async Task<ModelTables.MirrorParameters> GetbyId(int id)
        {

            ModelTables.MirrorParameters mirrorParameters = await _mirrorParameters.SingleOrDefaultAsync(x => x.Id == id);
            if (mirrorParameters == null) return null;
            return mirrorParameters;
        }

        public async Task<List<ModelTables.MirrorParameters>> GetAll()
        {
            List<ModelTables.MirrorParameters> mirrorParameters = await _mirrorParameters.ToListAsync();
            if (mirrorParameters == null) return null;
            return mirrorParameters;
        }

        public void Insert(ModelTables.MirrorParameters mirrorParameters)
        {
            _mirrorParameters.Add(mirrorParameters);
            context.SaveChanges();

        }

        public void Update(ModelTables.MirrorParameters mirrorParameters)
        {
            _mirrorParameters.Update(mirrorParameters);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var mirrorParameters = _mirrorParameters.SingleOrDefault(x => x.Id == id);
            if (mirrorParameters == null) return;
            _mirrorParameters.Remove(mirrorParameters);
            context.SaveChanges();

        }
    }
}
