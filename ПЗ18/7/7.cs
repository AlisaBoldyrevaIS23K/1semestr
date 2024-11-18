using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static Random random = new Random();

        static double GetRandomCoordinate(double range)
        {
            return (2 * range) * random.NextDouble() - range;
        }
        static double MonteCarloVolume(double radius, int iterations)
        {
            int insideSphere = 0;
            double range = radius;

            for (int i = 0; i < iterations; i++)
            {
                double x = GetRandomCoordinate(range);
                double y = GetRandomCoordinate(range);
                double z = GetRandomCoordinate(range);

                if (x * x + y * y + z * z <= radius * radius)
                {
                    insideSphere++;
                }
            }
            double cubeVolume = Math.Pow(2 * radius, 3);

            double sphereVolume = (insideSphere / (double)iterations) * cubeVolume;
            return sphereVolume;
        }
        static double CalculateAccuracy(double estimatedVolume, double exactVolume)
        {
            return Math.Abs(estimatedVolume - exactVolume) / exactVolume * 100;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите радиус сферы: ");
            double radius = double.Parse(Console.ReadLine());

            Console.Write("Введите количество итераций: ");
            int iterations = int.Parse(Console.ReadLine());

            double exactVolume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

            double estimatedVolume = MonteCarloVolume(radius, iterations);

            double accuracy = CalculateAccuracy(estimatedVolume, exactVolume);
            Console.WriteLine($"Приближенный объем сферы: {estimatedVolume}");
            Console.WriteLine($"Точный объем сферы: {exactVolume}");
            Console.WriteLine($"Точность вычисления: {accuracy}%");
        }
    }
}