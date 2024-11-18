using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = 74712370219;
            String Result = String.Format("{0:+#(####)##-##-##}",n);
            Console.WriteLine("«Курский государственный политехнический колледж»");
            Console.WriteLine("Контактная информация");
            Console.WriteLine("Контактные телефоны: "+Result);
            Console.WriteLine("Контактный факс: "+Result);
            Console.ReadKey();
        }
    }
}
