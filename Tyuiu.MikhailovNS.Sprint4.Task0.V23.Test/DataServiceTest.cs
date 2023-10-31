using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint4.Task0.V23.Lib;

namespace Tyuiu.MikhailovNS.Sprint4.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test()
        {
            DataService ds = new DataService();

            int[] array = {9,3,7,1,5,5,3,2,1,7};
            int wait = 99225;
            int res = ds.GetMultOddArrEl(array);

            Assert.AreEqual(wait, res);
        }
    }
}
