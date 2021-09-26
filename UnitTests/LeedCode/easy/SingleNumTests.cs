using LeedCodeBusiness.Algos.easy;
using Xunit;

namespace UnitTests.LeedCode.easy
{
    public class SingleNumTests
    {
        [Fact]
        public void CheckTragetValidWithFourNumbers()
        {
            //Arrange
            int[] Input = { 4, 1, 2, 1, 2 };
            int expec = 4;

            //Act
            var sum = new SingleNum().SingleNumber(Input);

            //Assert
            Assert.Equal(expec, sum);
        }

        [Fact]
        public void CheckTragetValidWithOneNumbers()
        {
            //Arrange
            int[] Input = { 1 };
            int expec = 1;

            //Act
            var sum = new SingleNum().SingleNumber(Input);

            //Assert
            Assert.Equal(expec, sum);
        }

        [Fact]
        public void CheckTragetValidWithThreeNumbers()
        {
            //Arrange
            int[] Input = { 2, 2, 1 };
            int expec = 1;

            //Act
            var sum = new SingleNum().SingleNumber(Input);

            //Assert
            Assert.Equal(expec, sum);
        }
    }
}