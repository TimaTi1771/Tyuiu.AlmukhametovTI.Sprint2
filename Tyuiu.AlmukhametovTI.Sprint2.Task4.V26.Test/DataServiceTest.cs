using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlmukhametovTI.Sprint2.Task4.V26.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint2.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression1()
        {
            DataService ds = new DataService();

            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 99.8;
            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void ValidExpression2()
        {
            DataService ds = new DataService();

            double x = 4;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 15.667;
            Assert.AreEqual(res, wait);
        }
    }
}
