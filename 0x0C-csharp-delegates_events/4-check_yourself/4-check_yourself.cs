using System;

/// <summary>
/// Creates a public Player class
/// </summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;

    /// <summary>
    /// Handles events
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

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
        this.status = $"{this.name} is ready to go!";
        this.HPCheck += CheckStatus;
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
        HPCheck(this, new CurrentHPArgs(this.hp));
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

    /// <summary>
    /// Checks player's current status
    /// </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHP == this.maxHp)
            this.status = $"{this.name} is in perfect health!";
        else if (e.currentHP >= (this.maxHp * 0.5f) && e.currentHP < this.maxHp)
            this.status = $"{this.name} is doing well!";
        else if (e.currentHP >= (this.maxHp * 0.25f) && e.currentHP < (this.maxHp * 0.5f))
            this.status = $"{this.name} isn't doing too great...";
        else if (e.currentHP > 0f && e.currentHP < (this.maxHp * 0.25f))
            status = $"{this.name} needs help!";
        else
            this.status = $"{this.name} is knocked out!";
        Console.WriteLine(this.status);
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

/// <summary>
/// Current HP ARgs
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// Current health
    /// </summary>
    public float currentHP;

    /// <summary>
    /// Set current HP
    /// </summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHP = newHp;
    }
}