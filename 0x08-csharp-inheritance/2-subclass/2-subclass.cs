using System;
using System.Collections.Generic;

/// <summary>
/// method of IsInstanceOfArray
/// </summary>
public class Obj
{
    /// <summary>
    /// Returns True if the object is an instance 
    /// of a class that inherits from the specified class
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return true;
        return false;
    }
}
