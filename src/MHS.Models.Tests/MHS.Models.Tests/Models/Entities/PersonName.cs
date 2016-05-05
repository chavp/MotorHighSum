using MHS.Models.Tests.Models.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHS.Models.Tests.Models.Entities
{
    public class PersonName
        : EntityModel
    {
        public virtual long SeqId { get; set; }
        public virtual DateTime? From { get; set; }
        public virtual DateTime Thru { get; set; }
        public virtual PersonNameType PersonNameType { get; set; }
        public virtual string Name { get; set; }
    }
}
