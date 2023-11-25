namespace StudyPractice5;

public class Program
{
    public static void Main(string[] args)
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
    } 
}
