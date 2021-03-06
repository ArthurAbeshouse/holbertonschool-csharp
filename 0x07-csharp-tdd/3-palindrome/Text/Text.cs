﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Text
{
    /// <summary>
    ///  Returns True if a string is a 
    ///  palindrome or False if it’s not.
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Checks if string is a palindrome
        /// </summary>
        /// <param name="s">The string</param>
        /// <returns>returns true or false</returns>
        public static bool IsPalindrome(string s)
        {
            if (s == null)
                return false;
            string lowercase = s.ToLower();
            List<char> stringcleaned = new List<char>();
            int i = 0;
            while(i < lowercase.Length)
            {
                if (Char.IsNumber(lowercase[i]) || Char.IsLetter(lowercase[i]))
                {
                    stringcleaned.Add(lowercase[i]);
                }
                i += 1;
            }
            lowercase = new string(stringcleaned.ToArray());

            char[] array = lowercase.ToCharArray();
            Array.Reverse(array);
            string reverse = new string(array);

            if (lowercase == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
