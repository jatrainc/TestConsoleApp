using NUnit.Framework;
using System;
using TestConsoleApp.Validators;
namespace BabySitterTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
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