using Microsoft.VisualStudio.TestTools.UnitTesting;
using Activity_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2.Tests
{
    [TestClass()]
    public class SellerTests
    {
        [TestMethod()]
        public void SellerTest()
        {
            Seller o1 = new Seller();
            Seller o2 = new Seller();
            Assert.AreNotEqual(o2, o1);
            //Assert.Fail();
        }

        [TestMethod()]
        public void SellerTest1()
        {
            //Assert.Fail();
        }
    }
}