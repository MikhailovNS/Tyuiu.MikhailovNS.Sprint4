using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MikhailovNS.Sprint4.Task5.V7.Lib;

namespace Tyuiu.MikhailovNS.Sprint4.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Random rnd = new Random();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Обработка структурных типов                                        *");
            Console.WriteLine("* Задание #5                                                               *");
            Console.WriteLine("* Вариант #7                                                               *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный         *");
            Console.WriteLine("* случайными значениями в диапазоне от -7 до 7. Найти количество           *");
            Console.WriteLine("* отрицательных элементов.                                                 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите количество строк в массиве:");
            int rows = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите количество строк в массиве:");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            Console.WriteLine("****************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j =0; j<columns; j++)
                {
                    matrix[i, j] = rnd.Next(-7, 8);
                }
            }

            Console.WriteLine("\nМассив:");

            for(int i =0;i<rows;i++)
            {
                for(int j =0; j<columns; j++)
                {
                    Console.Write($"{matrix[i,j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.Calculate(matrix);
            Console.WriteLine("Количество отрицательных элементов в массиве:" + res);

            Console.ReadKey();
        }
    }
}
