using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHS.Models.Tests.Models.Values
{
    public class PartyRoleType
    {
        /// <summary>
        /// Guest, Member, Broker, Insurer, Insured
        /// </summary>
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
