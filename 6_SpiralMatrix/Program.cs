using System;

namespace Spirala
{
    class Program
    {
        //Se citeste/genereaza un vector care conține M * N elemente, construiți o matrice M x N în spirală.
        private static void PrintMatrix(int[,] matrix, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        private static int[,] GenerateMatrix(int rows, int columns)
        {
            int valueOfPosition = 1, startRow = 0, startColumn = 0;
            int[,] matrix = new int[rows, columns];

            while (startRow < rows && startColumn < columns)
            {
                //Partea superioara
                for (int i = startColumn; i < columns; ++i)
                {
                    matrix[startRow, i] = valueOfPosition++;
                }
                startRow++;
                // ex:  1 2 3 4 5
                //      0 0 0 0 0
                //      0 0 0 0 0
                //      0 0 0 0 0

                for (int i = startRow; i < rows; ++i)
                {
                    matrix[i, columns - 1] = valueOfPosition++;
                }
                columns--;
                // ex:  1 2 3 4 5
                //      0 0 0 0 6
                //      0 0 0 0 7
                //      0 0 0 0 8

                if (startRow < rows)
                {
                    for (int i = columns - 1; i >= startColumn; --i)
                    {
                        matrix[rows - 1, i] = valueOfPosition++;
                    }
                    rows--;
                }
                // ex:  1 2 3 4 5
                //      0 0 0 0 6
                //      0 0 0 0 7
                //      12 11 10 9 8

                if (startColumn < columns)
                {
                    for (int i = rows - 1; i >= startRow; --i)
                    {
                        matrix[i, startColumn] = valueOfPosition++;
                    }
                    startColumn++;
                }
                // ex:  1 2 3 4 5
                //      14 0 0 0 6
                //      13 0 0 0 7
                //      12 11 10 9 8
            }
            return matrix;
        }
        static void Main(string[] args)
        {
            Console.Write("M = ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = GenerateMatrix(m, n);
            PrintMatrix(matrix, m, n);
            Console.ReadKey();
        }
    }
}