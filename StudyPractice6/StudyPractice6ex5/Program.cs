namespace StudyPractice6ex5;

public class Program
{
    public static void Main(string[] args)
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
    }
}