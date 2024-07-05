using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    public record SystemInfo(long Id, string Name)
    {
   

        public List<SystemStateInfo>? StateInfos { get; set; }
    }
}
