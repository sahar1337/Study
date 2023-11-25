namespace StudyPractice5ex2;

public class Program
{
    public static void Main(string[] args)
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
    }
}