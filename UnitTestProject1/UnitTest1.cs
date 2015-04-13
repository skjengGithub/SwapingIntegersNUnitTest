using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestScenario_1()
        {
            int x = 3;
            int y = 5;
            Program.Swap(ref x, ref y);
            Assert.IsTrue(x == 5 && y == 3);
        }
    }
}
