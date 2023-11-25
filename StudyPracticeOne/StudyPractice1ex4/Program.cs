namespace StudyPractice1ex4;

public class Program
{
    public static void Main(string[] args)
    {
        int start = 0, end = 0;
        Console.WriteLine("Введите начало диапазона:");
        start = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите конец диапазона:");
        end = Convert.ToInt32(Console.ReadLine());

        int[] data = GenerateRandomArray(start, end);
        
        for (int i = 0; i < data.Length; ++i)
        {
            Console.Write($"{data[i]} ");
        }
    }
    
    static int[] GenerateRandomArray(int start, int end)
    {
        const int N = 10;
        int[] data = new int[N];
        Random rnd = new Random();

        for (int i = 0; i < data.Length; ++i)
        {
            data[i] = rnd.Next(start, end + 1);
        }
        return data;
    }
}