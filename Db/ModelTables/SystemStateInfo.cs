using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    [Index("CheckDateTime")]
    public record SystemStateInfo(long Id, DateTimeOffset CheckDateTime, bool Result, string ErrorLis, long SystemInfoId)
    {  
        public SystemInfo SystemInfo { get; set; }
    }
}
