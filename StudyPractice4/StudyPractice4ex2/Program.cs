namespace StudyPractice4ex2;

public class Program
{
    public static void Main(string[] args)
    {
        double sum = 0;
        using (StreamReader sr = new StreamReader("numsTask2.txt"))
        {
            string line = sr.ReadLine();
            string[] numbers = line.Split(';');
            foreach (string number in numbers)
            {
                double currentNumber = Convert.ToDouble(number);
                if (currentNumber > 0)
                {
                    sum += currentNumber;
                }
                else if (currentNumber == 0)
                {
                    break;
                }
            }
        }
        Console.WriteLine($"Сумма положительных элементов равна {sum}");
    }
}