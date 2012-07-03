using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IDikit.Core.Services;

namespace IDikit.Tests.Services
{
    [TestClass]
    public class WebRequestTest
    {
        [TestMethod]
        public void CanGetPageTitle()
        {
            var webRequest = new WebRequest();
            Assert.AreEqual("asdf", webRequest.GetTitle("http://creattica.com/"));
        }
    }
}
