using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xdd = 12341234;
            string Form;
            Form = String.Format("{0:##/n##/n####}", xdd);
                               Console.WriteLine(Form);
            Console.ReadKey();
        }
    }
}
