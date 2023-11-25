namespace StudyPractice1ex3;

using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<string> data = new List<string>();

        Console.WriteLine("Введите элементы списка (для завершения введите пустую строку):");

        string input = Console.ReadLine();

        while (!string.IsNullOrEmpty(input))
        {
            data.Add(input);
            input = Console.ReadLine();
        }

        if (data.Count > 0)
        {
            string shortest = data[0];
            string longest = data[0];

            foreach (string line in data)
            {
                if (line.Length < shortest.Length)
                {
                    shortest = line;
                }
                if (line.Length > longest.Length)
                {
                    longest = line;
                }
            }

            Console.WriteLine($"Самая короткая строка: {shortest}");
            Console.WriteLine($"Самый длинная строка: {longest}");
        }
        else
        {
            Console.WriteLine("Список пуст");
        }
    }
}