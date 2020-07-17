using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        SortedList<string, string> List_o_Keys = new SortedList<string, string>(myDict);

        foreach(KeyValuePair<string, string> i in List_o_Keys)
            Console.WriteLine($"{i.Key}: {i.Value}");
    }
}