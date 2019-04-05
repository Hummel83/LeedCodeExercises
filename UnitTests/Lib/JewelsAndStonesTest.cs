using LeedCodeLib.Algos.easy;
using Xunit;

namespace UnitTests.Lib
{
    public class JewelsAndStonesTests
    {
        [Fact]
        public void CheckValidOutputExample1()
        {
            //Arrange
            var JaS = new JewelsAndStones();
            var J = "aA";
            var S = "aAAbbbb";
            int exep = 3;

            //Act            
            var output = JaS.NumJewelsInStones(J, S);

            //Assert
            Assert.Equal(exep, output);
        }


        [Fact]
        public void CheckValidOutputExample2()
        {
            //Arrange
            var JaS = new JewelsAndStones();
            var J = "Dz";
            var S = "ZZzzADz";
            int exep = 4;

            //Act            
            var output = JaS.NumJewelsInStones(J, S);

            //Assert
            Assert.Equal(exep, output);
        }

        [Fact]
        public void CheckValidOutputExample3()
        {
            //Arrange
            var JaS = new JewelsAndStones();
            var J = "ab";
            var S = "ab6bababD";
            int exep = 7;

            //Act            
            var output = JaS.NumJewelsInStones(J, S);

            //Assert
            Assert.Equal(exep, output);

        }
    }
   
}
