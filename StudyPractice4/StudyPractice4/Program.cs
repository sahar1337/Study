namespace StudyPractice4;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите целое положительное число n:");
        int n = int.Parse(Console.ReadLine());

        int product = 1;
        for (int i = 3; i <= n; i += 3)
        {
            product *= i;
        }
        Console.WriteLine($"Произведение натуральных чисел, кратных трём и не превышающих {n}, равно {product}");
    }
}
