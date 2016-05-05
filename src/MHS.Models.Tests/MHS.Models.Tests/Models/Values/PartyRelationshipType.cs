using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHS.Models.Tests.Models.Values
{
    public class PartyRelationshipType
        : ValueType
    {
        public virtual string Name { get; set; }

        public virtual PartyRoleType RelationshipFrom { get; set; }
        public virtual PartyRoleType RelationshipTo { get; set; }
    }
}
