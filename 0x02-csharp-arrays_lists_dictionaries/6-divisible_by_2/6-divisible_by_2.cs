using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> listresults = new List<bool>();
        foreach (int i in myList)
        {
            if (i % 2 == 0)
                listresults.Add(true);
            else
                listresults.Add(false);
        }
        return listresults;
    }
}