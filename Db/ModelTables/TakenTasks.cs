using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InteractionDb.ModelTables
{
    public record TakenTasks
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public DateTimeOffset ExpirationData { get; set; }
        public string Description { get; set; }

        public string Service {  get; set; }
        public string ServiceComponent { get; set; }
        public bool IsProjectTask { get; set; }
        public int ServiceCallId { get; set; }

        public int EployeeId { get; set; }
        public Employees Employees { get; set; }

    }
}
