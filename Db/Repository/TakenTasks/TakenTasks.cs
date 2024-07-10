using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.TakenTasks
{
    public class TakenTasks(ApplicationContext context) : ITakenTasks
    {
        private readonly ApplicationContext _context = context;
        private DbSet<ModelTables.TakenTasks> _takenTasks = context.Set<ModelTables.TakenTasks>();


        public async Task<ModelTables.TakenTasks> GetbyId(int id)
        {

            ModelTables.TakenTasks takenTasks = await _takenTasks.SingleOrDefaultAsync(x => x.Id == id);
            if (takenTasks == null) return null;
            return takenTasks;
        }

        public async Task<List<ModelTables.TakenTasks>> GetAll()
        {
            List<ModelTables.TakenTasks> takenTasks = await _takenTasks.ToListAsync();
            if (takenTasks == null) return null;
            return takenTasks;
        }

        public void Insert(ModelTables.TakenTasks takenTasks)
        {
            _takenTasks.Add(takenTasks);
            context.SaveChanges();

        }

        public void Update(ModelTables.TakenTasks takenTasks)
        {
            _takenTasks.Update(takenTasks);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var takenTasks = _takenTasks.SingleOrDefault(x => x.Id == id);
            if (takenTasks == null) return;
            _takenTasks.Remove(takenTasks);
            context.SaveChanges();

        }
    }
}
