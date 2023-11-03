using System;

using Tyuiu.MikhailovNS.Sprint4.Task3.V4.Lib;

namespace Tyuiu.MikhailovNS.Sprint4.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Обработка структурных типов                                        *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #4                                                               *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 8. Найдите минимальный       *");
            Console.WriteLine("* элемент в последнем столбце массива.                                     *");
            Console.WriteLine("* 6, 5, 4, 1, 5,                                                           *");
            Console.WriteLine("* 8, 2, 3, 4, 2,                                                           *");
            Console.WriteLine("* 3, 7, 7, 1, 3,                                                           *");
            Console.WriteLine("* 3, 4, 8, 1, 3,                                                           *");
            Console.WriteLine("* 4, 3, 5, 5, 2,                                                           *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int[,] array = new int[5, 5] { {6, 5, 4, 1, 5},
                                           {8, 2, 3, 4, 2},
                                           {3, 7, 7, 1, 3},
                                           {3, 4, 8, 1, 3},
                                           {4, 3, 5, 5, 2} };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.GetUpperBound(1) + 1;

            Console.WriteLine("Массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            


            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine("Минимальный элемент последнего столбца: " + res);

            Console.ReadKey();
        }
    }
}
