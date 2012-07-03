using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IDikit.Core.Model;

namespace IDikit.Tests.Model
{
    [TestClass]
    public class MemberTest
    {
        [TestMethod]
        public void CanGetMemberList()
        {
            var member = new Member();
            Assert.AreEqual("asdf", member.GetList().Count.ToString());
        }

        [TestMethod]
        public void CanSaveMember()
        {
            var member = new Member();
            member.Save(new Member
            {
                Name = "Sonny Corleone",
                ContactNo = "222",
                Username = "sonny",
                Password = "sonny",
                Status = "Active"
            });

            Assert.Inconclusive("Saved");
        }
    }
}
