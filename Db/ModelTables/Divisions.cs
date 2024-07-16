using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InteractionDb.ModelTables
{
    public class Divisions()
    {

        public long Id { get; set; }
        public string Name {  get; set; }
        public int? ParentDivCode { get; set; }
        public Divisions? Parent { get; set; }
        public List<Divisions> Children { get; set; }

        public int ChiefId { get; set; }
        public Employees Chef { get; set; }



        public List<Employees> Employees { get; set; }

        

    }
   
    

}
