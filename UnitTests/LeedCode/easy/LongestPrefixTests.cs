using LeedCodeBusiness.Algos.easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.LeedCode.easy
{
   public  class LongestPrefixTests
    {
        [Fact]
        public void CheckTwoEqualCharsTrue()
        {
            //Arrange            
            var Input = new string[] {"flower", "flow", "flight"};
            var exep = "fl";

            //Act
            var output = new LongestPrefix().LongestCommonPrefix(Input);

            //Assert
            Assert.Equal(exep, output);
        }

        [Fact]
        public void CheckThreeDifferentStrings()
        {
            //Arrange            
            var Input = new string[] { "dog", "racecar", "car" };
            var exep = "";

            //Act
            var output = new LongestPrefix().LongestCommonPrefix(Input);

            //Assert
            Assert.Equal(exep, output);
        }
    }
}
