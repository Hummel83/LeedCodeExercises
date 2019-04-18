using LeedCodeBusiness.Algos.easy;
using Xunit;

namespace UnitTests.LeedCode.easy
{
    public class ReverseIntegerTests
    {
        [Fact]
        public void Test123Valid()
        {
            //Arrange
            int input = 123;
            int output = 321;

            //Act
            var ri = new ReverseInteger().ReverseOneInteger(input);

            //Assert
            Assert.Equal(ri, output);
        }

        [Fact]
        public void TestNegativ123Valid()
        {
            //Arrange
            int input = -123;
            int expect = -321;

            //Act
            int ri = new ReverseInteger().ReverseOneInteger(input);

            //Assert
            Assert.Equal(ri, expect);
        }

        [Fact]
        public void Test120Valid()
        {
            //Arrange
            int input = 120;
            int output = 21;

            //Act
            var ri = new ReverseInteger().ReverseOneInteger(input);

            //Assert
            Assert.Equal(ri, output);
        }

        [Fact]
        public void TestNegativ98765Valid()
        {
            //Arrange
            int input = -98765;
            int expect = -56789;

            //Act
            int ri = new ReverseInteger().ReverseOneInteger(input);

            //Assert
            Assert.Equal(ri, expect);
        }
    }
}