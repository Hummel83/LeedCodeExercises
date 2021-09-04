using LeedCodeBusiness.Algos.easy;
using Xunit;

namespace UnitTests.LeedCode.easy
{
    public class LongestCommonPreTests
    {
        [Fact]
        public void CheckValidOutputExample1()
        {
            //Arrange
            var lcp = new LongestCommonPre();
            var input = BuildInput1();

            var exep = "fl";

            //Act
            var output = lcp.LongestCommonPrefix(input);

            //Assert
            Assert.Equal(exep, output);
        }

        [Fact]
        public void CheckValidOutputExample2()
        {
            //Arrange
            var lcp = new LongestCommonPre();
            var input = BuildInput2();

            var exep = "";

            //Act
            var output = lcp.LongestCommonPrefix(input);

            //Assert
            Assert.Equal(exep, output);
        }

        private static string[] BuildInput1()
        {
            var input = new string[2];
            input[0] = "flower";
            input[1] = "flow";
            input[2] = "flight";
            return input;
        }
        private static string[] BuildInput2()
        {
            var input = new string[2];
            input[0] = "dog";
            input[1] = "racecar";
            input[2] = "car";
            return input;
        }
    }
}