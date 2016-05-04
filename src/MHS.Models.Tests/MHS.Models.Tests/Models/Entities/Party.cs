using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHS.Models.Tests.Models.EntityModel
{
    public abstract class Party
        : EntityModel
    {
        public IList<PartyRole> MyProperty { get; set; }
    }
}
