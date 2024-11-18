using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace БолдыреваПЗ18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите начало интервала (a): ");
            double a = double.Parse(Console.ReadLine());
           Console.Write("введите конец интервала (b): ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("введите шаг изменения аргумента(десятичная дробь): ");
            double step = double.Parse(Console.ReadLine());

            double maxY = double.MinValue;
            double maxX = a;

            for (double x = a; x <= b; x += step)
            {
                double y = 5 - Math.Cos(3 * x);

                if (y > maxY)
                {
                    maxY = y;
                    maxX = x;
                }
            }

            Console.WriteLine($"максимальное значение функции y = 5 - cos(3x) на заданном интервале: {maxY}");
            Console.WriteLine($"значение аргумента x, при котором достигается максимум: {maxX}");
        }
    }
}