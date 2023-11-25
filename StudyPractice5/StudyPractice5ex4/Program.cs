namespace StudyPractice5ex4;

public class Program
{
    public static void Main(string[] args)
    {
        int[] intNumbers;
        using (StreamReader reader = new StreamReader("numsTask4.txt"))
        {
            string numbersString = reader.ReadLine();
            string[] numbers = numbersString.Split(" ");
            intNumbers = Array.ConvertAll(numbers, int.Parse);
        }

        int maxNumber = intNumbers[0];
        for (int i = 1; i < intNumbers.Length; i++)
        {
            if (intNumbers[i] > maxNumber)
            {
                maxNumber = intNumbers[i];
            }
        }

        int digit = 0;
        for (int i = 0; i < intNumbers.Length; i++)
        {
            if (maxNumber - intNumbers[i] == 1)
            {
                digit = intNumbers[i];
            }
        }

        if (digit != 0)
        {
            Console.WriteLine($"Число, отличающееся от максимального на -1 равно {digit}");
        }
        else
        {
            Console.WriteLine("Нет числа, отличающееся от максимального на -1");
        }
    }
}