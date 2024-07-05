using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    public record CustomStandRights(int Id, int EmployeesI, string Rights)
    {
    
      
        public CustomStandInfo InfoCenterId { get; set; }
 

    }
}
