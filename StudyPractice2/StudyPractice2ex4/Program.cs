namespace StudyPractice2ex4;

public class Program
{
    const int N = 12;
    const int M = 30;
    
    public static void Main(string[] args)
    {
        int[,] data = new int[N, M];
        Random rnd = new Random();
        
        for (int month = 0; month < N; ++month)
        {
            for (int day = 0; day < M; ++day)
            {
                data[month, day] = rnd.Next(-30, 31);
            }
        }
            
        int[] averageData = AverageTemperatures(data);

        for (int i = 0; i < N - 1; ++i)
        {
            for (int j = 0; j < N - i - 1; ++j)
            {
                if (averageData[j] > averageData[j + 1])
                {
                    int temp = averageData[j];
                    averageData[j] = averageData[j + 1];
                    averageData[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Отсортированные средние температуры по месяцам:");
        foreach (int temperature in averageData)
        {
            Console.Write($"{temperature} ");
        }
    }
    
    static int[] AverageTemperatures(int[,] data)
    {
        int[] averageTemperatures = new int[N];
        for (int month = 0; month < N; month++)
        {
            int sum = 0;
            for (int day = 0; day < M; day++)
            {
                sum += data[month, day];
            }
            averageTemperatures[month] = sum / M;
        }
        return averageTemperatures;
    }
    
}