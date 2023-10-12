using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AlmukhametovTI.Sprint2.Task5.V4.Lib;

namespace Tyuiu.AlmukhametovTI.Sprint2.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 / Выполнил: Альмухаметов Т. И. | ИИПб-23-3";

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* Спринт #2                                                          *");
            Console.WriteLine("* Задание #5                                                         *");
            Console.WriteLine("* Вариант #4                                                         *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                           *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет   *");
            Console.WriteLine("* требуемое значение и возвращает результат.Условие: Мастям          *");
            Console.WriteLine("* игральных карт условно присвоены следующие порядковые номера:      *");
            Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3,            *");
            Console.WriteLine("* масти «червы» — 4. По заданному номеру масти m (1 <= m <= 4)       *");
            Console.WriteLine("* определить название соответствующей масти.                         *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                   *");
            Console.WriteLine("**********************************************************************");

            Console.WriteLine("Введите номер карты:                                                 *");
            int numMouth = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numMouth < 1) || (numMouth > 4))
            {
                res = "Введено неверное значение";
            }
            else
            {
                res = "Это карта: " + ds.FindCardSuit(numMouth);
            }

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                          *");
            Console.WriteLine("**********************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
