using LeedCodeBusiness.Algos.easy;
using Xunit;

namespace UnitTests.LeedCode.easy
{
    public class ConcatenationOfArrayTests
    {
        [Fact]
        public void CheckValidOutputExample1()
        {
            //Arrange
            var ca = new ConcatenationOfArray();
            var input = BuildInput();

            var exep = BuilExpectedOutput();

            //Act
            var output = ca.GetConcatenation(input);

            //Assert
            Assert.Equal(exep, output);
        }

        private static int[] BuildInput()
        {
            var input = new int[2];
            input[0] = 1;
            input[1] = 2;
            input[2] = 1;
            return input;
        }

        private static int[] BuilExpectedOutput()
        {
            var input = new int[5];
            input[0] = 1;
            input[1] = 2;
            input[2] = 1;
            input[3] = 1;
            input[4] = 2;
            input[5] = 1;
            return input;
        }
    }
}