
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InteractionDb.ModelTables
{
    public record Employees()
    {

        int Id {  get; set; }
        string Name { get; set; }
        string Email { get; set; }
        bool IsFired { get; set; }
        string Code { get; set; }
        public long DivisionId { get; set; }
        public Divisions Divisions { get; set; }

        public List<Divisions>? ChefDivisions { get; set; }

        public List<SessionLog> Logs { get; set; }
        
        public List<Settings> Settings { get; set; }

        public List<TakenTasks>? TakenTasks { get; set; }
        public List<PandingTasks>? PandingTasks { get; set; }
        public List<CustomStandEmployees> CustomStandEmployees { get; set; }
       
        }
   
}
