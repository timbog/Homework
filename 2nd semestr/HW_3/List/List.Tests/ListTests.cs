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
            PointerList list = new PointerList();
            list.Add(8);
            list.Add(7);
            Assert.IsFalse(list.IsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void DeleteTest()
        {
            PointerList list = new PointerList();
            list.Delete(2);
            list.Add(8);
            list.Delete(8);
            Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        public void PrintTest()
        {
            PointerList list = new PointerList();
            list.Print();
        }
    }
}
