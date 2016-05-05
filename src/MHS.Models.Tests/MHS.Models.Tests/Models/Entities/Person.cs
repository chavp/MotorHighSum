using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHS.Models.Tests.Models.Entities
{
    using MHS.Models.Tests.Models.Values;

    public class Person : Party
    {
        public IList<PersonName> NameList { get; set; }
        public virtual DateTime? BirthDate { get; set; }
        public virtual string CardId { get; set; }
    }
}
