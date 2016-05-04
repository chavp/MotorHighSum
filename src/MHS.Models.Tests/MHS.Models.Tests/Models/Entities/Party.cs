using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHS.Models.Tests.Models.Entities
{
    public abstract class Party
        : EntityModel
    {
        public IList<PartyRole> Roles { get; set; }
    }
}
