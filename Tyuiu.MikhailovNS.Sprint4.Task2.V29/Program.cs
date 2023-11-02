using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MikhailovNS.Sprint4.Task2.V29.Lib;

namespace Tyuiu.MikhailovNS.Sprint4.Task2.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Обработка структурных типов                                        *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #29                                                              *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный          *");
            Console.WriteLine("* случайными в диапазоне от 1 до 8 подсчитать произведение четных          *");
            Console.WriteLine("* элементов массива.                                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            
            int[] array = new int[len];
            
            for (int i = 0; i <= len - 1; i++)
            {
                array[i] = rnd.Next(1,9);   
            }
            Console.WriteLine("Массив: ");

            for (int i =0; i<=len-1;i++)
            {
                Console.Write(array[i] + "\t");
            }

            Console.WriteLine();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine("Произведение четных элементов массива: " + res);

            Console.ReadKey();
        }
    }
}
