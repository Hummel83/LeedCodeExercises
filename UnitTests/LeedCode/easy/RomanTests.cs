using LeedCodeBusiness.Algos.easy;
using Xunit;

namespace UnitTests.LeedCode.easy
{
    public class RomanTests
    {
        [Fact]
        public void TestRomanNumber1Vaild()
        {
            //Arrange
            string input = "I";
            int expect = 1;

            //Act
            var rn = new Roman().RomanToInt(input);

            //Assert
            Assert.Equal(expect, rn);
        }

        [Fact]
        public void TestRomanNumber9Vaild()
        {
            //Arrange
            string input = "IX";
            int expect = 9;

            //Act
            var rn = new Roman().RomanToInt(input);

            //Assert
            Assert.Equal(expect, rn);
        }

        [Fact]
        public void TestRomanNumber15Vaild()
        {
            //Arrange
            string input = "XV";
            int expect = 15;

            //Act
            var rn = new Roman().RomanToInt(input);

            //Assert
            Assert.Equal(expect, rn);
        }

       

        [Fact]
        public void TestRomanNumber58Vaild()
        {
            //Arrange
            string input = "LVIII";
            int expect = 58;

            //Act
            var rn = new Roman().RomanToInt(input);

            //Assert
            Assert.Equal(expect, rn);
        }

        [Fact]
        public void TestRomanNumber1994Vaild()
        {
            //Arrange
            string input = "MCMXCIV";
            int expect = 1994;

            //Act
            var rn = new Roman().RomanToInt(input);

            //Assert
            Assert.Equal(expect, rn);
        }

        [Fact]
        public void TestRomanNumber1888Vaild()
        {
            //Arrange
            string input = "MDCCCLXXXVIII";
            int expect = 1888;

            //Act
            var rn = new Roman().RomanToInt(input);

            //Assert
            Assert.Equal(expect, rn);
        }

        [Fact]
        public void TestRomanNumber99Vaild()
        {
            //Arrange
            string input = "XCIX";
            int expect = 99;

            //Act
            var rn = new Roman().RomanToInt(input);

            //Assert
            Assert.Equal(expect, rn);
        }

        [Fact]
        public void TestRomanNumber999Vaild()
        {
            //Arrange
            string input = "CMXCIX";
            int expect = 999;

            //Act
            var rn = new Roman().RomanToInt(input);

            //Assert
            Assert.Equal(expect, rn);
        }

        [Fact]
        public void TestRomanNumber3999Vaild()
        {
            //Arrange
            string input = "MMMCMXCIX";
            int expect = 3999;

            //Act
            var rn = new Roman().RomanToInt(input);

            //Assert
            Assert.Equal(expect, rn);
        }
    }
}