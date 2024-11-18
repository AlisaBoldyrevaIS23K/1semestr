using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в восьмеричной системе счисления:");
            string octalInput = Console.ReadLine();

            try
            {
                ulong num8 = Convert.ToUInt64(octalInput, 8);
                Console.WriteLine($"Десятичное представление: {num8}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено недопустимое число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: число слишком велико для типа ulong.");
            }
        }
    }
}