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
            Assert.AreEqual(tree.ShowValue(tree.Head), 8);
            Assert.AreEqual(tree.ShowValue(tree.Head.Left), 7);
            Assert.AreEqual(tree.ShowValue(tree.Head.Right), 9);
        }

        [TestMethod]
        public void IteratorTest()
        {
            Tree tree = new Tree();
            tree.AddValue(8);
            tree.AddValue(7);
            tree.AddValue(9);
            foreach (Tree.Node node in tree)
                Assert.IsTrue(node != null);
        }
    }
}
