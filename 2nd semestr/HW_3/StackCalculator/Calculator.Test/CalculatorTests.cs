using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackCalculator;
namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void ExecuteOperationTest()
        {
            ArrayStack arrayStack = new ArrayStack(25);
            StackCalculator.Calculator calculator = new StackCalculator.Calculator(arrayStack);
            string str = "8 8+4/";
            Assert.AreEqual(calculator.ExecuteOperation(str), 4);
            PointerStack pointerStack = new PointerStack();
            StackCalculator.Calculator calculator1 = new StackCalculator.Calculator(pointerStack);
            str = "9 3-3*";
            Assert.AreEqual(calculator.ExecuteOperation(str), 18);
        }
    }
}
