using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class SolveTests
    {
        [TestMethod]
        public void SolveProblem1()
        {
            string result = new Problem1().Solve();
            Assert.AreEqual("3", result);
        }
    }
}