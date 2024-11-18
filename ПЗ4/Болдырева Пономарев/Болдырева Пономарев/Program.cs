using System;

namespace TypesConvertion
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string stringValue = Console.ReadLine();
            int intValue = Convert.ToInt32(stringValue);
            long longValue = intValue;
            float floatValue = intValue;
            Console.WriteLine($"Переменная типа long = {longValue}");
            Console.WriteLine($"Переменная типа float = {floatValue}");
        }
    }
}