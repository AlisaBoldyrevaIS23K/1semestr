using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Задание1
{
    internal class Задание1
    {
        static void Main(string[] args)
        {
            ContactString();
            JoinString();
            CompareHalloworld();
            FindInString();
            InsertString();
            DeleteString();
            ReplaceString();
            UpperLowerString();
            Console.ReadKey();
        }
        static void ContactString()
        {
            string s1, s2, s3, s4;
            s1 = "Привет";
            s2 = "Мир!";
            s3 = s1 + " " + s2;
            s4 = String.Concat(s3, "!!!");
            Console.WriteLine(s4);
        }
        static void JoinString()
        {
            string s5, s6, s7, s8, s9, s10, s11;
            s5 = "Каждый";
            s6 = "охотник";
            s7 = "желает";
            s8 = "знать";
            s9 = "где сидит";
            s10 = "фазан";
            string[] values = new string[] { s5, s6, s7, s8, s9, s10 };
            s11 = String.Join(" ", values);
            Console.WriteLine(s11);
        }
        static void CompareHalloworld()
        {
            string s1 = "Привет,";
            string s2 = "Мир!";
            int result = String.Compare(s1, s2);
            if (result < 0)
            {
                Console.WriteLine("Строка s1 перед строкой s2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка s1 после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }
        }
        static void FindInString()
        {
            string s1 = "Привет, Мир!";
            char ch = 'т';
            int indexOfChar = s1.IndexOf(ch);
            Console.WriteLine("Индекс в строке символа {0} - {1}", ch, indexOfChar);
            string SubString = "рив";
            int indexOfSubstring = s1.IndexOf(SubString);
            Console.WriteLine("Индекс подстроки в строке {0} - {1}", SubString, indexOfSubstring);
        }
        static void InsertString()
        {
            string text = "Задание выполнено";
            string subString = "не ";
            text = text.Insert(8, subString);
            Console.WriteLine(text);
        }
        static void DeleteString()
        {
            string text = "Задание выполнено";
            int ind = text.Length - 1;
            text = text.Remove(ind);
            Console.WriteLine(text);
            text = text.Remove(0, 2);
        }
        static void ReplaceString()
        {
            string text = "Солнечное утро";
            text = text.Replace("Солнечное", "Дождливое");
            Console.WriteLine(text);
        }
        static void UpperLowerString()
        {
            string hello = "Привет, Мир!";
            Console.WriteLine(hello.ToLower());
            Console.WriteLine(hello.ToUpper());
        }
    }
}
