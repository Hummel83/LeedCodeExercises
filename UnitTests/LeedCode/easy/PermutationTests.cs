using LeedCodeBusiness.Algos.easy;
using Xunit;

namespace UnitTests.LeedCode.easy
{
    public class PermutationTests
    {
        [Fact]
        public void BuildArrayValid()
        {
            //Arrange
            var input = new int[] { 0, 2, 1, 5, 3, 4 };
            var output = new int[] { 0, 1, 2, 4, 5, 3 };

            //Act
            var result = new Permutation().BuildArray(input);

            //Assert
            Assert.Equal(result, output);
        }
    }
}