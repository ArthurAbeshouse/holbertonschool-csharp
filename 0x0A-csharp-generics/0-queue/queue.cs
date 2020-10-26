using System;
/// <summary>
/// Custom class that stores a queue
/// </summary>
public class Queue<T>
{
    /// <summary>
    /// Checks if input is queue type
    /// </summary>
    /// <returns>Queue type</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
