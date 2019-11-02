using System;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.MinValue;
            DateTime end = DateTime.MinValue;
            Customer.Family family;
            do
            {
                Console.WriteLine("Please enter family letter (A, B, or C):  ");
                var letter = Console.ReadLine();
                family = GetFamily(letter);
                if (family != null) break;
            } while (true);

            var needToChangeStartTime = true;
            do
            {
                Console.WriteLine("Please enter start time between 5:00pm and 4:00am (mm/dd/yyyy x:00pm):");
                var x = Console.ReadLine();
                DateTime.TryParse(x, out start);
                //change to whole hours
                ChangeDateTimeToWholeHour(ref start);
                if (start != DateTime.MinValue && Validators.StartTimeValidator.ValidateStartTime(start.TimeOfDay))
                {
                    do
                    {
                        Console.WriteLine("Please enter end time after start time and between 5:00pm and 4:00am (mm/dd/yyyy x:00am):");
                        var y = Console.ReadLine();
                        DateTime.TryParse(y, out end);
                        //change to whole hours
                        ChangeDateTimeToWholeHour(ref end);
                        if (end != DateTime.MinValue &&
                            Validators.EndTimeValidator.ValidateEndTime(end.TimeOfDay) &&
                            Validators.EndTimeValidator.ValidateStartEndTime(start, end))
                        {
                            needToChangeStartTime = false;
                            break;
                        }
                    } while (true);
                }
                if (!needToChangeStartTime) break;
            } while (true);

            var answer = Calculators.Calculator.CalculateTotalPay(family, start, end);
            Console.WriteLine($"Total Pay - {answer}");
        }

        private static Customer.Family GetFamily(string familyLetter)
        {
            return familyLetter switch
            {
                "A" => new Customer.FamilyA(),
                "B" => new Customer.FamilyB(),
                "C" => new Customer.FamilyC(),
                _ => null,
            };
        }
        private static void ChangeDateTimeToWholeHour(ref DateTime dateTime)
        {
            var newValue = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0);
            dateTime = newValue;
        }
    }
}