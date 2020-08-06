using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    /// <summary>
    /// Returns the max integer in a list of integers.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Returns the max integer in a list of integers.
        /// </summary>
        /// <param name="nums">The list of integers</param>
        /// <returns>The max integer in the list</returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
            {
                return (0);
            }
            return (nums.Max());
        }
    }
}
