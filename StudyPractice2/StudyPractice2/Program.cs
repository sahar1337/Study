namespace StudyPractice2;

public class Program
{
    public static void Main(string[] args)
    {
        const int N = 100;
        int[] data = new int[N];

        Console.Write("Введите желаемое максимальное число в массиве: ");
        int max = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < data.Length; ++i)
        {
            data[i] = max;
            max -= 3;
        }
        
        Console.WriteLine($"Массив с убыванием на 3:");
        for (int i = 0; i < data.Length; ++i)
        {
            Console.WriteLine($"data[{i}] = {data[i]}");
        }
    }
}