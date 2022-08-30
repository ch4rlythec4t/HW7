using System;
class Program
{
    static double[,] CreateMatrix(int row, int column, double maxValue, double minValue)
    {
        double[,] newMatrix = new double[row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                newMatrix[i, j] = Math.Round((double)new Random().NextDouble() * maxValue - minValue, 1);
            }
        }
        return newMatrix;
    }
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
    static void Main()
    {
        Console.Write("Введите количество столбцов массива M = ");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество строк массива N = ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите минимальное значение для чисел Min = ");
        double min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите максимальное значение для чисел Max = ");
        double max = Convert.ToInt32(Console.ReadLine());

        WriteMatrix(CreateMatrix(row: M, column: N, maxValue: max, minValue: min));
    }
}