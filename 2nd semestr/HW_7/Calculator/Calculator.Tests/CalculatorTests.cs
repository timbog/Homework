﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AddSymbolTest()
        {
            Form1 form = new Form1();
            form.AddSymbol(5);
        }
    }
}
