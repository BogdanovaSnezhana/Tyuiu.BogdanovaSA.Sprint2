using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BogdanovaSA.Sprint2.Task1.V17.Lib;

namespace Tyuiu.BogdanovaSA.Sprint2.Task1.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 135;
            int b = 123;
            int c = 455;
            int d = 321;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(a, b, c, d);
            Console.WriteLine("Исходные данные: ");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine(" Результат: ");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
