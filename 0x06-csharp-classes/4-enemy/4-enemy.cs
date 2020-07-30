using System;

namespace Enemies
{
    ///<summary>Represents a Zombie</summary>
    public class Zombie
    {
        ///<summary>Health field of Zombie</summary>
        private int health;
        ///<summary>Zombie name</summary>
        private string name = "(No name)";

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

        ///<summary>Gets the Zombie's health</summary>
        ///<return>The Zombie's health</return>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>
        /// Getter and setter for Zombie name
        /// </summary>
        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}
