using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 0, 1, 2, 3 };
        jaggedArray[1] = new int[] { 0, 1, 2, 3, 4, 5, 6 };
        jaggedArray[2] = new int[] { 0, 1 };
        for (int a = 0; a < jaggedArray.Length; ++a)
        {
            for (int b = 0; b < jaggedArray[a].Length; ++b)
            {
                Console.Write(jaggedArray[a][b]);
                if (b < jaggedArray[a].Length - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}