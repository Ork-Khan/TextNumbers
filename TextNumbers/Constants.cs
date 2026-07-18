using System;
using System.Collections.Generic;
using System.Text;

namespace TextNumbers
{
    public static class Constants
    {
        public static Dictionary<int, string> Digits = new()
        {
            {0, "sıfır"},
            {1, "bir"},
            {2, "iki"},
            {3, "üç"},
            {4, "dört"},
            {5, "beş"},
            {6, "altı"},
            {7, "yeddi"},
            {8, "səkkiz"},
            {9, "doqquz"},
        };

        public static Dictionary<int, string> DecimalDigits = new()
        {
            {1, "on"},
            {2, "yirmi"},
            {3, "otuz"},
            {4, "qırx"},
            {5, "əlli"},
            {6, "altmış"},
            {7, "yetmiş"},
            {8, "səksən"},
            {9, "doxsan"},            
        };

        public static Dictionary<int, string> Powers = new()
        {
            {2, "yüz"},
            {3, "min"},
            {6, "milyon"},
            {9, "milyard"},
        };

        public static string Negative = "mənfi";

        public static Dictionary<int, string> DigitSuffix = new()
        {
            {1,"də"},
            {2,"də"},
            {3,"də"},
            {4,"də"},
            {5,"də"},
            {7,"də"},
            {8,"də"},
            
            {6,"da"},
            {9,"da"},
        };

        public static Dictionary<int, string> DecimalSuffix = new()
        {
            {1,"da"},
            {3,"da"},
            {4,"da"},
            {6,"da"},
            {9,"da"},

            {2,"də"},
            {5,"də"},
            {7,"də"},
            {8,"də"},
        };

        public static Dictionary<int, string> PowerSuffix = new()
        {
            {2, "də"},
            {3, "də"},
            {6, "da"},
            {9, "da"},
        };

        public static string FractionSuffix(this int number)
        {
            var lastDigit = number % 10;
            if (lastDigit != 0)
                return DigitSuffix[lastDigit];

            int digitCount = 0;
            while(lastDigit == 0)
            {
                digitCount++;
                number /= 10;
                lastDigit = number % 10;
            }

            if (digitCount == 1)
                return DecimalSuffix[lastDigit];
            else
            {
                return (digitCount > 2) ?
                    PowerSuffix[(digitCount/3) * 3] :
                    PowerSuffix[digitCount];
            }
        }
    }
}
