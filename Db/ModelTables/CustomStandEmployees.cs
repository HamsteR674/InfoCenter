using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    public record CustomStandEmployees(int Id )
    {
  
  
        public CustomStandInfo InfoCentre { get; set; }

        public Employees Employees { get; set; }
     
    }

}
