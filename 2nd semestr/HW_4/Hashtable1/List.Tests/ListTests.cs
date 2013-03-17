using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashTable;
namespace List.Tests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void AddTest()
        {
            HashTable.List list = new HashTable.List();
            list.Add("johnie", 1);
            list.Add("loca", 1);
            Assert.IsFalse(list.Exist("johnie") == -1);
            Assert.IsFalse(list.Exist("loca") == -1);
        }

        [TestMethod]
        public void DeleteTest()
        {
            HashTable.List list = new HashTable.List();
            list.Add("uiu", 1);
            list.Delete("uiu");
            Assert.IsTrue(list.Exist("uiu") == -1);
        }

        [TestMethod]
        public void ExistTest()
        {
            HashTable.List list = new HashTable.List();
            list.Add("john", 1);
            Assert.IsFalse(list.Exist("johnie") == -1);
        }

        [TestMethod]
        public void PositionTest()
        {
            HashTable.List list = new HashTable.List();
            list.Add("john", 1);
            Assert.AreEqual(list.Position(list.Exist("john")), list.head);
        }
    }
}
