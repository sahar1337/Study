namespace StudyPractice5;

public class Program
{
    //ЗАДАНИЕ 5.1
    /*public static void Main(string[] args)
    {
        int[] intNumbers;
        using (StreamReader reader = new StreamReader("numsTask1.txt"))
        {
            string numbersString = reader.ReadLine();
            string[] numbers = numbersString.Split(' ');
            intNumbers = Array.ConvertAll(numbers, int.Parse);
        }
        
            int minNumber = intNumbers[0];
            int minIndex = 0;
            for (int i = 0; i < intNumbers.Length; ++i)
            {
                if (intNumbers[i] < minNumber)
                {
                    minNumber = intNumbers[i];
                    minIndex = i;
                }
            }
            
            int product = 1;
            for (int i = minIndex + 1; i < intNumbers.Length; ++i)
            {
                product *= intNumbers[i];
            }
            
        Console.WriteLine($"Произведение элементов, расположенных после минимального числа равно {product}");
    }*/
    
    //ЗАДАНИЕ 5.2
    /*public static void Main(string[] args)
    {
        double[] doubleNumbers;
        using (StreamReader reader = new StreamReader("numsTask2.txt"))
        {
            string numbersString = reader.ReadLine();
            string[] numbers = numbersString.Split(";");
            doubleNumbers = Array.ConvertAll(numbers, double.Parse);
        }
        
        for (int i = 0; i < doubleNumbers.Length; i++)
        {
            for (int j = 0; j < doubleNumbers.Length - 1; j++)
            {
                if (doubleNumbers[j] > doubleNumbers[j + 1])
                {
                    double temp = doubleNumbers[j];
                    doubleNumbers[j] = doubleNumbers[j + 1];
                    doubleNumbers[j + 1] = temp;
                }
            }
        }
        
        // Запись отсортированной последовательности чисел обратно в файл
        using (StreamWriter writer = new StreamWriter("numsTask2.txt"))
        {
            foreach (double number in doubleNumbers)
            {
                writer.Write($"{number};");
            }
        }
        Console.WriteLine("Числа были успешно отсортированы и записаны обратно в файл.");
    }*/
    
    //ЗАДАНИЕ 5.3
    /*public static void Main(string[] args)
    {
        int[] intNumbers;
        using (StreamReader reader = new StreamReader("numsTask3.txt"))
        {
            string numbersString = reader.ReadLine();
            string[] numbers = numbersString.Split(" ");
            intNumbers = Array.ConvertAll(numbers, int.Parse);
        }

        int minIndex = 0;
        for (int i = 1; i < intNumbers.Length; i++)
        {
            if (intNumbers[i] < intNumbers[minIndex])
            {
                minIndex = i;
            }
        }

        if (minIndex > 0)
        {
            int sum = 0;
            for (int i = 0; i < minIndex; ++i)
            {
                sum += intNumbers[i];
            }
            double average = (double)sum / minIndex;
            Console.WriteLine($"Среднее арифметическое элементов до минимального: {average}");
        }
        else
        {
            Console.WriteLine("Минимальный элемент находится в начале списка, невозможно вычислить среднее арифметическое.");
        }
    }*/
    
    //ЗАДАНИЕ 5.4
    /*public static void Main(string[] args)
    {
        int[] intNumbers;
        using (StreamReader reader = new StreamReader("numsTask4.txt"))
        {
            string numbersString = reader.ReadLine();
            string[] numbers = numbersString.Split(" ");
            intNumbers = Array.ConvertAll(numbers, int.Parse);
        }

        int maxNumber = intNumbers[0];
        for (int i = 1; i < intNumbers.Length; i++)
        {
            if (intNumbers[i] > maxNumber)
            {
                maxNumber = intNumbers[i];
            }
        }

        int digit = 0;
        for (int i = 0; i < intNumbers.Length; i++)
        {
            if (maxNumber - intNumbers[i] == 1)
            {
                digit = intNumbers[i];
            }
        }

        if (digit != 0)
        {
            Console.WriteLine($"Число, содержащиеся в файле и отличающееся от максимального на -1 равно {digit}");
        }
        else
        {
            Console.WriteLine("Нет числа в файле, отличающееся от максимального на -1");
        }
    }*/
    
    //ЗАДАНИЕ 5.5
    /*public static void Main(string[] args)
    {
        int[] intNumbers;
        using (StreamReader reader = new StreamReader("numsTask5.txt"))
        {
            string numbersString = reader.ReadLine();
            string[] numbers = numbersString.Split(" ");
            intNumbers = Array.ConvertAll(numbers, int.Parse);
        }

        int minIndex = 0;
        int maxIndex = 0;
        for (int i = 1; i < intNumbers.Length; i++)
        {
            if (intNumbers[i] < intNumbers[minIndex])
            {
                minIndex = i;
            }

            if (intNumbers[i] > intNumbers[maxIndex])
            {
                maxIndex = i;
            }
        }
        
        int start = 0;
        int end = 0;
        if (maxIndex > minIndex)
        {
            start = minIndex;
            end = maxIndex;
        }
        else
        {
            start = maxIndex;
            end = minIndex;
        }
        
        Console.WriteLine($"start: {start} end: {end}");
        
        int sum = 0;
        for (int i = start + 1; i < end; i++)
        {
            sum += intNumbers[i];
        }

        double average = (double)sum / (end - start - 1);

        Console.WriteLine($"Среднее арифметическое элементов между минимальным и максимальным числами: {average}");
    }*/
}