using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwappingIntegers;

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

        [TestMethod]
        public void TestScenario_2()
        {
            int x = 7;
            int y = -3;
            try
            {
                Program.Swap(ref x, ref y);
            }
            catch(Exception e)
            {
                throw e;
            }        
        }
    }
}
