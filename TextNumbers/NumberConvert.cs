using System;
using System.Collections.Generic;
using System.Text;

namespace TextNumbers
{
    public static class NumberConvert
    {
        public static string Convert(int number)
        {
            if (number == 0)
                return Constants.Digits[number];
            
            bool isNegative = number < 0;
            number = Math.Abs(number);

            var digitCount = (int)Math.Floor(Math.Log10(number));
            var scalePower = (int)Math.Pow(10, digitCount);
            var digit = number / scalePower;
               
            string result = string.Empty;

            if(digitCount == 0)
                result = Constants.Digits[digit];

            else if(digitCount == 1)
            {
                var rest = number % scalePower;
                var decimalDigit = Constants.DecimalDigits[digit];
                if (rest == 0)
                    result = decimalDigit;
                else
                    result = string.Join(" ", decimalDigit, Convert(rest));
            }
            else if (digitCount == 2)
            {
                var rest = number % scalePower;
                string hundredDigit;
                hundredDigit = (digit > 1) ? 
                                Constants.Digits[digit] + " " + Constants.Powers[digitCount] :
                                Constants.Powers[digitCount];

                result = (rest == 0) ? 
                        hundredDigit :
                        string.Join(" ", hundredDigit, Convert(rest));
            }
            else
            {
                int shortScale = digitCount / 3;
                int shortScalePart = number / (int)Math.Pow(10, shortScale * 3);
                
                string firstPart = (shortScalePart > 1) ? 
                                    Convert(shortScalePart) + " " + Constants.Powers[3 * shortScale] : 
                                    Constants.Powers[3 * shortScale];

                var rest = number % (int)Math.Pow(10, shortScale * 3);

                result = (rest == 0) ? 
                    firstPart : 
                    string.Join(" ", firstPart, Convert(rest));

            }

            return (isNegative) ?
                   $"{Constants.Negative} {result}" :
                   result;
        }
        
        public static string Convert(decimal number)
        {
            bool isNegative = number < 0;
            number = Math.Abs(number);

            var result = Convert((int)number);
            var decimalPart = GetDecimalPart(number);
            if(decimalPart != null)
                result = string.Join(" ",
                    result,
                    "tam",
                    decimalPart
                );
            
            return isNegative ?
                    $"{Constants.Negative} {result}" :
                   result;

        }

        private static string? GetDecimalPart(decimal number)
        {
            // Source - https://stackoverflow.com/a/53938277
            // Posted by Rudy Velthuis, modified by community. See post 'Timeline' for change history
            // Retrieved 2026-07-18, License - CC BY-SA 4.0

            int[] bits = Decimal.GetBits(number);
            int scale = (bits[3] >> 16) & 31;               // 567.1234 represented as 5671234 x 10^-4

            decimal intPart = (int)number;                       // 567.1234 --> 567
            int power = (int)Math.Pow(10, scale);
            decimal decPart = (number - intPart) * power; // 567.1234 --> 0.1234 --> 1234

            if(decPart == 0)
                return null;

            while (decPart % 10 == 0)
                decPart /= 10;

            string suffix = power.FractionSuffix();

            return string.Join(" ",
                $"{Convert(power)}{suffix}",
                Convert((int)decPart)
            );
        }
    }
}
