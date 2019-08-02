using System;

namespace Transpose
{
    /// <summary>
    ///  İki boyutlu bir matris'in transpozunu alan kod.
    /// </summary>

    class Program
    {
        static void transpose(int[,] mat, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(mat[j, i] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] matrix = { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } };

            transpose(matrix, 3, 3);
        }
    }
}
