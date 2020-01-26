using LeedCodeBusiness.Algos.easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.LeedCode.easy
{
    public class RemoveParenthesesTests
    {

        [Fact]
        public void CheckRemove2OuterParentheses()
        {
            //Arrange
            var rp = new RemoveParentheses();
            var Input = "(()())(())";
            var exep = "()()()";

            //Act
            var output = rp.RemoveOuterParentheses(Input);

            //Assert
            Assert.Equal(exep, output);
        }

        [Fact]
        public void CheckRemove3OuterParentheses()
        {
            //Arrange
            var rp = new RemoveParentheses();
            var Input = "(()())(())(()(()))";
            var exep = "()()()()(())";

            //Act
            var output = rp.RemoveOuterParentheses(Input);

            //Assert
            Assert.Equal(exep, output);
        }

        [Fact]
        public void CheckFindNoOuterParentheses()
        {
            //Arrange
            var rp = new RemoveParentheses();
            var Input = "()()";
            var exep = "";

            //Act
            var output = rp.RemoveOuterParentheses(Input);

            //Assert
            Assert.Equal(exep, output);
        }
    }
}
