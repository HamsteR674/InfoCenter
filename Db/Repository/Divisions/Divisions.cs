using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.Divisions
{
    public class Divisions(ApplicationContext context ) : IDivisions
    {

        private readonly ApplicationContext _context = context;
        private DbSet<ModelTables.Divisions> _divisions = context.Set<ModelTables.Divisions>();


        public async Task<ModelTables.Divisions> GetbyId(long id)
        {

            ModelTables.Divisions divisions = await _divisions.SingleOrDefaultAsync(x => x.Id == id);
            if (divisions == null) return null;
            return divisions;
        }

        public async Task<List<ModelTables.Divisions>> GetAll()
        {
            List<ModelTables.Divisions> divisions = await _divisions.ToListAsync();
            if (divisions == null) return null;
            return divisions;
        }

        public void Insert(ModelTables.Divisions divisions)
        {
            _divisions.Add(divisions);
            context.SaveChanges();

        }

        public void Update(ModelTables.Divisions divisions)
        {
            _divisions.Update(divisions);
            context.SaveChanges();
        }
        public void Delete(long id)
        {
            var divisions = _divisions.SingleOrDefault(x => x.Id == id);
            if (divisions == null) return;
            _divisions.Remove(divisions);
            context.SaveChanges();

        }
    }
}
