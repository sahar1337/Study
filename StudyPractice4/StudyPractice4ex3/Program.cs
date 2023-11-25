namespace StudyPractice4ex3;

public class Program
{
    public static void Main(string[] args)
    {
        int min = Int32.MaxValue;
        int max = Int32.MinValue;

        using (StreamReader sr = new StreamReader("numsTask3.txt"))
        {
            string line = sr.ReadLine();
            string[] numbers = line.Split(',');
            foreach (string number in numbers)
            {
                int currentNumber = Convert.ToInt32(number);
                {
                    if (currentNumber != 0)
                    {
                        if (currentNumber < min)
                        {
                            min = currentNumber;
                        }
                        if (currentNumber > max)
                        { 
                            max = currentNumber;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
            double ratio = (double)min / max;
            Console.WriteLine($"Отношение минимального и максимального элементов равно {ratio}");
    }
}