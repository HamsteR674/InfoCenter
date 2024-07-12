using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using InteractionDb.ModelTables;
using InteractionDb.Repository.Divisions;
using WorkingData.EntityModel.PendingTasks;
using WorkingData.Repository.DivisionsBus;

namespace WorkingData.Repository.DivisionsBus
{
    public class DivisionRep(InteractionDb.Repository.PendingTasks.IPendingTasks pendingTasks, InteractionDb.Repository.Divisions.IDivisions divisions) : IDivisionRep
    {
        public List<InteractionDb.ModelTables.PendingTasks> GetbyIdDivisionPendingTasks(long Id)
        {
            var divi = pendingTasks.GetAll().Result.Where(p => p.Employees.DivisionId == Id).ToList()/*.Result.Join(pendingTasks,p => p.)*/;
            return divi;
          
        }
        public List<InteractionDb.ModelTables.PendingTasks> GetbyIdDivisionTakenTasks(long Id)
        {
           List< List<InteractionDb.ModelTables.PendingTasks> >div = divisions.GetbyId(Id).Result.Employees.Select(e => e.PandingTasks).ToList();
            List <InteractionDb.ModelTables.PendingTasks> result = new List<InteractionDb.ModelTables.PendingTasks>() ;
            foreach ( var d in div)
            {
                result.AddRange(d);
            }
            return result;
        }
    }
}
