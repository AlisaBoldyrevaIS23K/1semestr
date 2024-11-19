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
            int[] x = { 2, 3, 4, 5, 6, 7, 8 };
            int[] y = { 2, 3, 4, 5};
            foreach (int i in x)
            {
                Console.WriteLine();
                foreach (int j in y)
                {
                    Console.Write(i*j+" ");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
