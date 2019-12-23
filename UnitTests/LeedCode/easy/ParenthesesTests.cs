using LeedCodeBusiness.Algos.easy;
using Xunit;

namespace UnitTests.LeedCode.easy
{
    public class ParenthesesTests
    {
        [Theory]
        [InlineData("(()())(())", "()()()")]
        public void DeleteTwoOuterParentheses(string InputValue, string ExceptValue)
        {
            //Act
            var rop = new Parentheses().RemoveOuterParentheses(InputValue);

            //Assert
            Assert.Equal(ExceptValue,rop);
        }

        [Theory]
        [InlineData("(()())(())(()(()))", "()()()()(())")]
        public void DeleteFourOuterParentheses(string InputValue, string ExceptValue)
        {
            //Act
            var rop = new Parentheses().RemoveOuterParentheses(InputValue);

            //Assert
            Assert.Equal(ExceptValue, rop);
        }

        [Theory]
        [InlineData("()()", "")]
        public void DeleteNothing(string InputValue, string ExceptValue)
        {
            //Act
            var rop = new Parentheses().RemoveOuterParentheses(InputValue);

            //Assert
            Assert.Equal(ExceptValue, rop);
        }
    }
}