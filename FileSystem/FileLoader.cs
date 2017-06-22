using System.IO;

namespace Zeiss.PersonManager.Data.FileSystem
{
    public class FileLoader
    {
        private readonly string _path;

        public FileLoader(string path)
        {
            _path = path;
        }

        public string[] Load()
        {
            var lines = File
                .ReadAllLines(_path);
            return lines;
        }
    }
}