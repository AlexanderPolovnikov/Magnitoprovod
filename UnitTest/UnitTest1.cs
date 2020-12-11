using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Magnit;

namespace ModuleTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSquare()
        {
            Trans Test = new Trans(250, 5, 225);
            Test.search1(0);
            Assert.AreEqual(176625.88, Math.Round(Test.maxS * 2, 2));
        }
        [TestMethod]
        public void TestCoef()
        {
            Trans Test = new Trans(150, 3, 125);
            Test.search1(0);
            Assert.AreEqual(0.82, Math.Round((2 * Test.maxS) / (Math.PI * Test.R * Test.R), 2));
        }
        [TestMethod]
        public void TestWidth()
        {
            bool W = true;
            Trans Test = new Trans(100, 2, 80);
            Test.search1(0);
            double[] Ex = { 180, 120 };
            for (int i = 0; i < 2; i++)
            {
                if (Ex[i] != Math.Round(Test.MAXpach[i], 2))
                {
                    W = false;
                }
            }
            Assert.IsTrue(W);
        }
        [TestMethod]
        public void TestThickness()
        {
            bool W = true;
            Trans Test = new Trans(300, 7, 270);
            Test.search1(0);
            double[] Ex = { 76.81, 53.96, 35.06, 26.78, 30.99, 23.58, 18.15 };
            for (int i = 0; i < 7; i++)
            {
                if (Ex[i] != Math.Round(Test.MAXpacl[i], 2))
                {
                    W = false;
                }
            }
            Assert.IsTrue(W);
        }
    }
}