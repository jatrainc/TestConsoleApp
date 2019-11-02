using System;
using TestConsoleApp.Constants;
namespace TestConsoleApp.Validators
{
    public class EndTimeValidator
    {
        public static bool ValidateEndTime(TimeSpan endTime)
        {
            return TimeSpanConstants.ValidHours.Contains(endTime);
        }
        public static bool ValidateStartEndTime(DateTime start, DateTime end)
        {
            if (!TimeSpanConstants.ValidHours.Contains(start.TimeOfDay)) return false;
            if (!TimeSpanConstants.ValidHours.Contains(end.TimeOfDay)) return false;
            if (start >= end) return false;
            if ((end - start).TotalHours > 11) return false;  // end is a valid time of day but ran past 4:00am the next day
            return true;
        }
    }
}