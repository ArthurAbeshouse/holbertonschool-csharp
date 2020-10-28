using System;

/// <summary>
/// Creates a public Player class
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>
    /// Player Constructor
    /// </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0f)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>
    /// Display current health
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }
}
