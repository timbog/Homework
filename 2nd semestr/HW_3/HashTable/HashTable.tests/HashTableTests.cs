using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashTable;
namespace HashTable.tests
{
    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void AddTest()
        {
            List list = new List();
            list.Add("johnie",1);
            list.Add("loca",1);
            Assert.IsFalse(list.Exist("johnie") == -1);
            Assert.IsFalse(list.Exist("loca") == -1);
        }

        [TestMethod]
        public void DeleteTest()
        {
            List list = new List();
            list.Add("uiu",1);
            list.Delete("uiu");
            Assert.IsTrue(list.Exist("uiu") == -1);
        }

        [TestMethod]
        public void PrintTest()
        {
            List list = new List();
            list.Print();
        }

        [TestMethod]
        public void ExistTest()
        {
            List list = new List();
            list.Add("john", 1);
            Assert.IsFalse(list.Exist("johnie") == -1);
        }

        [TestMethod]
        public void HashTest()
        {
            HashTable ht = new HashTable(35);           
            Assert.IsTrue(ht.Hash("yo",35) == 22) ;
        }

        [TestMethod]
        public void AddToTableTest()
        {
            HashTable ht = new HashTable(35);
            ht.AddToTable("yea");
            Assert.IsTrue(ht.Search("yea"));
        }

        [TestMethod]
        public void DeleteFromTableTest()
        {
            HashTable ht = new HashTable(35);
            ht.AddToTable("yea");
            ht.DeleteFromTable("yea");
            Assert.IsFalse(ht.Search("yea"));
        }

        [TestMethod]
        public void SearchTest()
        {
            HashTable ht = new HashTable(35);
            ht.AddToTable("no");
            Assert.IsTrue(ht.Search("no"));
        } 
    }
}
