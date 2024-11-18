using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Массив строк, который нужно записать в файл
        string[] colors = { "red", "green", "black", "white", "blue" };

        // Открываем файл colors.txt для записи
        using (StreamWriter writer = new StreamWriter("colors.txt"))
        {
            WriteArray(writer, colors, 0);
        }
        Console.WriteLine("Цвета записаны в файл colors.txt.");
    }

    // Рекурсивный метод для записи элементов массива в файл построчно
    static void WriteArray(StreamWriter writer, string[] array, int index)
    {
        if (index >= array.Length) return; // Условие завершения рекурсии
        writer.WriteLine(array[index]); // Записываем текущий элемент массива в файл
        WriteArray(writer, array, index + 1); // Рекурсивный вызов для следующего элемента
    }
}