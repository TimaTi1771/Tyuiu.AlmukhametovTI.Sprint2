using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AlmukhametovTI.Sprint2.Task0.V17.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint2.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1065;
            int y = 755;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, false, false, false, false };

            CollectionAssert.AreEqual(res, wait);
        }
    }
}
