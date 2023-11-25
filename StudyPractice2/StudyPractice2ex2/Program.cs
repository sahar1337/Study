namespace StudyPractice2ex2;

public class Program
{
    public static void Main(string[] args)
    {
        const int N = 15;
        int[] data = new int[N];
        int number = 1;

        for (int i = 0; i < data.Length; ++i)
        {
            data[i] = number;
            number += 2;
        }
        
        Console.WriteLine("Массив последовательных нечетных чисел, начиная с 1:");
        for (int i = 0; i < data.Length; ++i)
        {
            Console.WriteLine($"data[{i}] = {data[i]}");
        }
    }
}