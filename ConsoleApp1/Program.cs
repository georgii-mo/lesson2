using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

        SortMatrix(matrix);

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result.Append(matrix[i, j].ToString("D") + " ");
            }
            result.AppendLine();
        }

        Console.WriteLine(result.ToString());
    }

    static void SortMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[] temp = new int[rows * cols];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                temp[index++] = matrix[i, j];
            }
        }

        Array.Sort(temp);

        index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = temp[index++];
            }
        }
    }
}
