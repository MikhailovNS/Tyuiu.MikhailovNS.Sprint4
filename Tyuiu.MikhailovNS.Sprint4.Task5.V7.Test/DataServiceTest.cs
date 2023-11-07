using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint4.Task5.V7.Lib;

namespace Tyuiu.MikhailovNS.Sprint4.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test5()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3] { {1,-2,3}, 
                                            {-2,3,1}, 
                                            {3,2,-1} };
            int wait = 3;
            int res = ds.Calculate(matrix);
            Assert.AreEqual(wait, res);

        }
    }
}
