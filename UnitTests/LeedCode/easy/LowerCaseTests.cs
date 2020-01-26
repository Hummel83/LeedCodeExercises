using LeedCodeBusiness.Algos.easy;
using Xunit;

namespace UnitTests.LeedCode.easy
{
    public class LowerCaseTests
    {
        [Theory]
        [InlineData("Hello", "hello")]
        [InlineData("BaRtWorst", "bartworst")]
        public void CheckParsingToLowerCasing(string input, string execp)
        {
            //Arrange
            var lc = new LowerCase();

            //Act
            var output = lc.ToLowerCase(input);

            //Assert
            Assert.Equal(execp, output);
        }
    }
}