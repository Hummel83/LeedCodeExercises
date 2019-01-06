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
            string expectedpath = "F:\\net.Projects\\Projects\\LeedCodeExercises\\UnitTests\\bin\\Debug";

            //Act Create file
            var path = dbp.GetPathString();
            //Assert
            Assert.Equal(expectedpath, path);
        }
    }
}
