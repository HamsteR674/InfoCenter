using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.SessionLog
{
    public class SessionLogcs(ApplicationContext context) : ISessionLog
    {
        private readonly ApplicationContext _context = context;
        private DbSet<ModelTables.SessionLog> _sessionLog = context.Set<ModelTables.SessionLog>();


        public async Task<ModelTables.SessionLog> GetbyId(int id)
        {

            ModelTables.SessionLog sessionLog = await _sessionLog.SingleOrDefaultAsync(x => x.Id == id);
            if (sessionLog == null) return null;
            return sessionLog;
        }

        public async Task<List<ModelTables.SessionLog>> GetAll()
        {
            List<ModelTables.SessionLog> sessionLog = await _sessionLog.ToListAsync();
            if (sessionLog == null) return null;
            return sessionLog;
        }

        public void Insert(ModelTables.SessionLog sessionLog)
        {
            _sessionLog.Add(sessionLog);
            context.SaveChanges();

        }

        public void Update(ModelTables.SessionLog sessionLog)
        {
            _sessionLog.Update(sessionLog);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var sessionLog = _sessionLog.SingleOrDefault(x => x.Id == id);
            if (sessionLog == null) return;
            _sessionLog.Remove(sessionLog);
            context.SaveChanges();

        }
    }
}
