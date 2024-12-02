using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Болырева_ПЗ_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
             int sum()
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                    return 0;

                return number + sum();
            }
            {
                Console.WriteLine("введите последовательность чисел, заканчивающуюся 0:");
                int result = sum();
                Console.WriteLine($"Сумма: {result}");
            }
        }
    }
}
