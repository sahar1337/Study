namespace StudyPractice6ex2;

public class Program
{
    public static void Main(string[] args)
    {
        string[] words;
        using (StreamReader reader = new StreamReader("numsTask2.txt"))
        {
            string content = reader.ReadToEnd();
            words = content.Split("\r\n");
        }
        foreach (var word in words)
        {
            Console.Write(word + " ");
        }
    }
}