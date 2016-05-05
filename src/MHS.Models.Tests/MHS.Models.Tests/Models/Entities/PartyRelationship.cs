using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHS.Models.Tests.Models.Entities
{
    using MHS.Models.Tests.Models.Values;

    public class PartyRelationship : EntityModel
    {
        public virtual DateTime? From { get; set; }
        public virtual DateTime Thru { get; set; }
        public virtual string Comment { get; set; }
        public virtual PartyRelationshipType PartyRelationshipType { get; set; }

        public virtual PartyRole RelationshipFrom { get; set; }
        public virtual PartyRole RelationshipTo { get; set; }
    }
}
