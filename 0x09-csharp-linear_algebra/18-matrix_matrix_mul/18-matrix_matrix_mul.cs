using System;

/// <summary>
/// Class for MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns>If the matrices cannot be multiplied, it returns a matrix containing -1</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int matrix1_row = matrix1.GetLength(0);
        int matrix1_column = matrix1.GetLength(1);
        int matrix2_row = matrix2.GetLength(0);
        int matrix2_column = matrix2.GetLength(1);

        if (matrix1_column != matrix2_row)
            return new double[,] { { -1 } };

        double[,] results = new double[matrix1_row, matrix2_column];
        int i, j, k;
        for (i = 0; i < matrix1_row; i += 1)
        {
            for (j = 0; j < matrix2_column; j += 1)
            {
                for (k = 0; k < matrix1_column; k += 1)
                    results[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
        return results;
    }
}
