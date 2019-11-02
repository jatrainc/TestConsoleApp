using NUnit.Framework;
using System;
using TestConsoleApp.Validators;
using TestConsoleApp.Calculators;
namespace BabySitterTest
{
    public class Tests
    {
        private TestConsoleApp.Customer.FamilyA _familyA;
        private TestConsoleApp.Customer.FamilyB _familyB;
        private TestConsoleApp.Customer.FamilyC _familyC;
        [SetUp]
        public void Setup()
        {
            _familyA = new TestConsoleApp.Customer.FamilyA();
            _familyB = new TestConsoleApp.Customer.FamilyB();
            _familyC = new TestConsoleApp.Customer.FamilyC();
        }
        [Test]
        public void TestFamilyATotalHours()
        {
            DateTime startTime = new DateTime(2019, 10, 1, 17, 0, 0);
            DateTime endTime = new DateTime(2019, 10, 2, 4, 0, 0);
            decimal totalPay = Calculator.CalculateTotalPay(_familyA, startTime, endTime);
            Assert.AreEqual(190.00m, totalPay);
        }

        [Test]
        public void TestFamilyA6pmTo2am()
        {
            DateTime startTime = new DateTime(2019, 10, 1, 18, 0, 0);
            DateTime endTime = new DateTime(2019, 10, 2, 2, 0, 0);
            decimal totalPay = Calculator.CalculateTotalPay(_familyA, startTime, endTime);
            Assert.AreEqual(135.00m, totalPay);
        }

        [Test]
        public void TestFamilyA5pmToMidnight()
        {
            DateTime startTime = new DateTime(2019, 10, 1, 17, 0, 0);
            DateTime endTime = new DateTime(2019, 10, 2, 0, 0, 0);
            decimal totalPay = Calculator.CalculateTotalPay(_familyA, startTime, endTime);
            Assert.AreEqual(110.00m, totalPay);
        }

        [Test]
        public void TestFamilyAMidnightTo4am()
        {
            DateTime startTime = new DateTime(2019, 10, 2, 0, 0, 0);
            DateTime endTime = new DateTime(2019, 10, 2, 4, 0, 0);
            decimal totalPay = Calculator.CalculateTotalPay(_familyA, startTime, endTime);
            Assert.AreEqual(80.00m, totalPay);
        }

        [Test]
        public void TestFamilyBTotalHours()
        {
            DateTime startTime = new DateTime(2019, 10, 1, 17, 0, 0);
            DateTime endTime = new DateTime(2019, 10, 2, 4, 0, 0);
            decimal totalPay = Calculator.CalculateTotalPay(_familyB, startTime, endTime);
            Assert.AreEqual(140.00m, totalPay);
        }

        [Test]
        public void TestFamilyB6pmTo2am()
        {
            DateTime startTime = new DateTime(2019, 10, 1, 18, 0, 0);
            DateTime endTime = new DateTime(2019, 10, 2, 2, 0, 0);
            decimal totalPay = Calculator.CalculateTotalPay(_familyB, startTime, endTime);
            Assert.AreEqual(96.00m, totalPay);
        }

        [Test]
        public void TestFamilyB5pmToMidnight()
        {
            DateTime startTime = new DateTime(2019, 10, 1, 17, 0, 0);
            DateTime endTime = new DateTime(2019, 10, 2, 0, 0, 0);
            decimal totalPay = Calculator.CalculateTotalPay(_familyB, startTime, endTime);
            Assert.AreEqual(76.00m, totalPay);
        }

        [Test]
        public void TestFamilyBMidnightTo4am()
        {
            DateTime startTime = new DateTime(2019, 10, 2, 0, 0, 0);
            DateTime endTime = new DateTime(2019, 10, 2, 4, 0, 0);
            decimal totalPay = Calculator.CalculateTotalPay(_familyB, startTime, endTime);
            Assert.AreEqual(64.00m, totalPay);
        }

        [Test]
        public void TestFamilyC6pmto2am()
        {
            DateTime startTime = new DateTime(2019, 10, 1, 18, 0, 0);
            DateTime endTime = new DateTime(2019, 10, 2, 2, 0, 0);
            decimal totalPay = Calculator.CalculateTotalPay(_familyC, startTime, endTime);
            Assert.AreEqual(138.00m, totalPay);
        }

        [Test]
        public void TestFamilyCTotalHours()
        {
            DateTime startTime = new DateTime(2019, 10, 1, 17, 0, 0);
            DateTime endTime = new DateTime(2019, 10, 2, 4, 0, 0);
            decimal totalPay = Calculator.CalculateTotalPay(_familyC, startTime, endTime);
            Assert.AreEqual(189.00m, totalPay);
        }

        [Test]
        public void TestFamilyC5pmToMidnight()
        {
            DateTime startTime = new DateTime(2019, 10, 1, 17, 0, 0);
            DateTime endTime = new DateTime(2019, 10, 2, 0, 0, 0);
            decimal totalPay = Calculator.CalculateTotalPay(_familyC, startTime, endTime);
            Assert.AreEqual(129.00m, totalPay);
        }

        [Test]
        public void TestFamilyCMidnightTo4am()
        {
            DateTime startTime = new DateTime(2019, 10, 2, 0, 0, 0);
            DateTime endTime = new DateTime(2019, 10, 2, 4, 0, 0);
            decimal totalPay = Calculator.CalculateTotalPay(_familyC, startTime, endTime);
            Assert.AreEqual(60.00m, totalPay);
        }
        [Test]
        public void TestStartTime()
        {
            //start is valid
            DateTime startTime = new DateTime(2019, 10, 1, 18, 0, 0);
            Assert.AreEqual(true, StartTimeValidator.ValidateStartTime(startTime.TimeOfDay));

            //start time is invalid
            startTime = new DateTime(2019, 10, 1, 12, 0, 0);
            Assert.AreEqual(false, StartTimeValidator.ValidateStartTime(startTime.TimeOfDay));
        }

        [Test]
        public void TestEndTime()
        {
            //end time is valid
            DateTime endTime = new DateTime(2019, 10, 2, 2, 0, 0);
            Assert.AreEqual(true, EndTimeValidator.ValidateEndTime(endTime.TimeOfDay));

            //end time is invalid
            endTime = new DateTime(2019, 10, 2, 5, 0, 0);
            Assert.AreEqual(false, EndTimeValidator.ValidateEndTime(endTime.TimeOfDay));
        }

        [Test]
        public void TestStartAndEndTime()
        {
            //start time and end time are valid
            DateTime startTime = new DateTime(2019, 10, 1, 18, 0, 0);
            DateTime endTime = new DateTime(2019, 10, 2, 2, 0, 0);
            Assert.AreEqual(true, EndTimeValidator.ValidateStartEndTime(startTime, endTime));

            //start time is after end time
            startTime = new DateTime(2019, 10, 1, 22, 0, 0);
            endTime = new DateTime(2019, 10, 1, 21, 0, 0);
            Assert.AreEqual(false, EndTimeValidator.ValidateStartEndTime(startTime, endTime));

            //end time is after start time, but outside the 5:00pm to 4:00am window
            startTime = new DateTime(2019, 10, 1, 17, 0, 0);
            endTime = new DateTime(2019, 10, 2, 18, 0, 0);
            Assert.AreEqual(false, EndTimeValidator.ValidateStartEndTime(startTime, endTime));
        }
    }
}