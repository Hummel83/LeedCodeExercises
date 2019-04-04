using LeedCodeLib;
using Xunit;

namespace UnitTests.Lib
{
    public class LowerCaseTests
    {
        [Fact]
        public void CheckValidOutputExample3()
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
