using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Mas.Number(new int[1] { 1 }), 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Mas.Number(new int[] { }), 0);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(Mas.Number(new int[1] { 2 }), -1);
        }
    }
}
