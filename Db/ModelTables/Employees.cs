
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InteractionDb.ModelTables
{
    public record Employees()
    {

        public int Id {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsFired { get; set; }
        public string Code { get; set; }
        public long? DivisionId { get; set; }
        public Divisions? Divisions { get; set; }

        public List<Divisions>? ChefDivisions { get; set; }

        public List<SessionLog> Logs { get; set; }
        
        public List<Settings> Settings { get; set; }

        public List<TakenTasks>? TakenTasks { get; set; }
        public List<PendingTasks>? PandingTasks { get; set; }
        public List<CustomStandEmployees> CustomStandEmployees { get; set; }
       
        }
   
}
