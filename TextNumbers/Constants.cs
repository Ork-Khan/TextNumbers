using System;
using System.Collections.Generic;
using System.Text;

namespace TextNumbers
{
    public static class Constants
    {
        public static Dictionary<int, string> Digits = new Dictionary<int, string>()
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

        public static Dictionary<int, string> DecimalDigits = new Dictionary<int, string>()
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

        public static Dictionary<int, string> Powers = new Dictionary<int, string>()
        {
            {2, "yüz"},
            {3, "min"},
            {6, "milyon"},
            {9, "milyard"},
            {12, "trilyon"},

            {15, "katrilyon"},
            {18, "kentilyon"},
            {21, "sekstilyon"},
            {24, "septilyon"},
            {27, "oktilyon"},
            {30, "nonilyon"},
            {33, "desilyon"},
            {36, "undesilyon"},
            {39, "dodesilyon"},
            {42, "tredesilyon"},
            {45, "katordesilyon"},
            {48, "kendesilyon"},
            {51, "seksdesilyon"},
            {54, "septendesilyon"},
            {57, "oktodesilyon"},
            {60, "novemdesilyon"},
            {63, "vigintilyon"},
        };

        public static string Negative = "mənfi";
        public static string DecimalWord = "tam";

        public static Dictionary<int, string> DigitSuffix = new Dictionary<int, string>()
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

        public static Dictionary<int, string> DecimalSuffix = new Dictionary<int, string>()
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

        public static Dictionary<int, string> PowerSuffix = new Dictionary<int, string>()
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
