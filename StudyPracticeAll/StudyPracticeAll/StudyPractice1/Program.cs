namespace StudyPractice1;

public class Program
{
    //ЗАДАНИЕ 1.1
        /*public static void Main(string[] args)
    {
        Random rnd = new Random();

        const int N = 10;
        int[] data = new int[N];
        for (int i = 0; i < data.Length; ++i)
        {
            data[i] = rnd.Next(50);
        }

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < data.Length; ++i)
        {
            Console.Write($"{data[i]} ");
        }

        int minNumber = data[0];
        int minIndex = 0;
        for (int i = 1; i < data.Length; ++i)
        {
            if (data[i] < minNumber)
            {
                minNumber = data[i];
                minIndex = i;
            }
        }

        Console.WriteLine($"\nМинимальное число {minNumber} c индексом {minIndex}");
    }*/
        
        //ЗАДАНИЕ 1.2
        /*public static void Main(string[] args)
    {
        List<int> data = new List<int>();

        Console.WriteLine("Введите числа (0 для завершения списка): ");

        int input = 1;

        while (input != 0)
        {
            input = Convert.ToInt32(Console.ReadLine());
            if (input != 0)
            {
                data.Add(input);
            }
        }

        if (data.Count > 0)
        {
            int sum = 0;
            foreach (int number in data)
            {
                sum += number;
            }

            Console.WriteLine($"Сумма всех элементов: {sum}");

            int product = 1;
            foreach (int number in data)
            {
                product *= number;
            }

            Console.WriteLine($"Произведение всех элементов: {product}");


            double average = (double)sum / data.Count;
            Console.WriteLine($"Среднее всех элементов: {average}");
        }
        else
        {
            Console.WriteLine("Список пустой");
        }
    }*/
        
        //ЗАДАНИЕ 1.3
        /*public static void Main(string[] args)
    {
        List<string> data = new List<string>();

        Console.WriteLine("Введите элементы списка (для завершения введите пустую строку):");

        string input = Console.ReadLine();

        while (!string.IsNullOrEmpty(input))
        {
            data.Add(input);
            input = Console.ReadLine();
        }

        if (data.Count > 0)
        {
            string shortest = data[0];
            string longest = data[0];

            foreach (string line in data)
            {
                if (line.Length < shortest.Length)
                {
                    shortest = line;
                }
                if (line.Length > longest.Length)
                {
                    longest = line;
                }
            }

            Console.WriteLine($"Самая короткая строка: {shortest}");
            Console.WriteLine($"Самый длинная строка: {longest}");
        }
        else
        {
            Console.WriteLine("Список пуст");
        }
    }*/
        
        //ЗАДАНИЕ 1.4
        /*public static void Main(string[] args)
        {
            int start = 0, end = 0;
            Console.WriteLine("Введите начало диапазона:");
            start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конец диапазона:");
            end = Convert.ToInt32(Console.ReadLine());

            int[] data = GenerateRandomArray(start, end);
        
            for (int i = 0; i < data.Length; ++i)
            {
                Console.Write($"{data[i]} ");
            }
        }
    
        static int[] GenerateRandomArray(int start, int end)
        {
            const int N = 10;
            int[] data = new int[N];
            Random rnd = new Random();

            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = rnd.Next(start, end + 1);
            }
            return data;
        }*/
        
        //ЗАДАНИЕ 1.5
        /*public static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string line = Console.ReadLine();
        
            string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; ++i)
            {
                Console.WriteLine($"words[{i}] = {words[i]}");
            }
        
            int wordsCount = words.Length;
            Console.WriteLine($"Количество слов в ведённой строке: {wordsCount}");

            List<string> wordList = new List<string>(words);
            wordList.Insert(0, "Start");
            wordList.Add("End");
        
            Console.Write("Изменённая строка: ");
            foreach (string word in wordList)
            {
                Console.Write($"{word} ");
            }
        }*/
}