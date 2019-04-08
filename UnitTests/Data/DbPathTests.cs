using LeedCodeDatabase;
using Xunit;

namespace UnitTests.Data
{
    public class DbPathTests
    {      
        [Fact]
        public void CheckDbPath()
        {
            //Arrange
            var dbp = new DbPath();
            string expectedpath = "F:\\DEV_Projects\\Projects\\LeedCodeExercises\\UnitTests\\bin\\Debug";

            //Act 
            var path = dbp.GetPathString();

            //Assert
            Assert.Equal(expectedpath, path);
        }
    }
}