using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BogdanovaSA.Sprint2.Task2.Library;


namespace Tyuiu.BogdanovaSA.Sprint2.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Исходные данные :");
            Console.WriteLine("x= ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y= ");
            int y = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();
            booi res = ds.CheckDotInShadeArea(x, y);
            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
               
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }
            Console.ReadKey();
        }
    }
}
