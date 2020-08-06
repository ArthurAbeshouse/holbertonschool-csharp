using NUnit.Framework;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void TestTrue([Values("girafarig", "")] string str)
        {
            Assert.That(Text.Str.IsPalindrome(str), Is.True);
        }

        [Test]
        public void TestFalse([Values("giraffe")] string BOOB)
        {
            bool IsPalindrome = Str.IsPalindrome(BOOB);
            Assert.That(IsPalindrome == false);
        }
    }
}