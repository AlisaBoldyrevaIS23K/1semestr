using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                Console.Write("Введите количество цифр в номере билета (четное число): ");
                int n = int.Parse(Console.ReadLine());

                // Проверка на четность количества цифр
                if (n % 2 != 0 || n <= 0)
                {
                    Console.WriteLine("Количество цифр должно быть четным положительным числом.");
                    return;
                }

                int half = n / 2;
                int maxNumber = (int)Math.Pow(10, n) - 1;
                int Lucky = 0;

                // Перебираем все возможные номера от 0 до максимального числа с n цифрами
                for (int i = 0; i <= maxNumber; i++)
                {
                    string ticket = i.ToString().PadLeft(n, '0'); // Дополняем нули слева для правильного количества цифр

                    int sum1 = 0;
                    int sum2 = 0;

                    //сумма первой половины и второй половины
                    for (int j = 0; j < half; j++)
                    {
                        sum1 += ticket[j] - '0';
                        sum2 += ticket[j + half] - '0';
                    }

                    // Если суммы равны, то билет "счастливый"
                    if (sum1 == sum2)
                    {
                        Lucky++;
                    }
                }

                Console.WriteLine($"Количество счастливых билетов с {n} цифрами: {Lucky}");
            }
        }
    }
}
