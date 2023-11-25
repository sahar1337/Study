namespace StudyPractice6ex3;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (number % 2 == 0 && number % 10 == 0)
        {
            Console.WriteLine($"Число {number} четное и кратное 10");
        }
        else if (number % 2 == 0 && number % 10 != 0)
        {
            Console.WriteLine($"Число {number} является чётным, но не кратным 10");
        }
        else
        {
            Console.WriteLine($"Число {number} не является ни чётным, ни кратным 10");
        }
    }
}