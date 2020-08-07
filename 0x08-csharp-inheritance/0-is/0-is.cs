using System;
using System.Collections.Generic;

/// <summary>
/// method IsOfTypeInt
/// </summary>
public class Obj
{
    /// <summary>
    /// method that returns True if the object is an int, 
    /// otherwise it returns False.
    /// </summary>
    /// <param name="obj">The object</param>
    /// <returns>True if the object is an int, False if otherwise</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
