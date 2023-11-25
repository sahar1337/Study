namespace StudyPractice4ex4;

public class Program
{
    public static void Main(string[] args)
    {
        int count = 0;
        int previousNumber = Int32.MinValue;
        using (StreamReader sr = new StreamReader("numsTask4.txt"))
        {
            string line = sr.ReadLine();
            string[] numbers = line.Split(' ');
            foreach (string numStr in numbers)
            {
                int currentNumber = Convert.ToInt32(numStr);
                if (currentNumber == previousNumber)
                { 
                    count++;
                }
                previousNumber = currentNumber;
            }
        }
        Console.WriteLine($"Количество одинаковых рядом стоящих чисел равно {count}");
    }
}