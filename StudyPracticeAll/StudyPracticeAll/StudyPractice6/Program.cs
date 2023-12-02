namespace StudyPractice6;

using System.Collections.Generic;

public class Program
{
    //ЗАДАНИЕ 6.1
    /*public static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader("numsTask1.txt"))
        {
            string line = reader.ReadLine();
            string[] words = line.Split(" ");
            
            Console.WriteLine("Строка со словами нечётной длины:");
            foreach (string word in words)
            {
                if (word.Length % 2 != 0)
                {
                    Console.Write($"{word} ");
                }
            }
        }
    }*/
    
    //ЗАДАНИЕ 6.2
    /* public static void Main(string[] args)
    {
        string[] words;
        using (StreamReader reader = new StreamReader("numsTask2.txt"))
        {
            string content = reader.ReadToEnd();
            words = content.Split("\r\n");
        }
        foreach (var word in words)
        {
            Console.Write(word + " ");
        }
    }*/
    
    //ЗАДАНИЕ 6.3
    /*public static void Main(string[] args)
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
    }*/
    
    //ЗАДАНИЕ 6.4
    /*public static void Main(string[] args)
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
    }*/
    
    //ЗАДАНИЕ 6.5
    /*public static void Main(string[] args)
    {
        Random rand = new Random();

        Console.Write("Введите количество строк: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = rand.Next(0, 2);
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        
        int[] newColumn = new int[n];
        for (int i = 0; i < n; i++)
        {
            int countOnes = 0;
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 1)
                {
                    countOnes++;
                }
            }
            
            if (countOnes % 2 == 0)
            {
                newColumn[i] = 0;
            }
            else
            {
                newColumn[i] = 1;
            }
        }

        // Увеличиваем размер матрицы и добавляем новый столбец
        int[,] updatedMatrix = new int[n, m + 1];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                updatedMatrix[i, j] = matrix[i, j];
            }
            updatedMatrix[i, m] = newColumn[i];
        }
        
        Console.WriteLine("Измененная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m + 1; j++)
            {
                Console.Write(updatedMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }*/
    
    //ЗАДАНИЕ 6.6
    /*public static void Main(string[] args)
    {
        Random random = new Random();
        int arrayLength = random.Next(5, 11);

        double[] originalArray = new double[arrayLength];

        
        for (int i = 0; i < originalArray.Length; i++)
        {
            originalArray[i] = random.NextDouble() * 20 - 10;
        }

        List<double> positiveNumbers = new List<double>();
        List<double> negativeNumbers = new List<double>();

        
        foreach (double number in originalArray)
        {
            if (number > 0)
            {
                positiveNumbers.Add(number);
            }
            else if (number < 0)
            {
                negativeNumbers.Add(number);
            }
        }
        
        double[] positiveArray = positiveNumbers.ToArray();
        double[] negativeArray = negativeNumbers.ToArray();
        
        Console.WriteLine("Исходный массив:");
        foreach (double number in originalArray)
        {
            Console.WriteLine(Math.Round(number, 2));
        }

        Console.WriteLine("Массив положительных чисел:");
        foreach (double number in positiveArray)
        {
            Console.WriteLine(Math.Round(number, 2));
        }

        Console.WriteLine("Массив отрицательных чисел:");
        foreach (double number in negativeArray)
        {
            Console.WriteLine(Math.Round(number, 2));
        }
    }*/
}