using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Tests
{
    [TestClass()]
    public class PrimeHelperTests
    {
        [TestMethod()]
        public void AllPrimesTest()
        {
            string result = string.Join(",", PrimeHelper.AllPrimes(20));
            Assert.AreEqual("2,3,5,7,11,13,17,19", result);
        }

        [TestMethod()]
        public void IsDivisbleByAnyTest()
        {
            var divisors = new List<long>() { 3, 4, 6 };
            Assert.IsTrue(PrimeHelper.IsDivisbleByAny(20, divisors));
        }
    }
}