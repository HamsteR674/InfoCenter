using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.CustomStandRights
{
    public class CustomStandRights(ApplicationContext context) : ICustomStandRights
    {
        private readonly ApplicationContext _context = context;
        private DbSet<ModelTables.CustomStandRights> _customStandRights = context.Set<ModelTables.CustomStandRights>();


        public async Task<ModelTables.CustomStandRights> GetbyId(int id)
        {

            ModelTables.CustomStandRights customStandRights = await _customStandRights.SingleOrDefaultAsync(x => x.Id == id);
            if (customStandRights == null) return null;
            return customStandRights;
        }

        public async Task<List<ModelTables.CustomStandRights>> GetAll()
        {
            List<ModelTables.CustomStandRights> customStandRights = await _customStandRights.ToListAsync();
            if (customStandRights == null) return null;
            return customStandRights;
        }

        public void Insert(ModelTables.CustomStandRights customStandRights)
        {
            _customStandRights.Add(customStandRights);
            context.SaveChanges();

        }

        public void Update(ModelTables.CustomStandRights customStandRights)
        {
            _customStandRights.Update(customStandRights);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var customStandRights = _customStandRights.SingleOrDefault(x => x.Id == id);
            if (customStandRights == null) return;
            _customStandRights.Remove(customStandRights);
            context.SaveChanges();

        }
    }
}
