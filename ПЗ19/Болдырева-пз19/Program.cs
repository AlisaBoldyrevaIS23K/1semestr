using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Болдырева_пз19
{
    internal class Program
    {
        class Point3D
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }

            // Конструктор
            public Point3D(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            // Вычисление расстояния от центра (0,0,0)
            public double DistanceFromCenter()
            {
                return Math.Sqrt(X * X + Y * Y + Z * Z);
            }

            // Вычисление расстояния до другой точки
            public double DistanceTo(Point3D other)
            {
                return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2) + Math.Pow(other.Z - Z, 2));
            }
        }

        static void Main(string[] args)
        {
            // Пример набора точек
            List<Point3D> points = new List<Point3D>
        {
            new Point3D(1, 2, 3),
            new Point3D(4, 5, 6),
            new Point3D(7, 8, 9),
            new Point3D(-1, -1, -1)
        };

            // Сортировка точек по расстоянию от центра
            points = points.OrderBy(p => p.DistanceFromCenter()).ToList();

            // Вывод отсортированных точек и их расстояний от центра
            Console.WriteLine("Точки, отсортированные по удалению от центра:");
            foreach (var point in points)
            {
                Console.WriteLine($"Точка ({point.X}, {point.Y}, {point.Z}) - Расстояние от центра: {point.DistanceFromCenter():F2}");
            }

            // Определение максимального и минимального расстояний между точками
            double maxDistance = 0;
            double minDistance = double.MaxValue;

            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    double distance = points[i].DistanceTo(points[j]);
                    if (distance > maxDistance)
                        maxDistance = distance;
                    if (distance < minDistance)
                        minDistance = distance;
                }
            }

            // Вывод максимального и минимального расстояний между точками
            Console.WriteLine($"\nМаксимальное расстояние между точками: {maxDistance:F2}");
            Console.WriteLine($"Минимальное расстояние между точками: {minDistance:F2}");
        }
    }
}