using System;
using System.Collections.Generic;

/// <summary>
/// method of IsInstanceOfArray
/// </summary>
public class Obj
{
    /// <summary>
    /// Returns True if the object is an instance of, 
    /// or is an instance of a class which inherits
    /// from Array.
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
