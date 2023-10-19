using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BogdanovaSA.Sprint2.Task2.V14.Library;


namespace Tyuiu.BogdanovaSA.Sprint2.Task2.V14.Tes
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadeArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;

            bool res = ds.CheckDotInShadeArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
