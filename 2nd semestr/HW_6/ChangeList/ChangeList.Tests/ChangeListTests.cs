using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace ChangeList.Tests
{
    [TestClass]
    public class ChangeListTests
    {
        [TestMethod]
        public void MapTest()
        {
            List<int> list = Change.Map(new List<int>() { 1, 2, 3 }, x => x * 2);
            Assert.IsTrue(list.Contains(2));
            Assert.IsTrue(list.Contains(4));
            Assert.IsTrue(list.Contains(6));
        }
    }
}
