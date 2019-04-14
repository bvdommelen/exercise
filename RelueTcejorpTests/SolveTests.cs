using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

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
        public void SolveProblem5()
        {
            string result = new Problem5().Solve();
            Assert.AreEqual("232792560", result);
        }

        [TestMethod]
        public void SolveProblem6()
        {
            string result = new Problem6().Solve();
            Assert.AreEqual("25164150", result);
        }

        [TestMethod]
        public void SolveProblem7()
        {
            string result = new Problem7().Solve();
            Assert.AreEqual("104743", result);
        }

        [TestMethod]
        public void SolveProblem8()
        {
            string result = new Problem8().Solve();
            Assert.AreEqual("23514624000", result);
        }

        [TestMethod]
        public void SolveProblem9()
        {
            string result = new Problem9().Solve();
            Assert.AreEqual("31875000", result);
        }

        [TestMethod]
        public void SolveProblem10()
        {
            string result = new Problem10().Solve();
            Assert.AreEqual("142913828922", result);
        }

        [TestMethod]
        public void SolveProblem11()
        {
            string result = new Problem11().Solve();
            Assert.AreEqual("70600674", result);
        }

        [TestMethod]
        public void SolveProblem12()
        {
            string result = new Problem12().Solve();
            Assert.AreEqual("76576500", result);
        }

        [TestMethod]
        public void SolveProblem13()
        {
            string result = new Problem13().Solve();
            Assert.AreEqual("5537376230", result);
        }

        [TestMethod]
        public void SolveProblem14()
        {
            string result = new Problem14().Solve();
            Assert.AreEqual("837799", result);
        }

        [TestMethod]
        public void SolveProblem15()
        {
            string result = new Problem15().Solve();
            Assert.AreEqual("137846528820", result);
        }

        [TestMethod]
        public void SolveProblem16()
        {
            string result = new Problem16().Solve();
            Assert.AreEqual("1366", result);
        }

        [TestMethod]
        public void SolveProblem17()
        {
            string result = new Problem17().Solve();
            Assert.AreEqual("21124", result);
        }

        [TestMethod]
        public void SolveProblem18()
        {
            string result = new Problem18().Solve();
            Assert.AreEqual("1074", result);
        }

        [TestMethod]
        public void ChainLengthTest()
        {
            string result = new Problem14().getChainLength(13).ToString();
            Assert.AreEqual("10", result);
        }

        [TestMethod]
        public void PalindromeTest()
        {
            var t = new Problem4();
            Assert.IsTrue(t.IsPalindrome("909909"));
            Assert.IsTrue(t.IsPalindrome("123321"));
            Assert.IsFalse(t.IsPalindrome("123456"));
        }

        [TestMethod]
        public void PrimeFactorsTest()
        {
            var t = new Problem5();
            Assert.IsTrue(t.GetPrimeFactors(2).SequenceEqual(new List<int>() { 2 }), "2 not correctly factored");
            Assert.IsTrue(t.GetPrimeFactors(3).SequenceEqual(new List<int>() { 3 }), "3 not correctly factored");
            Assert.IsTrue(t.GetPrimeFactors(37).SequenceEqual(new List<int>() { 37 }), "37 not correctly factored");
            Assert.IsTrue(t.GetPrimeFactors(40).SequenceEqual(new List<int>() { 2, 2, 2, 5 }), "40 not correctly factored");
            Assert.IsTrue(t.GetPrimeFactors(60).SequenceEqual(new List<int>() { 2, 2, 3, 5 }), "60 not correctly factored");
            Assert.IsTrue(t.GetPrimeFactors(1001).SequenceEqual(new List<int>() { 7, 11, 13 }), "1001 not correctly factored");
        }

        [TestMethod]
        public void MergeFactorsTest()
        {
            var t = new Problem5();
            Assert.IsTrue(t.MergeFactors(new[] {2, 3, 5}, new[] {2, 2, 7}).SequenceEqual(new[] {2, 3, 5, 2, 7}));
        }

        [TestMethod]
        public void Number342AsTextText()
        {
            Assert.AreEqual(23, Problem17.countLetters((342).ToText()));
        }
    }
}