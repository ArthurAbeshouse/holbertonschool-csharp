using System;

/// <summary>
/// Class for MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="angle"></param>
    /// <returns>If the matrix is of an invalid size, it returns a matrix containing -1</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] newMatrix = new double[2, 2];
        double[,] MatrixRotate = new double[,] {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
        double op;
        
        if (matrix.GetLength(0) == 2 || matrix.GetLength(1) == 2)
        {
            for (int i = 0; i < 2; i += 1)
            {
                for (int j = 0; j < 2; j += 1)
                {
                    op = 0;
                    for (int k = 0; k < 2; k += 1)
                        op = Math.Round(op + (matrix[i, k] * MatrixRotate[k, j]), 2);
                    newMatrix[i, j] = op;
                }
            }
            return newMatrix;
        }
        return new double[,] { { -1 } };
    }
}
