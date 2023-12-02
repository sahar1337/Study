namespace StudyPractice3;

using System.IO;

public class Program
{
    //ЗАДАНИЕ 3.1
    /*public static void Main(string[] args)
    {
        Console.WriteLine("Введите числа, разделяя их пробелом:");
        string chosenNumbersLine = Console.ReadLine();
        string[] chosenNumbersStr = chosenNumbersLine.Split(' ');
        int[] chosenNumbers = Array.ConvertAll(chosenNumbersStr, int.Parse);

        Console.WriteLine("Введите количество билетов:");
        int n = int.Parse(Console.ReadLine());

        using (StreamWriter file = new StreamWriter("input.txt"))
        {
            file.WriteLine(chosenNumbersLine);
            file.WriteLine(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите числа на билете {i + 1}:");
                string ticketNumbersLine = Console.ReadLine();
                file.WriteLine(ticketNumbersLine);
            }
        }

        using (StreamReader sr = new StreamReader("input.txt"))
        using (StreamWriter sw = new StreamWriter("output.txt"))
        {
            sr.ReadLine();
            sr.ReadLine();

            for (int i = 0; i < n; i++)
            {
                string ticketNumbersLine = sr.ReadLine();
                string[] ticketNumbersStr = ticketNumbersLine.Split(' ');
                int[] ticketNumbers = Array.ConvertAll(ticketNumbersStr, int.Parse);
                int count = 0;
                for (int j = 0; j < ticketNumbers.Length; j++)
                {
                    if (Array.IndexOf(chosenNumbers, ticketNumbers[j]) != -1)
                    {
                        count++;
                    }
                }
                
                if (count >= 3)
                {
                    sw.WriteLine("Lucky");
                }
                else
                {
                    sw.WriteLine("Unlucky");
                }
            }
        }
    }*/
    
    //ЗАДАНИЕ 3.2
    /*public static void Main(string[] args)
    {
        string filePath = "nums.txt";
        
        string content;
        using (StreamReader reader = new StreamReader(filePath))
        {
            content = reader.ReadToEnd();
        }
        
        string[] numbersString = content.Split(' ');
        int[] numbers = Array.ConvertAll(numbersString, int.Parse);
        
        string result = "";
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                result += number + " ";
            }
        }
        
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.Write(result); // Записываем отфильтрованные нечетные числа обратно в файл
        }
    }*/
    
    //ЗАДАНИЕ 3.3
    /*static int MaxArea(int[] height)
    {
        int maxArea = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int currentHeight;
            if (height[left] < height[right])
            {
                currentHeight = height[left];
            }
            else
            {
                currentHeight = height[right];
            }
            int currentArea = (right - left) * currentHeight;

            if (currentArea > maxArea)
            {
                maxArea = currentArea;
            }

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }

    public static void Main(string[] args)
    {
        string filePath = "input2.txt";
        string content;
        
        using (StreamReader reader = new StreamReader(filePath))
        {
            content = reader.ReadToEnd();
        }

        string[] numbersString = content.Split( " ");
        int[] numbers = Array.ConvertAll(numbersString, int.Parse);
        
        int maxArea = MaxArea(numbers);
        
        Console.WriteLine($"Наибольшая площадь, которую можно получить: {maxArea}");
    }*/
    
}