namespace StudyPractice2ex5v2_0;

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{ 
    static int[] RandomTemp()
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
    }
}