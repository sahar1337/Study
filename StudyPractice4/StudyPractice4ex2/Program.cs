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
                double Currentnumber = Convert.ToDouble(number);
                if (Currentnumber > 0)
                {
                    sum += Currentnumber;
                }
                else if (Currentnumber == 0)
                {
                    break;
                }
            }
        }
        Console.WriteLine($"Сумма положительных элементов равна {sum}");
    }
}