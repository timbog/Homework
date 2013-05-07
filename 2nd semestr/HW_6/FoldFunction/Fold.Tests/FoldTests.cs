using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace Fold.Tests
{
    [TestClass]
    public class FoldTests
    {
        [TestMethod]
        public void FoldTest()
        {
            Assert.AreEqual(FoldFunction.Change.Fold(new List<int>() { 1, 2, 3 }, 1, (acc, elem) => acc * elem), 6);
        }
    }
}
