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


        public ModelTables.TakenTasks GetbyId(int id)
        {

            ModelTables.TakenTasks takenTasks =  _takenTasks.SingleOrDefault(x => x.Id == id);
            
            return takenTasks;
        }

        public List<ModelTables.TakenTasks> GetAll()
        {
            List<ModelTables.TakenTasks> takenTasks =  _takenTasks.ToList();
           
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

        public List<ModelTables.TakenTasks> GetbyIdDivision(long Id)
        {

            List<ModelTables.TakenTasks> pandingTasks = _takenTasks.Where(p => p.Employees.DivisionId == Id).ToList();
          

            return pandingTasks;
        }

        public List<ModelTables.TakenTasks> GetbyIdCustomStand(int Id)
        {
           var tasks = _takenTasks.Where(t => t.Employees.CustomStandEmployees.Any(e => e.InfoCentre.Id == Id)).ToList();
            return tasks; 
        }
    }
}
