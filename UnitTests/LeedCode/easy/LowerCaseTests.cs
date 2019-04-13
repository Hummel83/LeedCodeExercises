﻿using LeedCodeBusiness.Algos.easy;
using Xunit;

namespace UnitTests.LeedCode.easy
{
    public class LowerCaseTests
    {
        [Fact]
        public void CheckParsingToLowerCasing()
        {
            //Arrange
            var lc = new LowerCase();
            var Input = "Hello";
            var exep = "hello";

            //Act
            var output = lc.ToLowerCase(Input);

            //Assert
            Assert.Equal(exep, output);
        }
    }
}