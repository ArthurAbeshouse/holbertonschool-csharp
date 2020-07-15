using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        for (int i = 1; i <= length; i++)
        {
            for (int j = 2; j <= i; j++)
            {
                Console.Write(" ");
            }
            Console.Write("\\");
            Console.WriteLine();
        }
        if (length < 1)
        Console.WriteLine();
    }
}

