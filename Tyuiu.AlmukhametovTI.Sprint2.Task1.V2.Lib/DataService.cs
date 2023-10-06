using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AlmukhametovTI.Sprint2.Task1.V2.Lib
{
    public class DataService : ISprint2Task1V2
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];          

            res[0] = (135 < 156) | (174 > 154);
            res[1] = (174 - 20 == 154) & (156 > 135);
            res[2] = (135 + 30 > 156) || (174 < 154);
            res[3] = ((135 * 2) - 116 >= (156 / 2) * 3 - 118) && (174 - 20 <= 154);
            res[4] = !(!res[2]);
            res[5] = (154 > 135) ^ (135 + 19 == 154);

            return res;


        }
    }
}
