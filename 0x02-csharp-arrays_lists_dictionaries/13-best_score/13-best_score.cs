using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string results = "None";
        int value = 0;
        foreach(KeyValuePair<string, int> KeyVP in myList)
        {
            if (value <= KeyVP.Value)
            {
                value = KeyVP.Value;
                results = KeyVP.Key;
            }
        }
        return results;
    }
}