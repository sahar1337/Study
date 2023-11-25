namespace StudyPractice1ex2;

using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> data = new List<int>();

        Console.WriteLine("Введите числа (0 для завершения списка): ");

        int input = 1;

        while (input != 0)
        {
            input = Convert.ToInt32(Console.ReadLine());
            if (input != 0)
            {
                data.Add(input);
            }
        }

        if (data.Count > 0)
        {
            int sum = 0;
            foreach (int number in data)
            {
                sum += number;
            }

            Console.WriteLine($"Сумма всех элементов: {sum}");

            int product = 1;
            foreach (int number in data)
            {
                product *= number;
            }

            Console.WriteLine($"Произведение всех элементов: {product}");


            double average = (double)sum / data.Count;
            Console.WriteLine($"Среднее всех элементов: {average}");
        }
        else
        {
            Console.WriteLine("Список пустой");
        }
    }
}