using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BubbleGenericSort.Tests
{
    [TestClass]
    public class BubbleGenericSortTests
    {
        [TestMethod]
        public void BubbleIntSortTest()
        {
            BubbleSort<int> sort = new BubbleSort<int>();
            int[] a = new int[5];
            for (int i = 0; i < 5; ++i)
                a[i] = 5 - i;
            Comparator comparator = new Comparator();
            sort.Sort(a, 5, comparator);
            for (int i = 0; i < 5; ++i)
                Assert.AreEqual(a[i], i + 1);
        }

        [TestMethod]
        public void BubbleStringSortTest()
        {
            BubbleSort<string> sort = new BubbleSort<string>();
            string[] a = new string[3];
            a[0] = "bestbestbest";
            a[1] = "notbest12";
            a[2] = "worst";
            Comparator comparator = new Comparator();
            sort.Sort(a, 3, comparator);
            Assert.AreEqual(a[0], "worst");
            Assert.AreEqual(a[1], "notbest12");
            Assert.AreEqual(a[2], "bestbestbest");
        }
    }
}
