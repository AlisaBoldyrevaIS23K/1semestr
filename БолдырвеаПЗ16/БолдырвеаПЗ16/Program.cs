using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

[Serializable]
public class Person
{
    public string Name { get; set; }
    public int[] Marks { get; set; }

    public Person() { }

    public Person(string name, int[] marks)
    {
        Name = name;
        Marks = marks;
    }

    public double AverageMark => Marks.Average();
}

class Program
{
    static void Main()
    {
        // Десериализация данных из файла
        var people = DeserializePeople("people.xml");
        if (people == null || people.Count == 0)
        {
            Console.WriteLine("Файл пуст или не содержит данных.");
            return;
        }

        while (true)
        {
            Console.WriteLine("\nКоманды:");
            Console.WriteLine("1 - Показать самого лучшего ученика");
            Console.WriteLine("2 - Показать самого худшего ученика");
            Console.WriteLine("3 - Показать весь список");
            Console.WriteLine("4 - Показать учеников со средним баллом больше заданного");
            Console.WriteLine("Любая другая клавиша - Выход");

            var command = Console.ReadLine();
            switch (command)
            {
                case "1":
                    var best = FindBestStudent(people);
                    Console.WriteLine($"\nЛучший ученик: {best.Name}, Средний балл: {best.AverageMark:F2}");
                    break;
                case "2":
                    var worst = FindWorstStudent(people);
                    Console.WriteLine($"\nХудший ученик: {worst.Name}, Средний балл: {worst.AverageMark:F2}");
                    break;
                case "3":
                    Console.WriteLine("\nСписок всех учеников:");
                    PrintAllStudents(people);
                    break;
                case "4":
                    Console.Write("Введите минимальный средний балл: ");
                    if (double.TryParse(Console.ReadLine(), out double threshold))
                    {
                        Console.WriteLine($"\nУченики со средним баллом выше {threshold}:");
                        PrintStudentsAboveAverage(people, threshold);
                    }
                    break;
                default:
                    return;
            }
        }
    }

    // Рекурсивная десериализация из XML файла
    public static List<Person> DeserializePeople(string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            return (List<Person>)serializer.Deserialize(fs);
        }
    }

    // Рекурсивное нахождение лучшего ученика
    public static Person FindBestStudent(List<Person> people, int index = 0, Person best = null)
    {
        if (index >= people.Count) return best;
        if (best == null || people[index].AverageMark > best.AverageMark)
        {
            best = people[index];
        }
        return FindBestStudent(people, index + 1, best);
    }

    // Рекурсивное нахождение худшего ученика
    public static Person FindWorstStudent(List<Person> people, int index = 0, Person worst = null)
    {
        if (index >= people.Count) return worst;
        if (worst == null || people[index].AverageMark < worst.AverageMark)
        {
            worst = people[index];
        }
        return FindWorstStudent(people, index + 1, worst);
    }

    // Рекурсивный вывод всех учеников
    public static void PrintAllStudents(List<Person> people, int index = 0)
    {
        if (index >= people.Count) return;
        Console.WriteLine($"Имя: {people[index].Name}, Оценки: {string.Join(" ", people[index].Marks)}");
        PrintAllStudents(people, index + 1);
    }

    // Рекурсивный вывод учеников с баллом выше заданного
    public static void PrintStudentsAboveAverage(List<Person> people, double threshold, int index = 0)
    {
        if (index >= people.Count) return;
        if (people[index].AverageMark > threshold)
        {
            Console.WriteLine($"Имя: {people[index].Name}, Средний балл: {people[index].AverageMark:F2}");
        }
        PrintStudentsAboveAverage(people, threshold, index + 1);
    }
}