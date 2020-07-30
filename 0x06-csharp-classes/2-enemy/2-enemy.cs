using System;

namespace Enemies
{
    ///<summary>Represents a Zombie</summary>
    public class Zombie
    {
        ///<summary>Health field of Zombie</summary>
        public int health;

        ///<summary>Constructor for <see cref="Zombie"/> class</summary>
        public Zombie()
        {
            health = 0;
        }
        ///<summary>Constructor for <see cref="Zombie"/> class with argument</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArithmeticException("Health must be greater than or equal to 0");
            else
                health = value;
        }

    }
}
