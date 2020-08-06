using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// returns the index of the first 
    /// non-repeating character of a string
    /// </summary>
    public class Str
    {
        /// <summary>
        /// checks for the first non-repeating character
        /// </summary>
        /// <param name="s">string to test</param>
        /// <returns>index of first non-repeating character
        /// or -1 if there is no non-repeating character</returns>
        public static int UniqueChar(string s)
        {
            if (s == null || s.Length == 0)
                return -1;
            
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int i = 0;
            int j = 0;
            while(i < s.Length)
            {
                if (dict.ContainsKey(s[i]))
                    ++dict[s[i]];
                else
                    dict.Add(s[i], 1);
                i += 1;
            }
            foreach (char letrs in s)
            {
                if (dict[letrs] == 1)
                    return j;
                ++j;
            }
            return -1;

        }
    }
}
