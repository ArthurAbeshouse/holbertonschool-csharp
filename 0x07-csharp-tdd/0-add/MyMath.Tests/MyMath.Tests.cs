using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>
    ///  MyMath.Operations tests
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Tests addition of positive integers
        /// </summary>
        [Test]
        public void AddPositive()
        {
            Assert.That(MyMath.Operations.Add(5, 5), Is.EqualTo(10));
            Assert.That(MyMath.Operations.Add(42, 52), Is.EqualTo(94));
        }
        /// <summary>
        /// Tests addition of negative integers
        /// </summary>
        [Test]
        public void Test1()
        {
            Assert.That(MyMath.Operations.Add(-6, 6), Is.EqualTo(0));
            Assert.That(MyMath.Operations.Add(-321, 429), Is.EqualTo(108));
        }
    }
}