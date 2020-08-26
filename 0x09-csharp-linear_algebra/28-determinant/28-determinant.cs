using System;

/// <summary>
/// Class for MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Calculates the determinant of a matrix.
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns>If the matrix is not 2D or 3D, it returns -1</returns>
    public static double Determinant(double[,] matrix)
    {
        int matrix_row = matrix.GetLength(0);
        int matrix_column = matrix.GetLength(1);

        if (matrix_row != matrix_column)
            return -1;
        
        if (matrix_row == 2)
            return Math.Round((matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]), 2);

        if (matrix_row == 3)
        {
            double a = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
            double b = matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
            double c = matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

            return Math.Round((a - b + c), 2);
        }
        return -1;

    }
}
