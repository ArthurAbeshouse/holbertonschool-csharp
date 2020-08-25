using System;

/// <summary>
/// Class for MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix and a scalar
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="scalar"></param>
    /// <returns>The results, else -1 if not a 2D or 3D matrix</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if ((matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3) || (matrix.GetLength(1) != 2 && matrix.GetLength(1) != 3))
            return new double[,] { { -1 } };

        int i, j;
        for (i = 0; i < matrix.GetLength(0); i += 1)
        {
            for (j = 0; j < matrix.GetLength(1); j += 1)
                matrix[i, j] *= scalar;
        }
        return matrix;
    }
}
