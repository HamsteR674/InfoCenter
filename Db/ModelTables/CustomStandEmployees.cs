﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionDb.ModelTables
{
    public class CustomStandEmployees( )
    {

        public int Id {  get; set; }
        public CustomStandInfo InfoCentre { get; set; }

        public Employees Employees { get; set; }
     
    }

}
