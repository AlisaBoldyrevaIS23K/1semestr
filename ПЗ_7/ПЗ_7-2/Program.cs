using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Я скоро поеду на научную конференцию в Курск";
            int indexGorod = text.IndexOf("Курск");
            Console.WriteLine("Индекс слова 'Курск': " + indexGorod);
            string newtext = text.Replace("в Курск", "");
            newtext = newtext.Replace("научную конференцию", "соревнование");
            newtext = newtext.ToUpper();
            Console.WriteLine(newtext);
            Console.ReadKey();
        }
    }
}
