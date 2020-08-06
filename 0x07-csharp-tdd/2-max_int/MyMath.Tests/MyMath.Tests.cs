using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    /// <summary>
    /// Tests for Max()
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Checks for an empty list
        /// </summary>
        [Test]
        public void EmptyList()
        {
            List<int> emtlist = new List<int>() {};
            Assert.That(MyMath.Operations.Max(emtlist), Is.EqualTo(0));
        }

        /// <summary>
        /// Checks for null
        /// </summary>
        [Test]
        public void NullList()
        {
            List<int> nulllist = null;
            Assert.AreEqual(MyMath.Operations.Max(nulllist), 0);
        }

        /// <summary>
        /// Checks for the maximum positive int
        /// </summary>
        [Test]
        public void MPList()
        {
            List<int> mplist = new List<int>() {0, 1, 2, 3, 4, 5};
            Assert.That(MyMath.Operations.Max(mplist), Is.EqualTo(5));
        }
    }
}