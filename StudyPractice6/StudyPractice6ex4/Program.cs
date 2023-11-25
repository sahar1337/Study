namespace StudyPractice6ex4;

public class Program
{
    public static void Main(string[] args)
    {
        int sum = 0;
        Console.Write("Введите положительное число a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите положительное число (для завершения введите отрицательное число):");
        while (true)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                break;
            }
            if (number % a == 0)
            {
                sum += number;
            }
        }
        Console.WriteLine($"Сумма чисел, делящихся на {a} нацело, равна {sum}.");
    }
}
