using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriorityQueu;
namespace ProrityQueu.Tests
{
    [TestClass]
    public class QueuTests
    {
        [TestMethod]
        public void EnqueuTest()
        {
            Queu queu = new Queu();
            queu.EnQueu(3, 4);
            Assert.AreEqual(queu.head.Value, 3);
            Assert.AreEqual(queu.head.Priority, 4);
            queu.EnQueu(4, 5);
            Assert.AreEqual(queu.head.Value, 4);
            Assert.AreEqual(queu.head.Priority, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void DequeuTest()
        {
            Queu queu = new Queu();
            int a = queu.Dequeu();
            queu.EnQueu(4, 2);
            queu.EnQueu(5, 3);
            Assert.AreEqual(queu.Dequeu(), 3);
        }
    }
}
