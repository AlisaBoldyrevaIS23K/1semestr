using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m;
            string n = Console.ReadLine();
            m = Convert.ToDouble(n);
            String Result = String.Format("{0:+#(####)##-##-##}", m);
            Console.WriteLine("Контактный телефон: " + Result);
            Console.ReadKey();
        }
    }
}
