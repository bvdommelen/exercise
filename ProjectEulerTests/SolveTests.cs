using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class SolveTests
    {
        [TestMethod]
        public void SolveProblem1()
        {
            string result = new Problem1().Solve();
            Assert.AreEqual("233168", result);
        }

        [TestMethod]
        public void SolveProblem2()
        {
            string result = new Problem2().Solve();
            Assert.AreEqual("4613732", result);
        }

        [TestMethod]
        public void SolveProblem3()
        {
            string result = new Problem3().Solve();
            Assert.AreEqual("6857", result);
        }
    }
}