using ConsoleApp2;
using NUnit.Framework;
using System.Linq;

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
        public void GetSquaresUpTo_Normal()
        {
            var result = Logic.GetSquaresUpTo(9);
            Assert.That(result, Is.EqualTo(new int[]{ 1, 4, 9 }));
        }

        [Test]
        public void GetSquaresUpTo_Zero()
        {
            var result = Logic.GetSquaresUpTo(0);
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GetSquaresUpTo_Negative()
        {
            var result = Logic.GetSquaresUpTo(-5);
            Assert.That(result, Is.Empty);
        }
    }
}