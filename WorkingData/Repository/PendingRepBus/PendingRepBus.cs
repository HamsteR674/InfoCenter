﻿using InteractionDb.ModelTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingData.EntityModel.Tasks;


namespace WorkingData.Repository.PendingRepBus
{
    public class PendingRepBus(InteractionDb.Repository.PendingTasks.IPendingTasks pending) : IPendingRepBus
    {
        public List<PendingTasks> GetbyCustomStandTasks(int id)
        {
            var tasks = pending.GetbyIdCustomStand(id);
            return tasks;
        }

        public List<PendingTasks> GetbyIdDivisionPendingTasks(long id)
        {
            var div = pending.GetbyIdDivision(id);
            return div;
        }

        public void Update(NewTasks newTasks)
        {
            PendingTasks pendingTasks = new PendingTasks();
            pendingTasks.Id = newTasks.id;
            pendingTasks.ServiceCallId = newTasks.ServiceCallId;
            pendingTasks.ServiceCallTitle = newTasks.Title;
            pendingTasks.Description = newTasks.Description;
            

            pending.Update(pendingTasks);
        }
    }
}
