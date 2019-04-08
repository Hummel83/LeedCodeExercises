using LeedCodeDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
