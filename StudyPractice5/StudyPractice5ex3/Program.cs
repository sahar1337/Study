namespace StudyPractice5ex3;

public class Program
{
    public static void Main(string[] args)
    {
        int[] intNumbers;
        using (StreamReader reader = new StreamReader("numsTask3.txt"))
        {
            string numbersString = reader.ReadLine();
            string[] numbers = numbersString.Split(" ");
            intNumbers = Array.ConvertAll(numbers, int.Parse);
        }

        int minIndex = 0;
        for (int i = 1; i < intNumbers.Length; i++)
        {
            if (intNumbers[i] < intNumbers[minIndex])
            {
                minIndex = i;
            }
        }

        if (minIndex > 0)
        {
            int sum = 0;
            for (int i = 0; i < minIndex; ++i)
            {
                sum += intNumbers[i];
            }
            double average = (double)sum / minIndex;
            Console.WriteLine($"Среднее арифметическое элементов до минимального: {average}");
        }
        else
        {
            Console.WriteLine("Минимальный элемент находится в начале списка, невозможно вычислить среднее арифметическое.");
        }
    }
}