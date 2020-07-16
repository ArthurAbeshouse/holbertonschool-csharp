using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newdict = new Dictionary<string, int>();
        newdict = myDict.ToDictionary(elem => elem.Key, elem => elem.Value * 2);
        return newdict;
    }
}