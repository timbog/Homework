using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NullElementCounter.Tests
{
    [TestClass]
    public class NullElementCounterTests
    {
        [TestMethod]
        public void CountTest()
        {
            int[] array = new int[5];
            array[0] = 5;
            array[1] = 0;
            array[2] = 6;
            array[3] = 0;
            array[4] = 7;
            NullCounter counter = new NullCounter();
            Assert.AreEqual(counter.Count(array), 2);
        }
    }
}
