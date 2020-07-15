using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int fizz = 1; fizz <= 100; fizz++)
            {
                if (fizz % 3 == 0 && fizz % 5 == 0)
                Console.Write("FizzBuzz");
                else if (fizz % 3 == 0)
                Console.Write("Fizz");
                else if (fizz % 5 == 0)
                Console.Write("Buzz");
                else
                Console.Write("{0}", fizz);
                if (fizz < 100)
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
