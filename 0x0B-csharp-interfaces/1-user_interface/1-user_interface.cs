using System;

/// <summary>
/// Base class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Object name
    /// </summary>
    private string name;

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
    void Interact();
}

/// <summary>
/// Breakable interface
/// </summary>
public interface IBreakable
{
    int durability {get; set;}

    void Break();
}

/// <summary>
/// Collectable interface
/// </summary>
public interface ICollectable
{
    bool isCollected {get; set;}

    void Collect();
}

/// <summary>
/// Inherits from all interfaces
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability {get; set;}

    public bool isCollected {get; set;}

    public void Interact() {}

    public void Break() {}

    public void Collect() {}
}