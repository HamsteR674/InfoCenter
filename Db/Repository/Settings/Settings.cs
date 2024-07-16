using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.Settings
{
    public class Settings(ApplicationContext context) : ISettings
    {
        private readonly ApplicationContext _context = context;
        private DbSet<ModelTables.Settings> _settings = context.Set<ModelTables.Settings>();


        public async Task<ModelTables.Settings> GetbyId(int id)
        {

            ModelTables.Settings settings = await _settings.SingleOrDefaultAsync(x => x.Id == id);
            if (settings == null) return null;
            return settings;
        }

        public async Task<List<ModelTables.Settings>> GetAll()
        {
            List<ModelTables.Settings> settings = await _settings.ToListAsync();
            if (settings == null) return null;
            return settings;
        }

        public void Insert(ModelTables.Settings settings)
        {
            _settings.Add(settings);
            context.SaveChanges();

        }

        public void Update(ModelTables.Settings settings)
        {
            _settings.Update(settings);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var settings = _settings.SingleOrDefault(x => x.Id == id);
            if (settings == null) return;
            _settings.Remove(settings);
            context.SaveChanges();

        }
    }
}
