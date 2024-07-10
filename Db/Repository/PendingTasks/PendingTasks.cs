using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.PendingTasks
{
    public class PendingTasks(ApplicationContext context) : IPendingTasks
    {
        private readonly ApplicationContext _context = context;
        private DbSet<ModelTables.PendingTasks> _pandingTasks = context.Set<ModelTables.PendingTasks>();


        public async Task<ModelTables.PendingTasks> GetbyId(int id)
        {

            ModelTables.PendingTasks pandingTasks = await _pandingTasks.SingleOrDefaultAsync(x => x.Id == id);
            if (pandingTasks == null) return null;
            return pandingTasks;
        }

        public async Task<List<ModelTables.PendingTasks>> GetAll()
        {
            List<ModelTables.PendingTasks> pandingTasks = await _pandingTasks.ToListAsync();
            if (pandingTasks == null) return null;
            return pandingTasks;
        }

        public void Insert(ModelTables.PendingTasks pandingTasks)
        {
            _pandingTasks.Add(pandingTasks);
            context.SaveChanges();

        }

        public void Update(ModelTables.PendingTasks pandingTasks)
        {
            _pandingTasks.Update(pandingTasks);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var pandingTasks = _pandingTasks.SingleOrDefault(x => x.Id == id);
            if (pandingTasks == null) return;
            _pandingTasks.Remove(pandingTasks);
            context.SaveChanges();

        }
    }
}
