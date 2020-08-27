using System;

/// <summary>
/// Class for MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Calculates the inverse of a 2D matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns>The results, but, if the matrix is 2D or not invertible it will return -1</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        int matrix_row = matrix.GetLength(0);
        int matrix_column = matrix.GetLength(1);
        double [,] err = new double[,] { { -1 } };

        if (matrix == null || matrix_row != 2 || matrix_column != 2)
            return err;

        double[,] tra = new double[2, 2];

        tra[0, 0] = matrix[1, 1];
        tra[0, 1] = -1 * matrix[0, 1];
        tra[1, 0] = -1 * matrix[1, 0];
        tra[1, 1] = matrix[0, 0];

        double deter = Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);

        if (deter == 0)
            return err;
        
        double[,] inverse = new double[2, 2];

        for (int i = 0; i < 2; i += 1)
        {
            for (int j = 0; j < 2; j += 1)
                inverse[i, j] = Math.Round((1 / deter) * tra[i, j], 2);
        }
        return inverse;
    }
}
