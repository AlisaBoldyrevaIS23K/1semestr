using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int[] k = { 1, 12, 32, 42, 52, 53, 64, 75, 86, 96,34,23,23,24,25,16,26,367,74,47,37 };
            foreach (int i in k)
            {
                if(i < 50 && i >20)
                {
                    Console.Write(i+" ");
                }
                
            }
            Console.ReadKey();
        }
    }
}
