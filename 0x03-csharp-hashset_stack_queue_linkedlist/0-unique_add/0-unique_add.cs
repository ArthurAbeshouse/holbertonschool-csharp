using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> unique_ints = new HashSet<int>();
        int sum = 0;
        foreach (int i in myList)
            unique_ints.Add(i);
        foreach (int j in unique_ints)
            sum += j;
        return sum;
    }
}
