using NUnit.Framework;
using ConsoleApp1;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_TrainAtStation_PassengerDuringStop()
        {
            string[] arrivalInput = new string[] { "12", "30" };
            string[] departureInput = new string[] { "13", "00" };
            string[] passengerInput = new string[] { "12", "45" };
            string expected = "Поезд стоит на платформе";
            string result = Logic.CountTime(arrivalInput, departureInput, passengerInput);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_TrainNotAtStation_PassengerBeforeArrival()
        {
            string[] arrivalInput = new string[] { "12", "30" };
            string[] departureInput = new string[] { "13", "00" };
            string[] passengerInput = new string[] { "12", "00" };
            string expected = "Поезда нет на платформе";
            string result = Logic.CountTime(arrivalInput, departureInput, passengerInput);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_TrainNotAtStation_PassengerAfterDeparture()
        {
            string[] arrivalInput = new string[] { "12", "30" };
            string[] departureInput = new string[] { "13", "00" };
            string[] passengerInput = new string[] { "13", "15" };
            string expected = "Поезда нет на платформе";
            string result = Logic.CountTime(arrivalInput, departureInput, passengerInput);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_TrainAtStation_Night()
        {
            string[] arrivalInput = new string[] { "23", "30" };
            string[] departureInput = new string[] { "01", "30" };
            string[] passengerInput = new string[] { "00", "45" };
            string expected = "Поезд стоит на платформе";
            string result = Logic.CountTime(arrivalInput, departureInput, passengerInput);
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void Test_TrainAtStation_EmptyInput()
        {
            string[] arrivalInput = new string[] { "", "" };
            string[] departureInput = new string[] { "01", "30" };
            string[] passengerInput = new string[] { "00", "45" };
            string expected = "Ошибка: введены не все значения времени";
            string result = Logic.CountTime(arrivalInput, departureInput, passengerInput);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}