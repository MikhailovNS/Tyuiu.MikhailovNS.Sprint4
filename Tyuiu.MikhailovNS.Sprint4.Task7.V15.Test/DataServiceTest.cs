using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint4.Task7.V15.Lib;

namespace Tyuiu.MikhailovNS.Sprint4.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test()
        {
            DataService ds = new DataService();

            int n = 2;
            int m = 4;

            string value = "10293847";

            int wait = 4;

            int res = ds.Calculate(n, m, value);

            Assert.AreEqual(wait, res);
        }
    }
}
