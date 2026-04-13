using ConsoleApp2;
using NUnit.Framework;
using System.IO;

namespace TestProject2
{
    public class Tests
    {
        [Test]
        public void FindFirstNum_Negative()
        {
            Assert.That(Logic.FindFirstNum(-5), Is.EqualTo(1));
        }

        [Test]
        public void FindFirstNum_Zero()
        {
            Assert.That(Logic.FindFirstNum(0), Is.EqualTo(1));
        }

        [Test]
        public void FindFirstNum_Positive()
        {
            Assert.That(Logic.FindFirstNum(9), Is.EqualTo(16));
        }

        [Test]
        public void PrintSquares_Output()
        {
            using var sw = new StringWriter();
            Console.SetOut(sw);

            Logic.PrintSquares(9);

            Assert.That(sw.ToString(), Is.EqualTo("1, 4, 9, 16" + Environment.NewLine));
        }
        [Test]
        public void TryParseInput_Invalid()
        {
            Assert.That(InputHelper.TryParseInput("hello", out _), Is.False);
        }
    }
}