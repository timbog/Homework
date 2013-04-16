using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackCalculator;
namespace ArrayStack.Tests
{
    [TestClass]
    public class ArrayStackTest
    {
        [TestMethod]
        public void PushTest()
        {
            StackCalculator.ArrayStack stack = new StackCalculator.ArrayStack(5);
            stack.Push(4);
            Assert.AreEqual(stack.Pop(), 4);
        }
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void PopTest()
        {
            StackCalculator.ArrayStack stack = new StackCalculator.ArrayStack(5);
            stack.Pop();
            stack.Push(6);
            Assert.AreEqual(stack.Pop(), 6);
        }
    }
}
