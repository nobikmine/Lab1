using ConsoleApp3;
using NUnit.Framework;

namespace TestProject3
{
    public class LogicTests
    {
        private Logic reverser;

        [SetUp]
        public void Setup()
        {
            reverser = new Logic();
        }

        [Test]
        public void ReverseWords_Normal()
        {
            Assert.That(
                reverser.ReverseWords("Hello world from CSharp"),
                Is.EqualTo("CSharp from world Hello"));
        }

        [Test]
        public void ReverseWords_WithSpaces()
        {
            Assert.That(
                reverser.ReverseWords("   single   word   "),
                Is.EqualTo("word single"));
        }

        [Test]
        public void Empty_And_NoWords()
        {
            Assert.That(reverser.ReverseWords(""), Is.EqualTo(""));
            Assert.That(reverser.HasWords(""), Is.False);
            Assert.That(reverser.HasWords("   \t  \n  "), Is.False);
        }
    }
}