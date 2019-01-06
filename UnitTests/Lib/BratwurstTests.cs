using LeedCodeLib;
using Xunit;

namespace UnitTests.Lib
{
    public class UnitTest1
    {
        [Fact]
        public void BratwurstTest()
        {
            //Arrange
            var bw = new Bratwurst();
            var mi = bw.muh;
            string exp = "hello";
           

            //Assert
            Assert.Equal(exp, mi);
        }

        [Fact]
        public void TestMethod2()
        {
            Assert.Equal(4, 4);
        }

        [Fact]
        public void TestMethod3()
        {
            
        }

    }
   
}
