using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    public record CustomStandEmployees(int Id, int InfoCentreId, int EmployeesId)
    {
        public int Id { get; set; }
        public int InfoCentreId { get; set; }
        public CustomStandInfo  CustomStandInfo { get; set; }

        public Employees Employees { get; set; }
        public int EmployeesId { get; set; }
    }

}
