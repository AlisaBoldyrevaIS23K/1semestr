using System;
using System.IO;
using System.Linq;
using System.Text;

class ЗАДАНИЕ1
{
    static void Main()
    {
        // Задание 1: Создать файл и записать числа от 1 до 500 через запятую
        using (StreamWriter writer = new StreamWriter("numbers.txt"))
        {
            WriteNumbers(writer, 1);
        }
        Console.WriteLine("Числа от 1 до 500 записаны в файл numbers.txt.");

        // Задание 2: Записать массив строк в файл построчно
        string[] colors = { "red", "green", "black", "white", "blue" };
        using (StreamWriter writer = new StreamWriter("colors.txt"))
        {
            WriteArray(writer, colors, 0);
        }
        Console.WriteLine("Цвета записаны в файл colors.txt.");

        // Задание 3: Проверка существования файла
        if (File.Exists("example.txt"))
        {
            using (StreamReader reader = new StreamReader("example.txt"))
            {
                int maxLength = FindMaxLineLength(reader, 0);
                Console.WriteLine($"Длина самой длинной строки в файле example.txt: {maxLength}");
            }
        }
        else
        {
            Console.WriteLine("Файл example.txt не найден. Добавьте файл в папку проекта.");
        }
    }

    // Рекурсивный метод для записи чисел от 1 до 500 через запятую
    static void WriteNumbers(StreamWriter writer, int n)
    {
        if (n > 500) return;
        writer.Write(n + (n < 500 ? "," : ""));
        WriteNumbers(writer, n + 1);
    }

    // Рекурсивный метод для записи массива строк в файл построчно
    static void WriteArray(StreamWriter writer, string[] array, int index)
    {
        if (index >= array.Length) return;
        writer.WriteLine(array[index]);
        WriteArray(writer, array, index + 1);
    }

    // Рекурсивный метод для нахождения максимальной длины строки в файле
    static int FindMaxLineLength(StreamReader reader, int maxLength)
    {
        if (reader.EndOfStream) return maxLength;
        string line = reader.ReadLine();
        maxLength = Math.Max(maxLength, line.Length);
        return FindMaxLineLength(reader, maxLength);
    }
}