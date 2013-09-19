using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TreeIterator;
namespace TreeIterator.Tests
{
    [TestClass]
    public class TreeIteratorTests
    {
        [TestMethod]
        public void AddValueTest()
        {
            Tree tree = new Tree();
            tree.AddValue(8);
            tree.AddValue(7);
            tree.AddValue(9);
            Assert.AreEqual(tree.head.Value, 8);
            Assert.AreEqual(tree.head.Left.Value, 7);
            Assert.AreEqual(tree.head.Right.Value, 9);
        }
    }
}
