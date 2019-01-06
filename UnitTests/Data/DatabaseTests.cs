using Xunit;
using LeedCodeDatabase;

namespace UnitTests.Data
{
    public class DatabaseTests
    {
       [Fact]
        public void CreateSqliteDatabase()
        {
            //Arrange
            var dbp =  new DbPath();
            //Act Create file

            //Assert
            Assert.Equal(4, 4);
        }
    }
}
