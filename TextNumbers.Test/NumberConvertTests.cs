using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TextNumbers;


namespace TextNumbers.Test
{
    public class NumberConvertTests
    {
        //Positive whole numbers

        [Theory]
        [InlineData(5,"beş")]
        [InlineData(0,"sıfır")]
        [InlineData(1,"bir")]
        [InlineData(9,"doqquz")]
        public void Convert_ShouldWorkSimple(int number, string expected)
        {
    
            //Act
            var actual = NumberConvert.Convert(number);
            //Assert
            Assert.Equal(expected, actual);
        }

        //positive 2 digit whole numbers
        [Theory]
        [InlineData(15, "on beş")]
        [InlineData(20, "yirmi")]
        [InlineData(42, "qırx iki")]
        [InlineData(38, "otuz səkkiz")]
        public void Convert_TwoDigitsShouldWork(int number, string expected)
        {

            //Act
            var actual = NumberConvert.Convert(number);
            //Assert
            Assert.Equal(expected, actual);
        }

        //positive 2+ digits whole numbers
        [Theory]
        [InlineData(180, "yüz səksən")]
        [InlineData(500, "beş yüz")]
        [InlineData(1784, "min yeddi yüz səksən dört")]
        [InlineData(10008, "on min səkkiz")]
        [InlineData(423458, "dört yüz yirmi üç min dört yüz əlli səkkiz")]
        public void Convert_ManyDigitsShouldWork(int number, string expected)
        {

            //Act
            var actual = NumberConvert.Convert(number);
            //Assert
            Assert.Equal(expected, actual);
        }

        //Negative whole numbers
        [Theory]
        [InlineData(-2, "mənfi iki")]
        [InlineData(-0, "sıfır")] //edge case -0 is 0
        [InlineData(-561, "mənfi beş yüz altmış bir")]
        [InlineData(-3708, "mənfi üç min yeddi yüz səkkiz")]
        [InlineData(-46011, "mənfi qırx altı min on bir")]
        public void Convert_NegativeNumbersShouldWork(int number, string expected)
        {

            //Act
            var actual = NumberConvert.Convert(number);
            //Assert
            Assert.Equal(expected, actual);
        }

        //Rational positive numbers
        [Theory]
        [InlineData(3.6,"üç tam onda altı")]
        [InlineData(5.0,"beş")] //edge case doubles with no fractions are integers
        [InlineData(2.60,"iki tam onda altı")] //edge case extra zero on fractions doesn't change value
        [InlineData(2.61,"iki tam yüzdə altmış bir")]
        [InlineData(32.018,"otuz iki tam mində on səkkiz")]
        [InlineData(0.00142,"sıfır tam yüz mində yüz qırx iki")]
        [InlineData(0.1,"sıfır tam onda bir")]
        public void Convert_PositiveWholeNumbersShouldWork(decimal number, string expected)
        {

            //Act
            var actual = NumberConvert.Convert(number);
            //Assert
            Assert.Equal(expected, actual);
        }

        //Rational negative numbers
        [Theory]
        [InlineData(-104.89, "mənfi yüz dört tam yüzdə səksən doqquz")]
        [InlineData(-32.0091, "mənfi otuz iki tam on mində doxsan bir")]
        [InlineData(-3.333, "mənfi üç tam mində üç yüz otuz üç")]
        [InlineData(-0.9, "mənfi sıfır tam onda doqquz")]
        [InlineData(-0.0, "sıfır")] //edge case negative 0 with zero fraction is just zero
        public void Convert_NegativeWholeNumbersShouldWork(decimal number, string expected)
        {
            //Act
            var actual = NumberConvert.Convert(number);
            //Assert
            Assert.Equal(expected, actual);
        }



    }
}
