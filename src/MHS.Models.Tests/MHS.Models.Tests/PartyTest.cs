using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MHS.Models.Tests
{
    using MHS.Models.Tests.Models.Values;
    
    [TestClass]
    public class PartyTest
    {
        [TestMethod]
        public void test_create_party()
        {
            // Party Role Type Company
            var cmpRoleType = new PartyRoleType()
            {
                Code = "100",
                Description = "Company"
            };

            var insuranceCmpRoleType = new PartyRoleType()
            {
                Code = "101",
                Description = "Insurance Company"
            };

            var brokerCmpRoleType = new PartyRoleType()
            {
                Code = "102",
                Description = "Broker Company"
            };

            var bankCmpRoleType = new PartyRoleType()
            {
                Code = "103",
                Description = "Bank Company"
            };

            // Party Role Type Person
            var guestRoleType = new PartyRoleType()
            {
                Code = "100",
                Description = "Guest"
            };

            var memberRoleType = new PartyRoleType()
            {
                Code = "101",
                Description = "Member"
            };

            var brokerRoleType = new PartyRoleType()
            {
                Code = "102",
                Description = "Broker"
            };

            var insurerRoleType = new PartyRoleType()
            {
                Code = "103",
                Description = "Insurer"
            };

            var insuredRoleType = new PartyRoleType()
            {
                Code = "104",
                Description = "Insured"
            };


        }
    }
}
