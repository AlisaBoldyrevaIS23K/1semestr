using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            ulong number = ulong.Parse(Console.ReadLine());
            string nummbers = number.ToString("X");
            Console.WriteLine($"Шестнадцатеричное представление: {nummbers}");
        }
    }
}