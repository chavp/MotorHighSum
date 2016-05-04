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
        /// 100 = Company, 101 = InsuranceCompany, 102 = BrokerCompany, 103 = BankCompany
        /// 200 = Guest, 201 = Member, 202 = Broker, 203 = Insurer, 204 = Insured
        /// </summary>
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
