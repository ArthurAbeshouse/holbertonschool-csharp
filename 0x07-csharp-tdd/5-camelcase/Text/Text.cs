using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// CamelCase method.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines how many words are in a string. 
        /// Each word begins with a capital letter except the first word.
        /// </summary>
        /// <param name="s">The string</param>
        /// <returns>number of words in s</returns>
        public static int CamelCase(string s)
        {
            if (s == null || s.Length == 0)
                return 0;
            
            int counter = 1;
            int i = 0;
            while (i < s.Length)
            {
                if (Char.IsUpper(s[i]))
                    counter += 1;
                i += 1;
            }
            return counter;
        }
    }
}
