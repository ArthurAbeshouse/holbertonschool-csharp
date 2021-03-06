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
        public void TestFalse([Values("giraffe", null)] string teststr)
        {
            bool IsPalindrome = Str.IsPalindrome(teststr);
            Assert.That(IsPalindrome == false);
        }
    }
}