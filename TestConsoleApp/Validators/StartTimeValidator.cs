using System;
using TestConsoleApp.Constants;
namespace TestConsoleApp.Validators
{
    public class StartTimeValidator
    {
        public static bool ValidateStartTime(TimeSpan startTime)
        {
            return TimeSpanConstants.ValidHours.Contains(startTime);
        }
    }
}