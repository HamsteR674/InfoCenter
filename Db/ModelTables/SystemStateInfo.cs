using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    [Index("CheckDateTime")]
    public record SystemStateInfo
    {
        
        public long Id { get; set; }
        public DateTimeOffset CheckDateTime { get; set; }
        public bool Result { get; set; }
        public string ErrorList { get; set; }
        public long SystemInfoId { get; set; }
        
        public SystemInfo SystemInfo { get; set; }
    }
}
