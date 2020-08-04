using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>
    /// MyMath.Operations tests fro matrix division
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Tests divide by zero
        /// </summary>
        [Test]
        public void DivideByZero()
        {
            int[,] testmatrix = {{2, 4}, {7, 14}};
            Assert.That(MyMath.Matrix.Divide(testmatrix, 0), Is.EqualTo(null));
        }

        /// <summary>
        /// Test for null matrix
        /// </summary>
        [Test]
        public void DivideNull()
        {
            int[,] testmatrixnull = null;
            Assert.That(MyMath.Matrix.Divide(testmatrixnull, 47), Is.EqualTo(null));
        }

        /// <summary>
        /// Test for positive integer matrix division
        /// </summary>
        [Test]
        public void DividePos()
        {
            int[,] testmatrixpos = {{6, 8}, {12, 14}};
            int[,] results = {{3, 4}, {6, 7}};
            Assert.That(MyMath.Matrix.Divide(testmatrixpos, 2), Is.EqualTo(results));
        }
    }
}