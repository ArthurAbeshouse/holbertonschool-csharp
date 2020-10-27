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
/// Inherits from Base and Interactive
/// </summary>
public class Door : Base, IInteractive
{
    public Door(string name = "Door")
    {
        this.name = name;
    }

    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", this.name);
    }
}