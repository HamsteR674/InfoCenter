using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingData.EntityModel.PendingTasks
{
    //public record PendingTasks(int id, int ServiceCallId, string ServiceCallTitle, string Description, DateTimeOffset ExpirationData);
    public record Tasks(List<InteractionDb.ModelTables.PendingTasks> ListPTasks, List<InteractionDb.ModelTables.TakenTasks> LisstTTasks);
}

