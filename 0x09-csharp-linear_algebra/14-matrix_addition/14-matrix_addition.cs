using System;

/// <summary>
/// Class for MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Adds two matrices
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns>The results, else -1 if not a 2D or 3D matrix or both matrices aren't the same size</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(0) < 2 && matrix1.GetLength(0) > 3 && matrix1.GetLength(1) < 2 && matrix1.GetLength(1) > 3 &&
        matrix2.GetLength(0) < 2 && matrix2.GetLength(0) > 3 && matrix2.GetLength(1) < 2 && matrix2.GetLength(1) > 3)
            return new double[,] { { -1 } };
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            return new double[,] { { -1 } };
        
        double[,] results = new double[matrix1.GetLength(0), matrix1.GetLength(0)];
        int i, j;
        for (i = 0; i < matrix1.GetLength(0); i += 1)
        {
            for (j = 0; j < matrix1.GetLength(1); j += 1)
                results[i, j] = matrix1[i, j] + matrix2[i, j];
        }
        return results;
    }
}
