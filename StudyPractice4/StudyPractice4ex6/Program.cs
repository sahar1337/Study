namespace StudyPractice4ex6;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите точку a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите точку b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        double x1 = 0, y1 = 2;
        double x2 = -2, y2 = -3;
        double x3 = 2, y3 = -3;
        
        double d1 = (x1 - a) * (y2 - y1) - (x2 - x1) * (y1 - b);
        double d2 = (x2 - a) * (y3 - y2) - (x3 - x2) * (y2 - b);
        double d3 = (x3 - a) * (y1 - y3) - (x1 - x3) * (y3 - b);
        
        if ((d1 >= 0 && d2 >= 0 && d3 >= 0) || (d1 <= 0 && d2 <= 0 && d3 <= 0))
        {
            Console.WriteLine($"Точка с координатами ({a};{b}) принадлежит заштрихованной области");
        }
        else
        {
            Console.WriteLine($"Точка с координатами ({a};{b}) не принадлежит заштрихованной области");
        }
    }
}