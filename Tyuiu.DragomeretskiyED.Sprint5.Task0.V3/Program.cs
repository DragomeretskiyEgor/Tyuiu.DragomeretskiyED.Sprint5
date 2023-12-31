﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DragomeretskiyED.Sprint5.Task0.V3.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint5.Task0.V3
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 3;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил Драгомерецкий Е.Д. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание №0                                                              *");
            Console.WriteLine("* Вариант №3                                                              *");
            Console.WriteLine("* Выполнил: Драгомерецкий Егор Дмитриевич | СМАРТб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дано выражение y = - 1/4(x^3 - 3x^2 + 4)                                *");
            Console.WriteLine("* вычислить его значение при x = 3                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* X = 3                                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан!");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();


        }
    }
}
