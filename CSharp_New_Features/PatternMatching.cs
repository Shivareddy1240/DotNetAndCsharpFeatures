using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndCSharp_Features
{
    public class PatternMatching
    {
        //Relational Pattern Matching
        public static string CheckValidMeasurement(double measurement) => measurement switch
        {
            < 0 => "Low",
            > 15.0 => "High",
            double.NaN => "unknown",
            _ => "Accept",
        };

        //Positional Pattern Matching
        public static decimal DiscountPrice(int NumberOfPerson, DateTime visitDate) => (NumberOfPerson, visitDate.DayOfWeek)
            switch
        {
            ( <= 0, _) => throw new ArgumentException("Group size invalid"),
            (_, DayOfWeek.Saturday or DayOfWeek.Sunday) => 0.0m,
            ( >= 5 and < 10, DayOfWeek.Monday) => 20.0m,
            ( >=10, DayOfWeek.Monday) => 30.0m,
            (>=10,_)=>15.0m,
            _=> 0.0m
        };

        //Constant Pattern MAtching
        public static decimal TollCharge(int passengers) => passengers switch
        {
            1 => 12.0m,
            2 => 20.0m,
            3 => 27.0m,
            _ => 0.0m,
        };
    }
}
