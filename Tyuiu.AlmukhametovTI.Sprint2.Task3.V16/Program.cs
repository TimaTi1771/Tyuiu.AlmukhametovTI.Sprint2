﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AlmukhametovTI.Sprint2.Task3.V16.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint2.Task3.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 / Выполнил: Альмухаметов Т. И. | ИИПб-23-3";

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* Спринт #2                                                          *");
            Console.WriteLine("* Задание #3                                                         *");
            Console.WriteLine("* Вариант #16                                                        *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                           *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции   *");
            Console.WriteLine("* Y с использованием вложенных оператор if-else, где пользователь    *");
            Console.WriteLine("* вводит значение переменной X с клавиатуры. Округлить полученное    *");
            Console.WriteLine("* значение до трех знаков после запятой;                             *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                   *");
            Console.WriteLine("**********************************************************************");
                                                                               
            Console.WriteLine("Введите значение переменной X:                                       *");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);
           
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                          *");
            Console.WriteLine("**********************************************************************");

            Console.WriteLine($"Значение функции =  {res}");

            Console.ReadKey();
        }
    }
}
