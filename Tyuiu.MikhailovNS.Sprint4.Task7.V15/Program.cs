using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MikhailovNS.Sprint4.Task7.V15.Lib;

namespace Tyuiu.MikhailovNS.Sprint4.Task7.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Обработка структурных типов                                        *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #15                                                              *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '10293847'. Преобразуйте ее            *");
            Console.WriteLine("* в матрицу 4 на 2 и подсчитайте количество нечетных чисел в матрице.      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string str = "10293847";

            int n = 2;
            int m = 4;
            int[,] mat = new int[n, m];

            int index = 0;

            Console.WriteLine("\nМассив:");
            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j<m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(n, m, str);

            Console.WriteLine("Число нечетных элементов массива равно " + res);
            Console.ReadKey();

        }
    }
}
