using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MartysevichAD.Sprint5.Task2.V16.Lib;

namespace Tyuiu.MartysevichAD.Sprint5.Task2.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Мартысевич А. Д. | ИИПб-23-3";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема:  Класс File. Запись структурированных данных в текстовый файл    *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #16                                                            *");
            Console.WriteLine("* Выполнил: Мартысевич Андрей Денисович | ИИПб-23-3                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный       *");
            Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1, *");
            Console.WriteLine("* отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv     *");
            Console.WriteLine("* и вывести на консоль.                                                  *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            int[,] matrix = new int[3, 3] { { 2, -4, -8 }, { 3, -7, -2 }, { 3, 8, 6 } };
           
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
           
            DataService ds = new DataService();
            
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            string res = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Файл" + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
