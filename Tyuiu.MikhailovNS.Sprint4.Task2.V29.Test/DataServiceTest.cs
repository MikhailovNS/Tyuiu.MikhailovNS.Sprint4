using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint4.Task2.V29.Lib;

namespace Tyuiu.MikhailovNS.Sprint4.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = new int[] { 1,2,3,4,5,6,7,8};

            int wait = 384;

            int res = ds.Calculate(array);

            Assert.AreEqual(wait,res);
        }
    }
}
