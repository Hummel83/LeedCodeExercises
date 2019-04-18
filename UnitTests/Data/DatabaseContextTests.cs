using LeedCodeDatabase;
using Xunit;

namespace UnitTests.Data
{
    public class DatabaseContextTests
    {
        [Fact]
        public void CheckDatabaseObjectIsNotEmpty()
        {
            //Arrange
            var Fd = new FakeData().GetFakeBeer();
            var Of = new UoF();

            //Act
            Of.Saver(Fd);

            //Assert
            Assert.NotNull(Of);
        }
    }
}