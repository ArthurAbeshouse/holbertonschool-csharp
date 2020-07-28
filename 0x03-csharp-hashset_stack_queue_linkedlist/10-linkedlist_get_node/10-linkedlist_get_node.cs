using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int index = 0;
        foreach (int i in myLList)
        {
            if (index == n)
                return i;
            ++index;
        }
        return 0;
    }
}
