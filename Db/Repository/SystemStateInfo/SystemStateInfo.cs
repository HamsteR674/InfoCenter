using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.SystemStateInfo
{
    public class SystemStateInfo(ApplicationContext context) : ISystemStateInfo
    {
        private readonly ApplicationContext _context = context;
        private DbSet<ModelTables.SystemStateInfo> _systemStateInfo = context.Set<ModelTables.SystemStateInfo>();


        public async Task<ModelTables.SystemStateInfo> GetbyId(int id)
        {

            ModelTables.SystemStateInfo systemStateInfo = await _systemStateInfo.SingleOrDefaultAsync(x => x.Id == id);
            if (systemStateInfo == null) return null;
            return systemStateInfo;
        }

        public async Task<List<ModelTables.SystemStateInfo>> GetAll()
        {
            List<ModelTables.SystemStateInfo> systemStateInfo = await _systemStateInfo.ToListAsync();
            if (systemStateInfo == null) return null;
            return systemStateInfo;
        }

        public void Insert(ModelTables.SystemStateInfo systemStateInfo)
        {
            _systemStateInfo.Add(systemStateInfo);
            context.SaveChanges();

        }

        public void Update(ModelTables.SystemStateInfo systemStateInfo)
        {
            _systemStateInfo.Update(systemStateInfo);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var systemStateInfo = _systemStateInfo.SingleOrDefault(x => x.Id == id);
            if (systemStateInfo == null) return;
            _systemStateInfo.Remove(systemStateInfo);
            context.SaveChanges();

        }
    }
}
