using LeedCodeBusiness.Algos.easy;
using Xunit;

namespace UnitTests.LeedCode.easy
{
    public class ParenthesesTests
    {
        [Fact]
        public void Test123Valid()
        {
            //Arrange
            var Input = "(()())(())";
            var output = "()()()";

            //Act
            var rop = new Parentheses().RemoveOuterParentheses(Input);

            //Assert
            Assert.Equal(rop, output);
        }
    }
}