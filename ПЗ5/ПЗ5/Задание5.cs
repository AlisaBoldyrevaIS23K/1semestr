﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5
{
    internal class Задание5
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("введите поочередно длины двух катетов");
            int x = 2;
            int y = 5;
            double z = (x - y) / (1 + x * y);
            Console.WriteLine(z);
        }
    }
}