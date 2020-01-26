using LeedCodeBusiness.Algos.easy;
using Xunit;

namespace UnitTests.LeedCode.easy
{
    public class PalidromTests
    {
        [Fact]
        public void Test121Valid()
        {
            //Arrange
            int input = 121;
            bool output = true;

            //Act
            var pd = new Palidrom().IsPalindrome(input);

            //Assert
            Assert.Equal(pd, output);
        }

        [Fact]
        public void TestMinus121Valid()
        {
            //Arrange
            int input = -121;
            bool output = false;

            //Act
            var pd = new Palidrom().IsPalindrome(input);

            //Assert
            Assert.Equal(pd, output);
        }

        [Fact]
        public void Test10Valid()
        {
            //Arrange
            int input = 10;
            bool output = false;

            //Act
            var pd = new Palidrom().IsPalindrome(input);

            //Assert
            Assert.Equal(pd, output);
        }

        [Fact]
        public void TestMinus2147483648Valid()
        {
            //Arrange
            int input = -2147483648;
            bool output = false;

            //Act
            var pd = new Palidrom().IsPalindrome(input);

            //Assert
            Assert.Equal(pd, output);
        }
    }
}