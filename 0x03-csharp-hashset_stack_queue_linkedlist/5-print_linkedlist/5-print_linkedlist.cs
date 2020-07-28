using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
       LinkedList<int> new_list = new LinkedList<int>();

       for (int n = 0; n < size; ++n)
       {
           new_list.AddLast(n);
           Console.WriteLine(n);
       }

       return new_list;
    }
}
