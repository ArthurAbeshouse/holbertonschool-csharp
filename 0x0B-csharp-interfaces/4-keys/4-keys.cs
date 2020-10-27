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

/// <summary>
/// Decoration class
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Decoration bool
    /// </summary>
    public bool isQuestItem;

    /// <summary>
    /// Decoration durability
    /// </summary>
    /// <value></value>
    public int durability {get; set;}

    /// <summary>
    /// Decoration constructor
    /// </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interact with item function
    /// </summary>
    public void Interact()
    {
        if (this.durability <= 0)
            Console.WriteLine("The {0} has been broken.", this.name);
        else if (this.isQuestItem)
            Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
        else
            Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
    }

    /// <summary>
    /// Function that breaks the item
    /// </summary>
    public void Break()
    {
        this.durability -= 1;
        if (this.durability > 0)
            Console.WriteLine("You hit the {0}. It cracks.", this.name);
        else if (this.durability == 0)
            Console.WriteLine("You smash the {0}. What a mess.", this.name);
        else
            Console.WriteLine("The {0} is already broken.", this.name);
    }
}

/// <summary>
/// Key class
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// Key is collected bool
    /// </summary>
    /// <value></value>
    public bool isCollected {get; set;}

    /// <summary>
    /// Key constructor
    /// </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Collects keys
    /// </summary>
    public void Collect()
    {
        if (!this.isCollected)
        {
            this.isCollected = true;
            Console.WriteLine("You pick up the {0}.", this.name);
        }
        else
        {
            Console.WriteLine("You have already picked up the {0}.", this.name);
        }
    }
}