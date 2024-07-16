using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    public class SystemInfo()
    {
        public long Id {  get; set; }
        public string Name { get; set; }

        public List<SystemStateInfo>? StateInfos { get; set; }
    }
}
