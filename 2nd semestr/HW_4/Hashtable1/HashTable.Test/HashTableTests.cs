using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HashTable.Test
{
    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void HashFunction1Test()
        {
            HashFunction1 hash = new HashFunction1();
            HashTable ht = new HashTable(35, hash);
            Assert.IsTrue(ht.hash.HashF("yo", 35) == 22);
        }

        [TestMethod]
        public void HashFunction2Test()
        {
            HashFunction2 hash = new HashFunction2();
            HashTable ht = new HashTable(35, hash);
            Assert.IsTrue(ht.hash.HashF("ol", 35) == 17);
        }

        [TestMethod]
        public void AddToTableTest()
        {
            HashFunction1 hash = new HashFunction1();
            HashTable ht = new HashTable(35, hash);
            ht.AddToTable("yea");
            Assert.IsTrue(ht.Search("yea"));
        }

        [TestMethod]
        public void DeleteFromTableTest()
        {
            HashFunction1 hash = new HashFunction1();
            HashTable ht = new HashTable(35, hash);
            ht.AddToTable("yea");
            ht.DeleteFromTable("yea");
            Assert.IsFalse(ht.Search("yea"));
        }

        [TestMethod]
        public void SearchTest()
        {
            HashFunction1 hash = new HashFunction1();
            HashTable ht = new HashTable(35, hash);
            ht.AddToTable("no");
            Assert.IsTrue(ht.Search("no"));
        } 
    }
}
