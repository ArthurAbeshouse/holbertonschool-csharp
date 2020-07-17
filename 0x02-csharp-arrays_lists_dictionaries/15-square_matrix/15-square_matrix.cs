using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int row = myMatrix.GetLength(0);
        int column = myMatrix.GetLength(1);
        int[,] NewMatrix = new int[row, column];
        for (int a = 0; a < row; ++a)
        {
            for (int b = 0; b < column; ++b)
            {
                NewMatrix[a, b] = myMatrix[a, b] * myMatrix[a, b];
            }
        }
        return NewMatrix;
    }
}
