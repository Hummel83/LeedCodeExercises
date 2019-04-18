using LeedCodeDatabase.Models;

namespace UnitTests.Data
{
    public class FakeData
    {
        public Beer GetFakeBeer()
        {
            return new Beer() { Name = "Alster" };
        }
    }
}