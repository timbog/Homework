using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniqueList.Tests
{
    [TestClass]
    public class UniqueListTests
    {
        [TestMethod]
        [ExpectedException(typeof (System.Exception))]
        public void AddTest()
        {
            UniqueList list = new UniqueList();
            list.Add(6);
            list.Add(6);
            Assert.AreEqual(list.HeadValue(), 6);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void DeleteTest()
        {
            UniqueList list = new UniqueList();
            list.Delete(6);
            list.Add(7);
            list.Delete(7);
            Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void PrintTest()
        {
            UniqueList list = new UniqueList();
            list.Print();
        }
    }
}
