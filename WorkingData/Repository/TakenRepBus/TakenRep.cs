using InteractionDb.ModelTables;
using InteractionDb.Repository.TakenTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingData.EntityModel.Tasks;

namespace WorkingData.Repository.TakenRepBus
{
    public class TakenRep(InteractionDb.Repository.TakenTasks.ITakenTasks takenTasks) : ITakenRep
    {
       

        public List<TakTasks> GetAll()
        {
            List<TakTasks> takTasks = new List<TakTasks>();
            var tasks = takenTasks.GetAll();
            foreach (var task in tasks)
            {
                TakTasks t = new TakTasks(task.Id,task.ServiceCallId,task.Tittle,task.Description,task.ExpirationData,task.Service,task.ServiceComponent,task.IsProjectTask);
                takTasks.Add(t);
            }
            return takTasks;
        }

        public List<InteractionDb.ModelTables.TakenTasks> GetbyIdCustomStandTasks(int Id)
        {
            var tasks = takenTasks.GetbyIdCustomStand(Id);
            return tasks;
        }

        public List<TakTasks> GetbyIdDivisionTakenTasks(long Id)
        {
            List<TakTasks> listTasks = new List<TakTasks>();
            var tasks = takenTasks.GetbyIdDivision(Id);
            foreach (var task in tasks)
            {
                TakTasks t = new TakTasks(task.Id, task.ServiceCallId, task.Tittle, task.Description, task.ExpirationData, task.Service, task.ServiceComponent, task.IsProjectTask);
                listTasks.Add(t);
            }
            return listTasks;
        }
    }
}
