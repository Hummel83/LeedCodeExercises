using LeedCodeDatabase.Models;

namespace LeedCodeDatabase
{
    public class UoF
    {
        public void Saver(Beer obj)
        {
            var data = new DatabaseContext();
            var bla = data.Beers.Add(obj);
            data.SaveChanges();
        }
    }
}