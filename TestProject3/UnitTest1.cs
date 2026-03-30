using ConsoleApp3;
using NUnit.Framework;
using System;

namespace TestProject3
{
    public class LogicTests
    {
        private Logic _reverser;

        [SetUp]
        public void Setup()
        {
            _reverser = new Logic();
        }

        [Test]
        public void Test_ReverseWords_Normal()
        {
            string input = "Hello world from CSharp";
            string expected = "CSharp from world Hello";
            string actual = _reverser.ReverseWords(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_ReverseWords_Single()
        {
            string input = "   single   word   ";
            string expected = "word single";
            string actual = _reverser.ReverseWords(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_ReverseWords_Empty()
        {
            string input = "";
            string actualReverse = _reverser.ReverseWords(input);
            Assert.That(actualReverse, Is.EqualTo(""));
            bool actualHasWordsEmpty = _reverser.HasWords(input);
            Assert.That(actualHasWordsEmpty, Is.False);
            string inputNoWords = "   \t  \n  ";
            bool actualHasWordsSpaces = _reverser.HasWords(inputNoWords);
            Assert.That(actualHasWordsSpaces, Is.False);
        }
    }
}
