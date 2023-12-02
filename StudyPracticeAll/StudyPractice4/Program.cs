namespace StudyPractice4;

using System.IO;

public class Program
{
    //ЗАДАНИЕ 4.1
    /*public static void Main(string[] args)
    {
        Console.WriteLine("Введите целое положительное число n:");
        int n = int.Parse(Console.ReadLine());

        int product = 1;
        for (int i = 3; i <= n; i += 3)
        {
            product *= i;
        }
        Console.WriteLine($"Произведение натуральных чисел, кратных трём и не превышающих {n}, равно {product}");
    }*/
    
    //ЗАДАНИЕ 4.2
    /*public static void Main(string[] args)
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
    }*/
    
    //ЗАДАНИЕ 4.3
    /*public static void Main(string[] args)
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
    }*/
    
    //ЗАДАНИЕ 4.4
    /*public static void Main(string[] args)
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
    }*/
    
    //ЗАДАНИЕ 4.5
    /*public static void Main(string[] args)
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
    }*/
    
    //ЗАДАНИЕ 4.6
    /*public static void Main(string[] args)
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
    }*/
}