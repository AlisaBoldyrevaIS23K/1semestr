using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ5
{
    internal class Задание2
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("введите поочередно длины двух катетов");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            double z = Math.Sqrt(x * x + y * y);
            Console.WriteLine(z);
        }
    }
}
