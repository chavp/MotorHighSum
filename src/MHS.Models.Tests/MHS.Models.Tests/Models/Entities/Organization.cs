using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHS.Models.Tests.Models.Entities
{

    public class Organization : Party
    {
        public virtual string CompanyNo { get; set; }
    }
}
