using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Model_Tables
{
    public record CustomStandRights
    {
        public int Id { get; set; }
        public int InfoCenterId { get; set; }
        public CustomStandInfo CustomStandInfo { get; set; }
        public int EmployeesId { get; set; }
        public string Rights { get; set; }

    }
}
