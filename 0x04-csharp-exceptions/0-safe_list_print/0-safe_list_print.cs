using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int counter = 0;

        try
        {
            while (counter < n)
            {
                Console.WriteLine(myList[counter]);
                ++counter;
            }
            return counter;
        }
        catch (System.Exception)
        {
            return counter;
        }
    }
}
