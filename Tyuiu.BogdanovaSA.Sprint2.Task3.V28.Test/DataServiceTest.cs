using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BogdanovaSA.Sprint2.Task3.V28.Lib;

namespace Tyuiu.BogdanovaSA.Sprint2.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            double x = 5, res = dataService.Calculate(x), wait = 8132.250;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService dataService = new DataService();
            double x = -1, res = dataService.Calculate(x), wait = -4.754;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService dataService = new DataService();
            double x = -32, res = dataService.Calculate(x), wait = -255.969;
            Assert.AreEqual(wait, res);
        }
    }
    }
}
