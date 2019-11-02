using System.Collections.Generic;

namespace TestConsoleApp.Customer
{
    public class FamilyC : Family
    {
        private const decimal _rateBeforeNine = 21.00m;
        private const decimal _rateNineAndAfter = 15.00m;

        public FamilyC()
        {
            PayStructure = new Dictionary<int, decimal>
            {
                { 17, _rateBeforeNine },
                { 18, _rateBeforeNine },
                { 19, _rateBeforeNine },
                { 20, _rateBeforeNine },
                { 21, _rateNineAndAfter },
                { 22, _rateNineAndAfter },
                { 23, _rateNineAndAfter },
                { 0, _rateNineAndAfter },
                { 1, _rateNineAndAfter },
                { 2, _rateNineAndAfter },
                { 3, _rateNineAndAfter },
                { 4, _rateNineAndAfter }
            };
        }
        public override Dictionary<int, decimal> PayStructure { get; set; }
    }
}