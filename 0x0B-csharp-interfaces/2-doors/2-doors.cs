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
/// Inherits from Base and Interactive
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Door constructor
    /// </summary>
    /// <param name="name"></param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Interact function
    /// </summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", this.name);
    }
}