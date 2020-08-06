using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void NullTest()
        {
            Assert.AreEqual(Text.Str.UniqueChar(null), -1);
        }

        [Test]
        public void UniqueChars()
        {
            Assert.AreEqual(Text.Str.UniqueChar("raccoon"), 0);
        }
    }
}