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

/// <summary>
/// Interactive interface
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Calls the Interact function
    /// </summary>
    void Interact();
}

/// <summary>
/// Breakable interface
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Tracks durability
    /// </summary>
    /// <value></value>
    int durability {get; set;}
    /// <summary>
    /// Calls the Break function
    /// </summary>
    void Break();
}

/// <summary>
/// Collectable interface
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Tracks if item is collected
    /// </summary>
    bool isCollected {get; set;}
    /// <summary>
    /// Calls the Collect function
    /// </summary>
    void Collect();
}

/// <summary>
/// Inherits from all interfaces
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// Tracks durability
    /// </summary>
    public int durability {get; set;}
    
    /// <summary>
    /// Tracks if item is collected
    /// </summary>
    public bool isCollected {get; set;}
    
    /// <summary>
    /// Interact function
    /// </summary>
    public void Interact() {}

    /// <summary>
    /// Break function
    /// </summary>
    public void Break() {}

    /// <summary>
    /// Collect function
    /// </summary>
    public void Collect() {}
}