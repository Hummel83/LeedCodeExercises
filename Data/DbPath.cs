using System.Reflection;
using System.IO;

namespace LeedCodeDatabase
{
   public class DbPath
    {
        public string GetPathString()
        {
            var path = Directory.GetCurrentDirectory();

            return path;
        }

    }
}
