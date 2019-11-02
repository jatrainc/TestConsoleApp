using System.Collections.Generic;
namespace TestConsoleApp.Customer
{
    public class FamilyB : Family
    {
        private const decimal _rateBeforeTen = 12.00m;
        private const decimal _rateBetweenTenAndMidnight = 8.00m;
        private const decimal _rateMidnightAndAfter = 16.00m;

        public FamilyB()
        {
            PayStructure = new Dictionary<int, decimal>
            {
                { 17, _rateBeforeTen },
                { 18, _rateBeforeTen },
                { 19, _rateBeforeTen },
                { 20, _rateBeforeTen },
                { 21, _rateBeforeTen },
                { 22, _rateBetweenTenAndMidnight },
                { 23, _rateBetweenTenAndMidnight },
                { 0, _rateMidnightAndAfter },
                { 1, _rateMidnightAndAfter },
                { 2, _rateMidnightAndAfter },
                { 3, _rateMidnightAndAfter },
                { 4, _rateMidnightAndAfter }
            };
        }
        public override Dictionary<int, decimal> PayStructure { get; set; }
    }
}