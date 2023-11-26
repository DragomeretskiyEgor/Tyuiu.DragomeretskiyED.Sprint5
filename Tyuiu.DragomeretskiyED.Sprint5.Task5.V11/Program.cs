using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Tyuiu.DragomeretskiyED.Sprint5.Task5.V11.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint5.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService service1 = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Драгомерецкий Е.Д. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:Оператор цикла continue/break                                      *");
            Console.WriteLine("* Задание #5.5                                                            *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Драгомерецкий Егор Дмитриевич | СМАРТб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V11.txt";
            Console.WriteLine("Данные в файле:" + path);
            Console.WriteLine("File path: " + path);
            Console.WriteLine(String.Join(" ", File.ReadAllLines(path)));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(service1.LoadFromDataFile(path));

            Console.ReadKey();


        }
    }
}
