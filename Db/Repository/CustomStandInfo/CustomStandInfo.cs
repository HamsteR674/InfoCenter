using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.Repository.CustomStandInfo
{
    public class CustomStandInfo(ApplicationContext context) : ICustomStandInfo
    {
        private readonly ApplicationContext _context = context;
        private DbSet<ModelTables.CustomStandInfo> _customStandInfo = context.Set<ModelTables.CustomStandInfo>();
        public async Task<ModelTables.CustomStandInfo> GetbyId(int id)
        {

            ModelTables.CustomStandInfo customStandInfo = await _customStandInfo.SingleOrDefaultAsync(x => x.Id == id);
            if (customStandInfo == null) return null;
            return customStandInfo;
        }

        public async Task<List<ModelTables.CustomStandInfo>> GetAll()
        {
            List<ModelTables.CustomStandInfo> customStandInfo = await _customStandInfo.ToListAsync();
            if (customStandInfo == null) return null;
            return customStandInfo;
        }

        public void Insert(ModelTables.CustomStandInfo customStandInfo)
        {
            _customStandInfo.Add(customStandInfo);
            context.SaveChanges();

        }

        public void Update(ModelTables.CustomStandInfo customStandInfo)
        {
            _customStandInfo.Update(customStandInfo);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var customStandInfo = _customStandInfo.SingleOrDefault(x => x.Id == id);
            if (customStandInfo == null) return;
            _customStandInfo.Remove(customStandInfo);
            context.SaveChanges();

        }

        //public List<PendingTasks.PendingTasks> GetTasksbyId(int id)
        //{
        //    //var tasks = _customStandInfo.SingleOrDefault(e => e.Id == id).CustomStandEmployees.ToList().SelectMany(e => e.Employees.PandingTasks)   ;
        //    ////List<PendingTasks.PendingTasks> result = new List<PendingTasks.PendingTasks>();
        //    ////foreach
        //    //return tasks;
        //}
    }
}
