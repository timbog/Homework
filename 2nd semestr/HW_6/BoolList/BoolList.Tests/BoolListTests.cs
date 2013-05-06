using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoolList.Tests
{
    [TestClass]
    public class BoolListTests
    {
        [TestMethod]
        public void FilterTest()
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            List<int> list1 = Change.Filter(list, x => x == 2);
            Assert.AreEqual(list1[0], 2);
            Assert.AreEqual(list1.Count, 1);
        }
    }
}
