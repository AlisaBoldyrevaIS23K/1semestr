using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    { 
        static double Fun(double x)
        {
            return 2 * x + 2 - Math.Sin(x / 3);
        }
        static double TrapezoidalRule(double a, double b, double step)
        {
            double sum = 0;
            double n = (b - a) / step;

            for (double x = a; x < b; x += step)
            {
                sum += Fun(x) + Fun(x + step);
            }

            sum *= step / 2;
            return sum;
        }
            static void Main(string[] args)
        {
            Console.Write("Введите начало интервала (a): ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите конец интервала (b): ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите шаг (step): ");
            double step = double.Parse(Console.ReadLine());

            if (step <= 0 || a >= b)
            {
                Console.WriteLine("Некорректные данные!");
                return;
            }

            double area = TrapezoidalRule(a, b, step);

            Console.WriteLine("Площадь под кривой на интервале [{a}, {b}] равна: {area}");
        }
    }
}