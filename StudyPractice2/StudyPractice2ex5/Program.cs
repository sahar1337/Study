namespace StudyPractice2ex5;

using System.Globalization;

public class Program
{
    
    const int N = 12;
    const int M = 30;
    
    public static void Main(string[] args)
    {
        Dictionary<string, List<int>> temperature = GenerateRandomTemperatures();

        Dictionary<string, double> averageTemperatures = CalculateAverageTemperatures(temperature);
        
        foreach (var month in averageTemperatures)
        {
            Console.WriteLine($"Средняя температура в месяце {month.Key}: {month.Value}");
        }
    }
    
    // Метод для генерации случайных температур
        static Dictionary<string, List<int>> GenerateRandomTemperatures()
        {
            Random rnd = new Random();
            Dictionary<string, List<int>> temperatures = new Dictionary<string, List<int>>();

            for (int month = 1; month <= N; month++)
            {
                List<int> monthlyTemperatures = new List<int>();
                for (int day = 1; day <= M; day++)
                {
                    monthlyTemperatures.Add(rnd.Next(-20, 40)); // Генерация случайной температуры в диапазоне от -20°C до 40°C
                }
                temperatures.Add(GetMonthName(month), monthlyTemperatures);
            }

            return temperatures;
        }

        // Метод для вычисления средних температур
        static Dictionary<string, double> CalculateAverageTemperatures(Dictionary<string, List<int>> temperatures)
        {
            Dictionary<string, double> averageTemperatures = new Dictionary<string, double>();

            foreach (var month in temperatures)
            {
                double averageTemperature = 0;
                foreach (var temp in month.Value)
                {
                    averageTemperature += temp;
                }
                averageTemperature /= month.Value.Count;
                averageTemperatures.Add(month.Key, averageTemperature);
            }

            // Сортировка словаря по средним температурам
            var sortedAverageTemperatures = new Dictionary<string, double>(averageTemperatures);
            foreach (var item in averageTemperatures.OrderBy(key => key.Value))
            {
                sortedAverageTemperatures[item.Key] = item.Value;
            }

            return sortedAverageTemperatures;
        }

        // Метод для получения названия месяца по номеру
        static string GetMonthName(int month)
        {
            DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
            return dtfi.GetMonthName(month);
        }
}