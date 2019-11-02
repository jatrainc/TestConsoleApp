using System;
using System.Collections.Generic;

namespace TestConsoleApp.Constants
{
    public class TimeSpanConstants
    {
        public static readonly TimeSpan _fivePm = new TimeSpan(17, 0, 0);
        public static readonly TimeSpan _sixPm = new TimeSpan(18, 0, 0);
        public static readonly TimeSpan _sevenPm = new TimeSpan(19, 0, 0);
        public static readonly TimeSpan _eightPm = new TimeSpan(20, 0, 0);
        public static readonly TimeSpan _ninePm = new TimeSpan(21, 0, 0);
        public static readonly TimeSpan _tenPm = new TimeSpan(22, 0, 0);
        public static readonly TimeSpan _elevenPm = new TimeSpan(23, 0, 0);
        public static readonly TimeSpan _midnight = new TimeSpan(0, 0, 0);
        public static readonly TimeSpan _oneAm = new TimeSpan(1, 0, 0);
        public static readonly TimeSpan _twoAm = new TimeSpan(2, 0, 0);
        public static readonly TimeSpan _threeAm = new TimeSpan(3, 0, 0);
        public static readonly TimeSpan _fourAm = new TimeSpan(4, 0, 0);

        public static readonly TimeSpan _fiveAm = new TimeSpan(5, 0, 0);
        public static readonly TimeSpan _sixAm = new TimeSpan(6, 0, 0);
        public static readonly TimeSpan _sevenAm = new TimeSpan(7, 0, 0);
        public static readonly TimeSpan _eightAm = new TimeSpan(8, 0, 0);
        public static readonly TimeSpan _nineAm = new TimeSpan(9, 0, 0);
        public static readonly TimeSpan _tenAm = new TimeSpan(10, 0, 0);
        public static readonly TimeSpan _elevenAm = new TimeSpan(11, 0, 0);
        public static readonly TimeSpan _noon = new TimeSpan(12, 0, 0);
        public static readonly TimeSpan _onePm = new TimeSpan(13, 0, 0);
        public static readonly TimeSpan _twoPm = new TimeSpan(14, 0, 0);
        public static readonly TimeSpan _threePm = new TimeSpan(15, 0, 0);
        public static readonly TimeSpan _fourPm = new TimeSpan(16, 0, 0);

        public static IList<TimeSpan> ValidHours = new List<TimeSpan> { _midnight, _oneAm, _twoAm, _threeAm, _fourAm, _fivePm, _sixPm, _sevenPm, _eightPm, _ninePm, _tenPm, _elevenPm };
        public static IList<TimeSpan> InvalidHours = new List<TimeSpan> { _noon, _onePm, _twoPm, _threePm, _fourPm, _fiveAm, _sixAm, _sevenAm, _eightAm, _nineAm, _tenAm, _elevenAm };
    }
}