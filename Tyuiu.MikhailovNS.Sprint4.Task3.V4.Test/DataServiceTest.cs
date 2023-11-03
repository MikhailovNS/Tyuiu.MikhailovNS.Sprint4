using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint4.Task3.V4.Lib;

namespace Tyuiu.MikhailovNS.Sprint4.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] { {6, 5, 4, 1, 5}, 
                                           {8, 2, 3, 4, 2}, 
                                           {3, 7, 7, 1, 3}, 
                                           {3, 4, 8, 1, 3}, 
                                           {4, 3, 5, 5, 2} };

            int res = ds.Calculate(array);
            int wait = 2;
            Assert.AreEqual(wait,res);
        }
    }
}
