namespace StudyPractice6;

public class Program
{
    public static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader("numsTask1.txt"))
        {
            string line = reader.ReadLine();
            string[] words = line.Split(" ");
            
            Console.WriteLine("Строка со словами нечётной длины:");
            foreach (string word in words)
            {
                if (word.Length % 2 != 0)
                {
                    Console.Write($"{word} ");
                }
            }
        }
    }
}