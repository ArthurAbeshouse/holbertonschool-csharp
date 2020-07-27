using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        HashSet<int> unique_ints = new HashSet<int>();
        foreach (int i in myList)
            unique_ints.Add(i);
        foreach (int j in unique_ints)
            sum += j;
        return sum;
    }
}
