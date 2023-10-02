using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AlmukhametovTI.Sprint2.Task0.V17.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint2.Task0.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 1065;
            int y = 755;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #0 / Выполнил: Альмухаметов Т. И. | ИИПб-23-3";

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* Спринт #2                                                          *");
            Console.WriteLine("* Задание #0                                                         *");
            Console.WriteLine("* Вариант #17                                                        *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                           *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,)   *");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую              *");
            Console.WriteLine("* последовательность(массив): (True, False, False, False, False,     *");
            Console.WriteLine("*   False), при x = 1065, y = 755                                    *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ    int a = 1065, int b = 755                       *");
            Console.WriteLine("**********************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);          
          
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                          *");
            Console.WriteLine("**********************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();

        }
    }
}
