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


        public ModelTables.PendingTasks GetbyId(int id)
        {

            ModelTables.PendingTasks pandingTasks =  _pandingTasks.SingleOrDefault(x => x.Id == id);
            if (pandingTasks == null) return null;
            return null;
        }

        public  List<ModelTables.PendingTasks>GetAll()
        {
            List<ModelTables.PendingTasks> pandingTasks = _pandingTasks.ToList();
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

        public List<ModelTables.PendingTasks> GetbyIdDivision(long Id)
        {
            List<ModelTables.PendingTasks> pandingTasks = _pandingTasks.Where(p => p.Employees.DivisionId == Id).ToList();
            if (pandingTasks == null) return null;

            return pandingTasks;
        }

        public List<ModelTables.PendingTasks> GetbyIdCustomStand(int Id)
        {
            var tasks = _pandingTasks.Where(t=> t.Employees.CustomStandEmployees.Any(e => e.InfoCentre.Id == Id)).ToList();
            return tasks;
        }
    }
}
