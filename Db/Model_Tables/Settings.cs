using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Db.Model_Tables
{
    public record Settings
    {
        public int id { get; set; }
        public int EmployeesId { get; set; }

        public Employees Employees { get; set; }

        [Column(TypeName = "json")]
        public string JsonSettings { get; set; }
    }
    public record SettingsMap
    {
        public SettingsMap(EntityTypeBuilder<Settings> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(e => e.id);
            entityTypeBuilder.Property(e => e.JsonSettings);
        }
    }
}