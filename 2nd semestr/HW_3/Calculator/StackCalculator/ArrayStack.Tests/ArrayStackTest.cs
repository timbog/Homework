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
        public void PopTest()
        {
            StackCalculator.ArrayStack stack = new StackCalculator.ArrayStack(5);
            stack.Push(6);
            Assert.AreEqual(stack.Pop(), 6);
        }
        [TestMethod]
        public void CountTest()
        {
            StackCalculator.ArrayStack stack = new StackCalculator.ArrayStack(5);
            string str = "8_9+3-";
            Assert.AreEqual(stack.Count(str), 14);
        }
    }
}
