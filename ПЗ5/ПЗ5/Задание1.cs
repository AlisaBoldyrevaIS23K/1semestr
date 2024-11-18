using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5
{
    internal class Задание1з
    {
        private static void Main(string[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            int o= Convert.ToInt32(Console.ReadLine());
            if (i >= o)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(o);
            }
        }
    }
}
