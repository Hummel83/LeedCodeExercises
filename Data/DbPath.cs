using System.IO;

namespace LeedCodeDatabase
{
    public class DbPath
    {
        public string Path { get; set; }

        public string GetPathString()
        {
            Path = Directory.GetCurrentDirectory();

            return Path;
        }
    }
}