using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int [] array_of_nums = new int[size];
        for (int i = 0; i < size; i++)
        {
            array_of_nums[i] = i;
            if (i > 0)
                Console.Write(" ");
            Console.Write(i);
        }
        Console.WriteLine();
        return array_of_nums;
    }
}
