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
        [ExpectedException(typeof(System.Exception))]
        public void PopTest()
        {
            StackCalculator.PointerStack stack = new StackCalculator.PointerStack();
            stack.Pop();
            stack.Push(6);
            Assert.AreEqual(stack.Pop(), 6);
        }
    }
}
