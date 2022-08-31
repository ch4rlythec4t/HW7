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
    static void SearchPositionElement(double[,] matrix, int position)
    {
        int positionRow = position / 10 - 1;
        int positionColumn = position % 10 - 1;

        if ((positionRow < matrix.GetLength(0)) && (positionColumn < matrix.GetLength(1))) Console.WriteLine(matrix[positionRow, positionColumn]);
        else Console.WriteLine("Такого числа в массиве нет");
    }
    static void Main()
    {
        double[,] newMatrix = {{1,4,7,2},
                               {5,9,2,3},
                               {8,4,2,4}};
      
        Console.Clear();
        WriteMatrix(newMatrix);   
        Console.Write("Введите позицию искомого элемента: ");
        int position = Convert.ToInt32(Console.ReadLine());

        SearchPositionElement(matrix: newMatrix, position: position);
    }
}