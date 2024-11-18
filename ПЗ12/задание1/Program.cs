using System;

namespace PZ10БолдыреваШевченко
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Численность группы = ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] ages = new int[n];
            for (int i = 0; i < n; i++)
            {
                while (true) 
                {
                    Console.Write("Возраст {0}-го человека: ", i + 1);
                    string input = Console.ReadLine();
                    try
                    {
                        ages[i] = Convert.ToInt32(input);                       
                        if (ages[i] < 0 || ages[i] > 120)
                        {
                            Console.WriteLine("Пожалуйста, введите возраст от 0 до 120.");
                            continue; 
                        }
                        break; 
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                    }
                }
            }
            double averageAge = 0;
            for (int i = 0; i < n; i++)
                averageAge += ages[i];

            averageAge /= n;

            int min = ages[0];
            int max = ages[0];

            for (int i = 1; i < n; i++)
            {
                if (ages[i] < min)
                    min = ages[i];
                if (ages[i] > max)
                    max = ages[i];
            }

            Console.WriteLine("ИТОГИ:");
            Console.WriteLine("Всего опрошено: {0}", n);
            Console.WriteLine("Средний возраст: {0:F2}", averageAge);
            Console.WriteLine("Минимальный возраст: {0}", min);
            Console.WriteLine("Максимальный возраст: {0}", max);
            Console.ReadKey();
        }
    }
}