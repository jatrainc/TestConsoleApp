using System.Collections.Generic;
namespace TestConsoleApp.Customer
{
    public abstract class Family
    {
        public abstract Dictionary<int, decimal> PayStructure { get; set; }
    }
}