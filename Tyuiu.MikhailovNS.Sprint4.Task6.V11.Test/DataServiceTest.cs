using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint4.Task6.V11.Lib;

namespace Tyuiu.MikhailovNS.Sprint4.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test()
        {
            DataService ds = new DataService();

            string [] array = { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
            int wait = 3;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}
