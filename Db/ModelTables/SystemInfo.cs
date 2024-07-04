using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    public record SystemInfo
    {
        public long Id {  get; set; }
        public string name { get; set; }
        public List<SystemStateInfo>? StateInfos { get; set; }
    }
}
