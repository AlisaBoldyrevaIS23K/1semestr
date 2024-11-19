using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;
            for (int i = 1; i < 20; i += 2)
            {
                summ += i;
            }
            Console.WriteLine(summ);
            Console.ReadLine();
        }
    }
}
