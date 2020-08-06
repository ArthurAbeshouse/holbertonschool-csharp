using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void emptyString()
        {
          string str = "";
          int i = Str.CamelCase(str);

          Assert.AreEqual(0, i);
            
        }

        [Test]
        public void NullTest()
        {
          string str = null;
          int i = Str.CamelCase(str);

          Assert.AreEqual(0, i);
        }

        [Test]
        public void TestForOneWord()
        {
          string str = "dromedary";
          int i = Str.CamelCase(str);

          Assert.AreEqual(1, i);
        }
    }
}