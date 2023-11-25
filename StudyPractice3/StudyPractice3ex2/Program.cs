namespace StudyPractice3ex2;

using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string filePath = "nums.txt";
        
        string content;
        using (StreamReader reader = new StreamReader(filePath))
        {
            content = reader.ReadToEnd();
        }
        
        string[] numbersString = content.Split(' ');
        int[] numbers = Array.ConvertAll(numbersString, int.Parse);
        
        string result = "";
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                result += number + " ";
            }
        }
        
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.Write(result); // Записываем отфильтрованные нечетные числа обратно в файл
        }
    }
}