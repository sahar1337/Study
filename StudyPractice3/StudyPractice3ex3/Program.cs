namespace StudyPractice3ex3;

using System.IO;

public class Program
{
    static int MaxArea(int[] height)
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
        string filePath = "input.txt";
        string content;
        
        using (StreamReader reader = new StreamReader(filePath))
        {
            content = reader.ReadToEnd();
        }

        string[] numbersString = content.Split( " ");
        int[] numbers = Array.ConvertAll(numbersString, int.Parse);
        
        int maxArea = MaxArea(numbers);
        
        Console.WriteLine($"Наибольшая площадь, которую можно получить: {maxArea}");
    }
}