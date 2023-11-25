namespace StudyPractice5ex5;

public class Program
{
    public static void Main(string[] args)
    {
        int[] intNumbers;
        using (StreamReader reader = new StreamReader("numsTask5.txt"))
        {
            string numbersString = reader.ReadLine();
            string[] numbers = numbersString.Split(" ");
            intNumbers = Array.ConvertAll(numbers, int.Parse);
        }

        int minIndex = 0;
        int maxIndex = 0;
        for (int i = 1; i < intNumbers.Length; i++)
        {
            if (intNumbers[i] < intNumbers[minIndex])
            {
                minIndex = i;
            }

            if (intNumbers[i] > intNumbers[maxIndex])
            {
                maxIndex = i;
            }
        }
        
        int start = 0;
        int end = 0;
        if (maxIndex > minIndex)
        {
            start = minIndex;
            end = maxIndex;
        }
        else
        {
            start = maxIndex;
            end = minIndex;
        }
        
        Console.WriteLine($"start: {start} end: {end}");
        
        int sum = 0;
        for (int i = start + 1; i < end; i++)
        {
            sum += intNumbers[i];
        }

        double average = (double)sum / (end - start - 1);

        Console.WriteLine($"Среднее арифметическое элементов между минимальным и максимальным числами: {average}");
    }
}