using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);
        if (aQueue.Count > 0)
            Console.WriteLine("Top item: {0}", aQueue.Peek());
        else
            Console.WriteLine("Stack is empty");

        aQueue.Enqueue(newItem);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, aQueue.Contains(search));
        while (aQueue.Contains(search))
            aQueue.Dequeue();
            
        return (aQueue);
    }
}
