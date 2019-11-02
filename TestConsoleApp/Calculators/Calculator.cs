using System;
using TestConsoleApp.Validators;
using TestConsoleApp.Exceptions;
namespace TestConsoleApp.Calculators
{
    public class Calculator
    {
        public static decimal CalculateTotalPay(Customer.Family family, DateTime startTime, DateTime endTime)
        {
            StartTimeValidator.ValidateStartTime(startTime.TimeOfDay);
            EndTimeValidator.ValidateEndTime(endTime.TimeOfDay);

            if (startTime > endTime) throw new StartTimeGreaterThanEndTimeException();

            var hoursBetween = (endTime - startTime).Hours;
            //determine first hour
            var firstHour = startTime.Hour;
            //loop control
            var inLoopTimeSpan = new TimeSpan(firstHour, 0, 0);
            //return variable
            var totalPay = 0.00m;
            for (int i = 0; i < hoursBetween; i++)  //full hours are billed
            {
                totalPay += family.PayStructure[inLoopTimeSpan.Hours];
                inLoopTimeSpan = inLoopTimeSpan.Add(new TimeSpan(1, 0, 0));
            }
            return totalPay;
        }
    }
}