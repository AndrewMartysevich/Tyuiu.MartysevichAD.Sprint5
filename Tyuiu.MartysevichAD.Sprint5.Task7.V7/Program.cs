using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.MartysevichAD.Sprint5.Task7.V7.Lib;

namespace Tyuiu.MartysevichAD.Sprint5.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Мартысевич А. Д. | ИИПб-23-3";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту               *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #7                                                             *");
            Console.WriteLine("* Выполнил: Мартысевич Андрей Денисович | ИИПб-23-3                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Создать папку в ручную и скопировать в неё файл в котором есть набор   *");
            Console.WriteLine("* символьных данных.Удалить все заглавные русские буквы из файла.        *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V7.txt.       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask7V7.txt";
            string pathSave = @"C:\DataSprint5\OutPutDataFileTask7V7.txt";
            Console.WriteLine("Данные находятся в файле " + path);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Находится в файле                                                      *");
            pathSave = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSave);
            Console.ReadKey();
        }
    }
}
