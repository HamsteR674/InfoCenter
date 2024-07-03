using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Model_Tables
{
    public record CustomStandInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employees Employees { get; set; }
        public int CreatorId { get; set; }
         public List<CustomStandEmployees> CustomStandEmployees { get; set;}
        public List<CustomStandRights> CustomStandRights { get; set; }
    }
    public record CustomStandInfoMap
    {
        public CustomStandInfoMap(EntityTypeBuilder<CustomStandInfo> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(e => e.Id);
            entityTypeBuilder.
                HasMany(e => e.CustomStandRights)
                .WithOne(e => e.CustomStandInfo)
                .HasForeignKey(e => e.InfoCenterId);
           
        }
    }
}
