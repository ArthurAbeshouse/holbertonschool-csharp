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

    /// <summary>
    /// Delegate
    /// </summary>
    public delegate void CalculateHealth(float amount);

    /// <summary>
    /// Handles damges
    /// </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
        {
            Console.WriteLine("{0} takes 0 damage!", this.name);
            damage = 0f;
        }
        else
        {
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
            ValidateHP(this.hp - damage);
        }
    }

    /// <summary>
    /// Handles healing
    /// </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0f)
        {
            Console.WriteLine("{0} heals 0 HP!", this.name);
            heal = 0f;
        }
        else
        {
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
            ValidateHP(this.hp + heal);
        }
    }

    /// <summary>
    /// Validates player's HP
    /// </summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp >= maxHp)
            this.hp = maxHp;
        else
            this.hp = newHp;
    }

    /// <summary>
    /// Apply Modifier
    /// </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue * 0.5f;
        else if (modifier == Modifier.Strong)
            return baseValue * 1.5f;
        else
            return baseValue;
    }
}

/// <summary>
/// Modifier
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Weak modifier is 0.5
    /// </summary>
    Weak,
    /// <summary>
    /// Base modifier is 1
    /// </summary>
    Base,
    /// <summary>
    /// Strong modifier is 1.5
    /// </summary>
    Strong
}
/// <summary>
/// Determines strength of the attack
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);