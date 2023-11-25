namespace StudyPractice2ex3;

public class Program
{
    public static void Main(string[] args)
    {
        const int N = 5;
        int[,] data = new int[N, N];
        
        for (int i = 0; i < N; ++i)
        {
            data[0, i] = 1;
            data[i, 0] = 1;
        }
        
        for (int i = 1; i < N; ++i)
        {
            for (int j = 1; j < N; ++j)
            { 
                data[i, j] = data[i - 1, j] + data[i, j - 1];
            }
        }
        
        Console.WriteLine("Полученная матрица:");
        for (int i = 0; i < N; ++i)
        {
            for (int j = 0; j < N; ++j)
            {
                Console.Write($"{data[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
}