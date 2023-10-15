using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlmukhametovTI.Sprint2.Task6.V10.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint2.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void TestMethod1()
            {
                DataService ds = new DataService();

                int x = 2023;
                int y = 6;
                int z = 15;
                string res = ds.FindDateOfPreviousDay(x, y, z);
                string wait = "2023/5/14";
                Assert.AreEqual(wait, res);
            }
        }




    }
}
