using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint4.Task1.V17.Lib;

namespace Tyuiu.MikhailovNS.Sprint4.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test()
        {
            DataService ds = new DataService();

            int[] array = new int[] { 1, 7, 6, 3, 2, 5, 7, 6, 7, 6, 5, 4, 7, 6 };
            int wait = 30;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}
