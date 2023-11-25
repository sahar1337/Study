namespace StudyPractice2;

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    //ЗАДАНИЕ 2.1
    /*public static void Main(string[] args)
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
    }*/
    
    //ЗАДАНИЕ 2.2
    /*public static void Main(string[] args)
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
    }*/
    
    //ЗАДАНИЕ 2.3
    /*public static void Main(string[] args)
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
    }*/
    
    //ЗАДАНИЕ 2.4
    /*const int N = 12;
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
    }*/
    
    //ЗАДАНИЕ 2.5
    /*static int[] RandomTemp()
    {
        Random rnd = new Random();
        int[] temp = new int[30];

        for (int i = 0; i < temp.Length; ++i)
        {
            temp[i] = rnd.Next(-30, 30);
        }

        return temp;
    } 
    
    static Dictionary<string, int> Temp(Dictionary<string, int[]> month)
    {
        Dictionary<string, int> averageTemp = new Dictionary<string, int>();
        foreach (var n in month)
        {
            string nameMonth = n.Key;
            int[] monthTemp = n.Value;
            int sum = 0;

            foreach (var dayTemperature in monthTemp)
            {
                sum += dayTemperature;
            }
                
            int average = sum / 30;

            averageTemp.Add(nameMonth, average);
        }

        return averageTemp;
    }
    
    public static void Main(string[] args)
    {
        var month = new Dictionary<string, int[]>()
        {
            {"Январь", RandomTemp() },
            {"Февраль", RandomTemp()},
            {"Март", RandomTemp()},
            {"Апрель", RandomTemp()},
            {"Май", RandomTemp()},
            {"Июнь", RandomTemp()},
            {"Июль", RandomTemp()},
            {"Август", RandomTemp()},
            {"Сентябрь", RandomTemp()},
            {"Октябрь", RandomTemp()},
            {"Ноябрь", RandomTemp()},
            {"Декабрь", RandomTemp()},
        };

        foreach (var n in month)
        {
            Console.Write($"{n.Key}: ");
            foreach (var temp in n.Value)
            {
                Console.Write($"{temp} ");
            }
            Console.WriteLine();
        }
        
        var averageTemp = Temp(month);
        Console.WriteLine("\nСредняя температура по месяцам: ");
        foreach (var average in averageTemp)
        {
            Console.WriteLine($"{average.Key}: {average.Value}");
        }
        
        var sortedAverageTemp = averageTemp.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        Console.WriteLine("\nСредняя температура по месяцам (отсортированная по возрастанию):");
        foreach (var average in sortedAverageTemp)
        {
            Console.WriteLine($"{average.Key}: {average.Value}");
        }
    }*/
    
}