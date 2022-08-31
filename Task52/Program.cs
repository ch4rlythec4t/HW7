using System;
class Program
{
    static void WriteMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static double[] Average(double[,] matrix)
    {
        double[] averageColumn = new double[matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                averageColumn[j] += Math.Round(matrix[i, j] / (matrix.GetLength(1) - 1), 2);
            }
        }
        return averageColumn;
    }
    static void Main()
    {
        double[,] newMatrix = {{1,4,7,2},
                               {5,9,2,3},
                               {8,4,2,4}};

        Console.Clear();
        WriteMatrix(newMatrix);
        Console.WriteLine("Среднее арифметическое каждого столбца:");
        Console.WriteLine(string.Join("; ", Average(newMatrix)));
    }
}