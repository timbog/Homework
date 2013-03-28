using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackCalculator;
namespace PointerStack.Tests
{
    [TestClass]
    public class PointerStackTest
    {
        [TestMethod]
        public void PushTest()
        {
            StackCalculator.PointerStack stack = new StackCalculator.PointerStack();
            stack.Push(4);
            Assert.AreEqual(stack.Pop(), 4);
        }

        [TestMethod]
        public void PopTest()
        {
            StackCalculator.PointerStack stack = new StackCalculator.PointerStack();
            stack.Push(6);
            Assert.AreEqual(stack.Pop(), 6);
        }

        [TestMethod]
        public void CountTest()
        {
            StackCalculator.PointerStack stack = new StackCalculator.PointerStack();
            string str = "8_9+3-";
            Assert.AreEqual(stack.Count(str), 14);
        }
    }
}
