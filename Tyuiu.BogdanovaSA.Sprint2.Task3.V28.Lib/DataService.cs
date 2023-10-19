using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BogdanovaSA.Sprint2.Task3.V28.Lib
{
    public class DataService : ISprint2Task3V28
    {
        double ISprint2Task3V28.Calculate(double x)
        {
            if (x > 1) return Math.Round(x + Math.Pow(((Math.Cos(x) * Math.Cos(x)) / (x - 1)), x + 3));
            else if (x == 0) return Math.Round((Math.Pow(x, 2) + Math.Cos(x) * Math.Cos(x) - 11) / (Math.Pow(x, 2) - Math.Sin(x) * Math.Sin(x) + 2));
            else if ((x > -32) && (x < -1)) return Math.Round(Math.Pow(Math.Cos(x) / (Math.PI - x), 2));
            else if (x < -32) return (x + 10 * x - 7 / x);
        }
    }
}
