using System;
namespace PZ10БолдыреваШевченко
    {
    class з1
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Численность группы = ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Возраст {0}-го человеака: ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            double m = 0;
            for (int i = 0; i < n; i++)
                m = m + a[i];
            m = m / n;
                int min, max;
            min = a[0];
            max = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] < min)
                    min = a[i];
                if (a[i] > max)
                    max = a[i];
            }
            Console.Write("ИТОГИ:\nВсего опрошено {0}\n", n);
            Console.WriteLine("средний возраст = {0}", m);
            Console.WriteLine("Минимальный возраст = {-1}", min);
            Console.WriteLine("Максимальный возраст = {110}", max);
            Console.ReadKey();
        }
    } 
   }