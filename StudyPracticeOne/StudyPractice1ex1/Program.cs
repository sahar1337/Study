namespace StudyPracticeOne;

public class Program
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();

        const int N = 10;
        int[] data = new int[N];
        for (int i = 0; i < data.Length; ++i)
        {
            data[i] = rnd.Next(50);
        }

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < data.Length; ++i)
        {
            Console.Write($"{data[i]} ");
        }

        int minNumber = data[0];
        int minIndex = 0;
        for (int i = 1; i < data.Length; ++i)
        {
            if (data[i] < minNumber)
            {
                minNumber = data[i];
                minIndex = i;
            }
        }

        Console.WriteLine($"\nМинимальное число {minNumber} c индексом {minIndex}");
    }
}