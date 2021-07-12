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
    public class PurchaseTests
    {
        [TestMethod()]
        public void PurchaseTest()
        {
            Purchase o1 = new Purchase();
            Purchase o2 = new Purchase();
            Assert.AreNotEqual(o2, o1);
        }

        [TestMethod()]
        public void PurchaseTest1()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void CalculateBillAmountTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void CalculateBillAmountTest1()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void GetPurchasePercentageTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void RoundOffBillTestPositive()
        {
            var p = new Purchase();
            double actual = Purchase.RoundOffBill(68.489);
            double expected = 68.49;
            Assert.AreEqual(expected, actual);
        }

        public void RoundOffBillTestNegative()
        {
            var p = new Purchase();
            double actual = Purchase.RoundOffBill(68.413);
            double expected = 68.41;
            Assert.AreEqual(expected, actual);
        }
    }
}