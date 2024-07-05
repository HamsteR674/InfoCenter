using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    public record CustomStandInfo(int Id, string Name)
    {
        
      
        public Employees CreatorId { get; set; }
       
         public List<CustomStandEmployees> CustomStandEmployees { get; set;}
        public List<CustomStandRights> CustomStandRights { get; set; }
        
    }
   
}
