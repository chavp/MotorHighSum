﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHS.Models.Tests.Models.Entities
{
    public class Person : Party
    {
        public virtual string CardNo { get; set; }
    }
}
