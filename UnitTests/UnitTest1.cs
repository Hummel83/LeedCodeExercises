using LeedCodeLib;
using NUnit.Framework;


namespace UnitTests
{
    
    public class UnitTest1
    {
        [Test]
        public void Bratwursttest()
        {
            //Arrange
            var bw = new Bratwurst();
            var mi = bw.muh;
            string exp = "hello";
           

            //Assert
            Assert.AreEqual(exp, mi);
        }

        [Test]
        public void TestMethod2()
        {
            Assert.AreEqual(4, 4);
        }

        [Test]
        public void TestMethod3()
        {
            
        }

    }
   
}
