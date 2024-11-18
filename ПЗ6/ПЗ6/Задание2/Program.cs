using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FIO = "Пономарев ";
            int EzDate = 30102006;
            string Place = "место рождения: г.Новосибирск, капуста ";
            String Date = String.Format("{0:##/##/####}", EzDate);
            int Age = 17;
            Console.WriteLine(FIO);
            Console.WriteLine(Place);
            Console.WriteLine("дата рождения: " + Date);
            Console.WriteLine("полных лет:" + Age);
            string FI2 = "Болдырева "; 
            int EzDat2 = 21022007;
            string Plac2 = "место рождения: г.Курск, Аист ";
            String Dat2 = String.Format("{0:##/##/####}", EzDat2);
            Console.WriteLine("--------------");
            Console.WriteLine(FI2);
            Console.WriteLine(Plac2);
            Console.WriteLine("дата рождения: " + Dat2);
            Console.WriteLine("полных лет:" + Age);
            Console.ReadKey();
        }
    }
}
