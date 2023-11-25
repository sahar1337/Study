namespace StudyPractice4ex5;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите координату a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координату b:");
        double b = Convert.ToDouble(Console.ReadLine());
        
        if (a >= -1 && a <= 3 && b >= -2 && b <= 4)
        {
            Console.WriteLine($"Точка с координатами ({a},{b}) принадлежит заштрихованной области");
        }
        else
        {
            Console.WriteLine($"Точка с координатами ({a},{b}) не принадлежит заштрихованной области");
        }
    }
}