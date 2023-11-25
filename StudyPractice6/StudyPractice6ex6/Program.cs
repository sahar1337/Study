namespace StudyPractice6ex6;

using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int arrayLength = random.Next(5, 11);

        double[] originalArray = new double[arrayLength];

        
        for (int i = 0; i < originalArray.Length; i++)
        {
            originalArray[i] = random.NextDouble() * 20 - 10;
        }

        List<double> positiveNumbers = new List<double>();
        List<double> negativeNumbers = new List<double>();

        
        foreach (double number in originalArray)
        {
            if (number > 0)
            {
                positiveNumbers.Add(number);
            }
            else if (number < 0)
            {
                negativeNumbers.Add(number);
            }
        }
        
        double[] positiveArray = positiveNumbers.ToArray();
        double[] negativeArray = negativeNumbers.ToArray();
        
        Console.WriteLine("Исходный массив:");
        foreach (double number in originalArray)
        {
            Console.WriteLine(Math.Round(number, 2));
        }

        Console.WriteLine("Массив положительных чисел:");
        foreach (double number in positiveArray)
        {
            Console.WriteLine(Math.Round(number, 2));
        }

        Console.WriteLine("Массив отрицательных чисел:");
        foreach (double number in negativeArray)
        {
            Console.WriteLine(Math.Round(number, 2));
        }
    }
}
