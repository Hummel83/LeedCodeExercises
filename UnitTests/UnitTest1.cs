using System;
using Xunit;


namespace UnitTests
{
    
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            Assert.Equal(4,4);
        }

        [Fact]
        public void TestMethod2()
        {
            Assert.Equal(4, 4);
        }

        [Fact]
        public void TestMethod3()
        {
            Assert.Equal(4, 4);
        }

    }
   
}
