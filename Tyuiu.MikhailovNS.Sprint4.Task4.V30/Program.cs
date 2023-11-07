using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MikhailovNS.Sprint4.Task4.V30.Lib;

namespace Tyuiu.MikhailovNS.Sprint4.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #4                                                                *");
            Console.WriteLine("* Тема: Обработка структурных типов                                        *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #30                                                              *");
            Console.WriteLine("* Выполнил: Михайлов Никита Станиславович | АСОиУБ-23-1                    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный         *");
            Console.WriteLine("* случайными значениями в диапазоне от 3 до 7. Заменить нечетные элементы  *");
            Console.WriteLine("* массива на 0.                                                            *");
            Console.WriteLine("* 3, 4, 6, 6, 5,                                                           *");
            Console.WriteLine("* 6, 7, 6, 3, 5,                                                           *");
            Console.WriteLine("* 5, 3, 5, 7, 6,                                                           *");
            Console.WriteLine("* 6, 4, 7, 6, 6,                                                           *");
            Console.WriteLine("* 7, 4, 3, 4, 5,                                                           *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите количество строк массива: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество строк массива: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                        Console.WriteLine($"Введите {i},{j} элемент массива");
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМассив:");

            for (int i = 0; i<rows; i++)
            {
                for(int j = 0; j<columns;j++)
                {
                    Console.Write($"{matrix[i,j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int[,] res = ds.Calculate(matrix);

            Console.WriteLine("\nИзмененный массив:");
            for(int i = 0; i<rows; i++)
            {
                for(int j = 0; j<columns; j++)
                {
                    Console.Write($"{res[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
