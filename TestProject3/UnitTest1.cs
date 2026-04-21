using ConsoleApp3;
using NUnit.Framework;

namespace TestProject3
{
    public class Tests
    {
        [Test]
        public void ReverseWords_Normal()
        {
            Assert.That(
                Logic.ReverseWords("Hello world from CSharp"),
                Is.EqualTo("CSharp from world Hello"));
        }

        [Test]
        public void ReverseWords_WithExtraSpaces()
        {
            Assert.That(
                Logic.ReverseWords("    single   word   "),
                Is.EqualTo("word single"));
        }

        [Test]
        public void ReverseWords_WithTabs()
        {
            Assert.That(
                Logic.ReverseWords("one\t two\t\tthree"),
                Is.EqualTo("three two one"));
        }

        [Test]
        public void ReverseWords_EmptyOrWhitespace()
        {
            Assert.That(Logic.ReverseWords(""), Is.EqualTo(""));
            Assert.That(Logic.ReverseWords("   \t  \n  "), Is.EqualTo(""));
        }

        [Test]
        public void ReverseWords_Null()
        {
            Assert.That(Logic.ReverseWords(null), Is.EqualTo(""));
        }
    }
}