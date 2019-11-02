using System.Collections.Generic;

namespace TestConsoleApp.Customer
{
    public class FamilyA : Family
    {
        private const decimal _rateBeforeEleven = 15.00m;
        private const decimal _rateAtElevenAndAfter = 20.00m;

        public override Dictionary<int, decimal> PayStructure { get; set; }

        public FamilyA()
        {
            PayStructure = new Dictionary<int, decimal>
            {
                { 17, _rateBeforeEleven },
                { 18, _rateBeforeEleven },
                { 19, _rateBeforeEleven },
                { 20, _rateBeforeEleven },
                { 21, _rateBeforeEleven },
                { 22, _rateBeforeEleven },
                { 23, _rateAtElevenAndAfter },
                { 0, _rateAtElevenAndAfter },
                { 1, _rateAtElevenAndAfter },
                { 2, _rateAtElevenAndAfter },
                { 3, _rateAtElevenAndAfter },
                { 4, _rateAtElevenAndAfter }
            };
        }
    }
}