using NUnit.Framework;

namespace Tests
{
    public class Tests
    {

      

        [Test]
        public void Builddatatbase_Test()
        {
            var muh = new DAL.BuildDatabase();
            muh.CreateDb();
           
        }
    }
}