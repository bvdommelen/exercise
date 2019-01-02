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

        [TestMethod]
        public void SolveProblem4()
        {
            string result = new Problem4().Solve();
            Assert.AreEqual("906609", result);
        }

        [TestMethod]
        public void PalindromeTest()
        {
            var t = new Problem4();
            Assert.IsTrue(t.IsPalindrome("909909"));
            Assert.IsTrue(t.IsPalindrome("123321"));
            Assert.IsFalse(t.IsPalindrome("123456"));
        }
    }
}