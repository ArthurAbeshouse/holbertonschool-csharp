using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char lower_alpha = 'a'; lower_alpha <= 'z'; lower_alpha++)
            {
                if (lower_alpha != 'q' && lower_alpha != 'e')
                Console.Write(lower_alpha);
            }
        }
    }
}
