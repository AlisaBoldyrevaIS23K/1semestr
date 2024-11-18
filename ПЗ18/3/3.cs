using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начало интервала (a): ");
            double a = double.Parse(Console.ReadLine());Console.Write("Введите конец интервала (b): ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите шаг изменения аргумента: ");
            double step = double.Parse(Console.ReadLine());
            if (step <= 0 || b <= a)
            {
                Console.WriteLine("Неверный интервал или шаг.");
                return;
            }
            double area = 0.0;
            // метод левых прямоугольников
            for (double x = a; x < b; x += step)
            {
                double y = 7 - Math.Sin(x);
                area += y * step;
            }
            Console.WriteLine($"Приближенное значение площади под кривой y = 7 - sin(x) на заданном интервале: {area}");
        }
    }
}