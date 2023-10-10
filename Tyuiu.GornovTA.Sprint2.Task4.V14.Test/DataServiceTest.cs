using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GornovTA.Sprint2.Task4.V14.Lib;

namespace Tyuiu.GornovTA.Sprint2.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 17.319;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 0.227;
            Assert.AreEqual(wait, res);
        }
    }
}
