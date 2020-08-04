using System;

namespace MyMath
{
    /// <summary>
    /// Divides all elements in a matrix
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Divides all elements in a matrix
        /// </summary>
        /// <param name="matrix">The given matrix</param>
        /// <param name="num">The number to divide</param>
        /// <returns></returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
                Console.WriteLine("Num cannot be 0");
            if (matrix == null || num == 0)
                return null;
            
            int [, ] New_Matrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            int i = 0;
            while(i < matrix.GetLength(0))
            {
                int j = 0;
                while(j < matrix.GetLength(1))
                {
                    int result = (matrix[i,j] / num);
                    New_Matrix[i, j] = result;
                    ++j;
                }
                ++i;
            }
            return New_Matrix;
        }
    }
}
