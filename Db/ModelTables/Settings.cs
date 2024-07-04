using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    public record Settings
    {
        public int id { get; set; }
        public int EmployeesId { get; set; }

        public Employees Employees { get; set; }

        [Column(TypeName = "json")]
        public string JsonSettings { get; set; }
    }
  
}