using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using List;
namespace List.Tests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void AddTest()
        {
            List list = new List();
            list.Add(8);
            list.Add(7);
            Assert.IsFalse(list.IsEmpty());
        }

        [TestMethod]
        public void DeleteTest()
        {
            List list = new List();
            list.Add(8);
            list.Delete(8);
            Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        public void PrintTest()
        {
            List list = new List();
            list.Print();
        }
    }
}
