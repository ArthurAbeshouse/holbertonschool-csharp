using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> new_Node = new LinkedListNode<int>(n);
        LinkedListNode<int> current = myLList.First;

        if (myLList == null)
        {
            myLList.AddFirst(new_Node);
            return new_Node;
        }
        if (current.Value > n)
        {
            myLList.AddBefore(current, new_Node);
            return new_Node;
        }
        while (current.Next != null)
        {
            if (current.Next.Value >= n)
                break;
            current = current.Next;
        }
        myLList.AddAfter(current, new_Node);
        return new_Node;
    }
}
