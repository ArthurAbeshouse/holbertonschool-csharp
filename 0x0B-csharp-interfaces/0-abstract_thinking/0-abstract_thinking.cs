using System;

/// <summary>
/// Base class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Object name
    /// </summary>
    public string name;

    /// <summary>
    /// Displays name and type of the object
    /// </summary>
    public override string ToString()
    {
        return name + " is a " + this.GetType();
    }
}