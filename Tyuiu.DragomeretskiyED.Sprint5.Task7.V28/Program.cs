using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.DragomeretskiyED.Sprint5.Task7.V28.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint5.Task7.V28
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Драгомерецкий Е.Д. | СМАРТб-23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                  *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                    *");
            Console.WriteLine("* Задание #7                                                                 *");
            Console.WriteLine("* Вариант #27                                                                *");
            Console.WriteLine("* Выполнил: Драгомерецкий Егор Дмитриевич | СМАРТб-23-1                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask7V28.txt в котором есть набор     *");
            Console.WriteLine("* символьных данных.Заменить все пробелы, идущие подряд больше одного.       *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V27.txt.          *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask7V28.txt";
            string pathSaveFile = $@"C:\DataSprint5\OutPutDataFileTask7V28.txt";

            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();


        }
    }
}
