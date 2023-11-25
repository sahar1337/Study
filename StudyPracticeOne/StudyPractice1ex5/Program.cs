namespace StudyPractice1ex5;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите строку: ");
        string line = Console.ReadLine();
        
        string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; ++i)
        {
            Console.WriteLine($"words[{i}] = {words[i]}");
        }
        
        int wordsCount = words.Length;
        Console.WriteLine($"Количество слов в ведённой строке: {wordsCount}");

        List<string> wordList = new List<string>(words);
        wordList.Insert(0, "Start");
        wordList.Add("End");
        
        Console.Write("Изменённая строка: ");
        foreach (string word in wordList)
        {
            Console.Write($"{word} ");
        }
    }
}