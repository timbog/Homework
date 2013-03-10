using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace Stack.Test
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void AddTest()
        {
            var stack = new ConsoleApplication1.Stack();
            stack.Add(5);
            Assert.AreEqual(5, stack.Pop());
        }

        [TestMethod]
        public void PopTest()
        {
            var stack = new ConsoleApplication1.Stack();
            stack.Add(6);
            stack.Add(5);
            stack.Add(7);
            Assert.AreEqual(7, stack.Pop());
            Assert.AreEqual(5, stack.Pop());
            Assert.AreEqual(6, stack.Pop());
        }

        [TestMethod]
        public void PrintTest()
        {
            var stack = new ConsoleApplication1.Stack();
            stack.Add(6);
            stack.Add(5);
            stack.Add(7);
            stack.Print();
        }
    }
}
