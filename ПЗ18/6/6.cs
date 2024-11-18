using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Введите число: ");
                ulong number = ulong.Parse(Console.ReadLine());
                string zufri = Convert.ToString((long)number, 2);
                int nylu = 0;
                foreach (char bit in zufri)
                {
                    if (bit == '0')
                    {
                    nylu++;
                    }
                }
                Console.WriteLine("Количество нулей в двоичном представлении числа: {nylu}");
        }
    }
}