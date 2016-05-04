using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHS.Models.Tests.Models.Entities
{
    using MHS.Models.Tests.Models.Values;

    public class PartyRole 
        : EntityModel
    {
        public virtual PartyRoleType PartyRoleType { get; set; }
        public virtual DateTime? From { get; set; }
        public virtual DateTime Thru { get; set; }
        public virtual string Description { get; set; }
    }
}
