using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AlmukhametovTI.Sprint2.Task1.V2.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint2.Task1.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 135;
            int b = 156;
            int c = 154;
            int d = 174;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 / Выполнил: Альмухаметов Т. И. | ИИПб-23-3";

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* Спринт #2                                                          *");
            Console.WriteLine("* Задание #1                                                         *");
            Console.WriteLine("* Вариант #2                                                         *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                           *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=)    *");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^) добавив арифметические  *");
            Console.WriteLine("* выражения, которая вернет логическую последовательность(массив):    ");
            Console.WriteLine("* (True, False, False, False, False, False), при a = 135, b = 156,   *");
            Console.WriteLine("* c = 154, d = 174.                                                  *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: int a = 135, int b = 156, int c = 154, int d = 174*");
            Console.WriteLine("**********************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

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
