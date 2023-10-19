using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BogdanovaSA.Sprint2.Task2.V14.Library
{
    public class DataService : ISprint2Task0V14
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool res;

            if ((x>=2)&&(x<=5)&&(y>=2)&&(y<=7)&&(x>=1)&&(x<=2)&&(y>=3)&&(y<=5)&&(x>=5)&&(y<=8)&&(y>=4)&&(y<=11)&&(x>=2)&&(x<=5)&&(y>=10)&&(y<=11)&&(x>=9)&&(x<=13)&&(y>=1)&&(y<=5)&&(x>=8)(x<=9)&&(y>=4)&&(y<=5)&&(x>=12)&&(x<=13)&&(y>=1)&&(y<=3)&&(x>=6)&&(x<=10)&&(y>=11)&&(y<=12)&&(x>=12)&&(x<=13)&&(y>=8)&&(y<=13))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;

        }
    }
}
