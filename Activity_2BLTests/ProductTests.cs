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
    public class ProductTests
    {
        [TestMethod()]
        public void ProductTest()
        {
           // Assert.Fail();
        }

        [TestMethod()]
        public void ProductTest1()
        {
            Product o1 = new Product();
            Product o2 = new Product();
            Assert.AreNotEqual(o2, o1);
        }
    }
}