using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    public class CustomStandRights()
    {
        public int Id {  get; set; }
        public int EmployeesI { get; set; }
        public string Rights { get; set; }


        public CustomStandInfo InfoCenterId { get; set; }
 

    }
}
