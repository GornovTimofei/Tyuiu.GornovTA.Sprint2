using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GornovTA.Sprint2.Task1.V14.Lib;

namespace Tyuiu.GornovTA.Sprint2.Task1.V14
{
    class Program
    {
        static void Main()
        {
            DataService ds = new DataService();
            int a = 185;
            int b = 216;
            int c = 174;
            int d = 917;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт №2 | Выполнил: Горнов Т. А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №2                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание №1                                                              *");
            Console.WriteLine("* Вариант №14                                                             *");
            Console.WriteLine("* Выполнил: Горнов Тимофей Анатольевич | АСОиУб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций, а также *");
            Console.WriteLine("* арифметических выражений, которая вернёт логическую последовательность  *");
            Console.WriteLine("* (False, True, True, True, True, False).                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
