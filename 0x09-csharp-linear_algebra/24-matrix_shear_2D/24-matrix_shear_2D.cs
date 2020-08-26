using System;

/// <summary>
/// Class for MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="direction"></param>
    /// <param name="factor"></param>
    /// <returns></returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) != 2 && matrix.GetLength(1) != 2)
            return new double[,] { { -1 } };

        double[,] newMatrix = new double[2, 2];

        if (direction == 'x' || direction == 'y')
        {
            if (direction == 'x')
            {
                newMatrix[0, 0] = matrix[0, 0] + factor * matrix[0, 1];
                newMatrix[0, 1] = matrix[0, 1];
                newMatrix[1, 0] = matrix[1, 0] + factor * matrix[1, 1];
                newMatrix[1, 1] = matrix[1, 1];

                return newMatrix;
            }
            else
            {
                newMatrix[0, 0] = matrix[0, 0];
                newMatrix[0, 1] = matrix[0, 1] * factor + matrix[0, 0];
                newMatrix[1, 0] = matrix[1, 0];
                newMatrix[1, 1] = matrix[1, 1] * factor + matrix[1, 0];

                return newMatrix;
            }
        }
        return new double[,] { { -1 } };
    }
}
