using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AlmukhametovTI.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int previousDay;
            int previousMonth;
            int previousYear;

            switch (m)
            {
                case 1: 
               
                    previousMonth = 12;
                    previousYear = g - 1;
                    break;
                case 3: 
                case 5: 
                case 7: 
                case 8: 
                case 10: 
                case 12: 
                    previousMonth = m;
                    previousYear = g;
                    break;
                default:
                    previousMonth = m ;
                    previousYear = g;
                    break;
            }

            
            if (n == 1)
            {
                switch (previousMonth)
                {
                    case 4: 
                    case 6: 
                    case 9: 
                    case 11: 
                        previousDay = 30;
                        break;
                    case 2: 
                        previousDay = 28;
                        break;
                    default:
                        previousDay = 31;
                        break;
                }
            }
            else
            {
                previousDay = n - 1;
            }

            return $"{previousYear}/{previousMonth}/{previousDay}";
        }
    }
}
