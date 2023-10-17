using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BogdanovaSA.Sprint2.Task0.V8.Lib
{
    public class DataService : ISprint2Task0V8
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x + y == 436;
            res[1] = x * 3 != y;
            res[2] = y - x > 60;
            res[3] = x / 2 < y / 3;
            res[4] = x % 2 == 1;
            res[5] = y % 2 == 0;
            return res;
        }
    }
}
