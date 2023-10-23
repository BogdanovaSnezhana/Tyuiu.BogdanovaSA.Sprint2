using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BogdanovaSA.Sprint2.Task7.V5.Lib;
namespace Tyuiu.BogdanovaSA.Sprint2.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила Богданова са | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется тремя натуральными числами:*");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m  *");
            Console.WriteLine("* определить дату предыдущего дня. Заданный год не является високосным.   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите Y:");
            double y = Convert.ToDouble(Console.ReadLine());








            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                                            *");
            Console.WriteLine("****************************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);
            if (res)
            {
                Console.WriteLine("точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("точка не находится в заштрихованной области");
            }


            Console.ReadLine();
        }
    }
    
}
