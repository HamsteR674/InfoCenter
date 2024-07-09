﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    public class CustomStandInfo()
    {

        public int Id {  get; set; }
        public string Name { get; set; }
        public Employees CreatorId { get; set; }
       
        public List<CustomStandEmployees> CustomStandEmployees { get; set;}
        public List<CustomStandRights> CustomStandRights { get; set; }
        
    }
   
}
