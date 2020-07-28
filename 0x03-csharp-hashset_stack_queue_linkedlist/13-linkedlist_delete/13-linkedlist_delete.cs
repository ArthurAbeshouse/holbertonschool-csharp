using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int n = 0;
        LinkedListNode<int> current = myLList.First;
        while (n < index && current.Next != null)
        {
            current = current.Next;
            ++n;
        }
        if (n == index)
            myLList.Remove(current);
    }
}
