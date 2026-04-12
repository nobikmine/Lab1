using NUnit.Framework;
using ConsoleApp1;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test_TrainAtStation_PassengerDuringStop()
        {
            string expected = "Поезд стоит на платформе";
            string result = Logic.CountTime(12, 30, 13, 0, 12, 45);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_TrainNotAtStation_PassengerBeforeArrival()
        {
            string expected = "Поезда нет на платформе";
            string result = Logic.CountTime(12, 30, 13, 0, 12, 0);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_TrainNotAtStation_PassengerAfterDeparture()
        {
            string expected = "Поезда нет на платформе";
            string result = Logic.CountTime(12, 30, 13, 0, 13, 15);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_TrainAtStation_Night()
        {
            string expected = "Поезд стоит на платформе";
            string result = Logic.CountTime(23, 30, 1, 30, 0, 45);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_InvalidTime()
        {
            string expected = "Ошибка: некорректное время";
            string result = Logic.CountTime(-1, 0, 1, 30, 0, 45);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}