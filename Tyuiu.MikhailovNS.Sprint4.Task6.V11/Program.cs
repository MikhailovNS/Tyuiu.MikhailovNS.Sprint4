using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MikhailovNS.Sprint4.Task6.V11.Lib;

namespace Tyuiu.MikhailovNS.Sprint4.Task6.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Обработка структурных типов                                        *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #11                                                              *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан строковый массив данных [Кошка, Собака, Слон, Жираф, Бегемот,        *");
            Console.WriteLine("* Игуана, Ягуар] используя класс Array подсчитайте количество элементов,   *");
            Console.WriteLine("* длина которых равна 5.                                                   *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string[] array = { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };

            Console.WriteLine("Массив:");
            for(int i = 0; i<=array.Length-1;i++)
            {
                Console.WriteLine(array[i]);
            }
            
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine("Количество элементов, длинна которых равная 5: ");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
