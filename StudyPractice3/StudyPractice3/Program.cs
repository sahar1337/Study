namespace StudyPractice3;

using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите числа, разделяя их пробелом:");
        string chosenNumbersLine = Console.ReadLine();
        string[] chosenNumbersStr = chosenNumbersLine.Split(' ');
        int[] chosenNumbers = Array.ConvertAll(chosenNumbersStr, int.Parse);

        Console.WriteLine("Введите количество билетов:");
        int n = int.Parse(Console.ReadLine());

        using (StreamWriter file = new StreamWriter("input.txt"))
        {
            file.WriteLine(chosenNumbersLine);
            file.WriteLine(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите числа на билете {i + 1}:");
                string ticketNumbersLine = Console.ReadLine();
                file.WriteLine(ticketNumbersLine);
            }
        }

        using (StreamReader sr = new StreamReader("input.txt"))
        using (StreamWriter sw = new StreamWriter("output.txt"))
        {
            sr.ReadLine();
            sr.ReadLine();

            for (int i = 0; i < n; i++)
            {
                string ticketNumbersLine = sr.ReadLine();
                string[] ticketNumbersStr = ticketNumbersLine.Split(' ');
                int[] ticketNumbers = Array.ConvertAll(ticketNumbersStr, int.Parse);
                int count = 0;
                for (int j = 0; j < ticketNumbers.Length; j++)
                {
                    if (Array.IndexOf(chosenNumbers, ticketNumbers[j]) != -1)
                    {
                        count++;
                    }
                }
                
                if (count >= 3)
                {
                    sw.WriteLine("Lucky");
                }
                else
                {
                    sw.WriteLine("Unlucky");
                }
            }
        }
    }
}