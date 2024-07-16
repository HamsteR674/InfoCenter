using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.SystemInfo
{
    public class SystemInfo(ApplicationContext context) : ISystemInfo
    {
        private readonly ApplicationContext _context = context;
        private DbSet<ModelTables.SystemInfo> _systemInfo = context.Set<ModelTables.SystemInfo>();


        public async Task<ModelTables.SystemInfo> GetbyId(int id)
        {

            ModelTables.SystemInfo systemInfo = await _systemInfo.SingleOrDefaultAsync(x => x.Id == id);
            if (systemInfo == null) return null;
            return systemInfo;
        }

        public async Task<List<ModelTables.SystemInfo>> GetAll()
        {
            List<ModelTables.SystemInfo> systemInfo = await _systemInfo.ToListAsync();
            if (systemInfo == null) return null;
            return systemInfo;
        }

        public void Insert(ModelTables.SystemInfo systemInfo)
        {
            _systemInfo.Add(systemInfo);
            context.SaveChanges();

        }

        public void Update(ModelTables.SystemInfo systemInfo)
        {
            _systemInfo.Update(systemInfo);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var systemInfo = _systemInfo.SingleOrDefault(x => x.Id == id);
            if (systemInfo == null) return;
            _systemInfo.Remove(systemInfo);
            context.SaveChanges();

        }
    }
}
