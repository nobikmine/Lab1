using ConsoleApp2;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_FindFirstNum_WithNegativeNumber()
        {
            int n = -5;
            List<int> expectedRow = new List<int> { 1 };
            int expectedFirstNum = 1;
            var result = Logic.FindFirstNum(n);
            Assert.That(result.row, Is.EqualTo(expectedRow));
            Assert.That(result.FirstNum, Is.EqualTo(expectedFirstNum));
        }

        [Test]
        public void Test_FindFirstNum_WithNEquals9()
        {
            int n = 9;
            List<int> expectedRow = new List<int> { 1, 4, 9, 16 };
            int expectedFirstNum = 16;
            var result = Logic.FindFirstNum(n);
            Assert.That(result.row, Is.EqualTo(expectedRow));
            Assert.That(result.FirstNum, Is.EqualTo(expectedFirstNum));
        }

        [Test]
        public void Test_FindFirstNum_WithNullOrEmptyString_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => int.Parse(null));
            Assert.Throws<FormatException>(() => int.Parse(""));
        }

        [Test]
        public void Test_FindFirstNum_WithNEquals0()
        {
            int n = 0;
            List<int> expectedRow = new List<int> { 1 };
            int expectedFirstNum = 1;
            var result = Logic.FindFirstNum(n);
            Assert.That(result.row, Is.EqualTo(expectedRow));
            Assert.That(result.FirstNum, Is.EqualTo(expectedFirstNum));
        }
    }
    [TestFixture]
    public class InputTests
    {
        [Test]
        public void Test_TryParseInput_WithNonNumericString()
        {
            string input = "hello";
            int n;
            bool result = InputHelper.TryParseInput(input, out n);

            Assert.That(result, Is.False);
        }
    }
}