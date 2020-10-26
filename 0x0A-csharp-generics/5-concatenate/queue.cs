using System;
/// <summary>
/// Custom class that stores a queue
/// </summary>
class Queue<T>
{
    public class Node
    {
        public T value = default(T);
        public Node next = null;

        public Node(T input)
        {
            value = input;
        }
    }

    public Node head;
    public Node tail;
    public int count;

    /// <summary>
    /// Adds a new node at the end
    /// </summary>
    public void Enqueue(T value)
    {
        Node node = new Node(value);

        if (head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }
        count += 1;
    }

    /// <summary>
    /// Removes an element from the head of the queue
    /// </summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        T value = head.value;
        head = head.next;
        count -= 1;
        return value;
    }

    /// <summary>
    /// Returns the value of the first node
    /// </summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;
    }

    /// <summary>
    /// Prints all the nodes in the queue
    /// </summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        while (head != null)
        {
            Console.WriteLine(head.value);
            head = head.next;
        }
    }

    /// <summary>
    /// Concatenates all the values in a queue
    /// </summary>
    public String Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        else if (CheckType() == typeof(char) || CheckType() == typeof(string))
        {
            string result = "";
            while (head != null)
            {
                result += head.value;
                if (head.next != null && CheckType() == typeof(string))
                    result += " ";
                head = head.next;
            }
            return result;
        }
        Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
        return null;
    }

    /// <summary>
    /// Checks if input is queue type
    /// </summary>
    /// <returns>Queue type</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Returns the number of elements in the queue
    /// </summary>
    public int Count()
    {
        return count;
    }
}
